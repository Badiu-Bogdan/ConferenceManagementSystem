using ConferenceManagementSystem.main.repository;
using ConferenceManagementSystem.src.main.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.repository
{
    public class PresentationRepository<ID, T> : IRepository<ID, Presentation>
    {
        private string connectionString;
        private DataSet ds;
        private SqlDataAdapter da;

        public PresentationRepository(string conStr)
        {
            this.connectionString = conStr;
            this.da = new SqlDataAdapter();
        }

        public List<Presentation> findAll()
        {
            List<Presentation> presentations = new List<Presentation>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM Presentations";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string presentationRes = sdr[2].ToString();
                    if (presentationRes != "")
                    {
                        Presentation presentation = new Presentation(sdr[0].ToString(), sdr[1].ToString(), (byte[])sdr[2], sdr[3].ToString(), Int32.Parse(sdr[4].ToString()));
                        presentations.Add(presentation);
                    }
                    else
                    {
                        Byte[] emptyByteArray = new Byte[64];
                        Presentation presentation = new Presentation(sdr[0].ToString(), sdr[1].ToString(), emptyByteArray, sdr[3].ToString(), Int32.Parse(sdr[4].ToString()));
                        presentations.Add(presentation);
                    }
                }

                sdr.Close();
                con.Close();
                return presentations;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public Presentation findOne(ID id)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM Presentations WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@id", SqlDbType.NVarChar);
                cmd.Parameters["@id"].Value = id;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (!sdr.HasRows)
                {
                    throw new RepositoryException("Presentation not found.");
                }
                string presentationRes = sdr[2].ToString();

                Byte[] emptyByteArray = new Byte[64];
                Presentation presentation = new Presentation(sdr[0].ToString(), sdr[1].ToString(), emptyByteArray, sdr[3].ToString(), Int32.Parse(sdr[4].ToString()));

                if (presentationRes != "")
                {
                    presentation.setPresentation((byte[])sdr[2]);

                }
                sdr.Close();
                con.Close();
                return presentation;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public void save(Presentation entity)
        {
            
        }
        public void delete(ID id)
        {
            
        }

        public void update(Presentation entity)
        {
            
        }
        /*
        Read a resource from the user's local machine
        Input: path of the resource
        Output: byte array containing the bytes of that resource
         */
        private byte[] getResource(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            byte[] presentation = br.ReadBytes((int)fs.Length);

            br.Close();
            fs.Close();

            return presentation;
        }

        public string uploadPresentation(string path, string title, User user, int idAbstract, string fileFormat)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();

                byte[] presentation = getResource(path);

                // insert the presentation
                string query = "INSERT INTO Presentations(id, title, presentation, format, idabstract) OUTPUT Inserted.id VALUES (NEWID(), @title, @presentation, @format, @abstractid)";
                SqlCommand addPresentation = new SqlCommand(query, con);
                addPresentation.Parameters.Add("@title", SqlDbType.NVarChar, 95).Value = title;
                addPresentation.Parameters.Add("@presentation", SqlDbType.Image, presentation.Length).Value = presentation;
                addPresentation.Parameters.Add("@format", SqlDbType.NVarChar, 10).Value = fileFormat;
                addPresentation.Parameters.Add("@abstractid", SqlDbType.Int).Value = idAbstract;
                var idPresentation = addPresentation.ExecuteScalar();

                return ((Guid)idPresentation).ToString();

            }
            catch (SqlException e)
            {
                con.Close();
                if (e.Number == 2627)
                {
                    throw new RepositoryException("Title is not available");
                }
                throw new RepositoryException(e.Message);
            }
        }

        /*
       Download a presentation from the db to the local filesystem
       Input: presentation to be downloaded
       Output: -
        */
        public void savePresentationToFileSystem(Presentation presentation, string path)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                // Read the presentation bytes directly from the db
                con.Open();
                String query = "SELECT Presentation FROM Presentations WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@id", SqlDbType.NVarChar);
                cmd.Parameters["@id"].Value = presentation.getId();
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.SequentialAccess);
                if (!sdr.HasRows)
                {
                    throw new RepositoryException("No presentations in database.");
                }
                while (sdr.Read())
                {
                    FileStream fs = new FileStream(path + "\\" + presentation.getTitle() + "_presentation" + presentation.getFormat(), FileMode.OpenOrCreate, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);
                    long startIndex = 0;
                    long retval = 0;
                    int bufferSize = 1000;
                    byte[] outbyte = new byte[bufferSize];
                    retval = sdr.GetBytes(0, startIndex, outbyte, 0, bufferSize);
                    while (retval == bufferSize)
                    {
                        bw.Write(outbyte);
                        bw.Flush();

                        // Reposition the start index to the end of the last buffer and fill the buffer.
                        startIndex += bufferSize;
                        retval = sdr.GetBytes(0, startIndex, outbyte, 0, bufferSize);
                    }

                    bw.Write(outbyte, 0, (int)retval);
                    bw.Flush();

                    bw.Close();
                    fs.Close();
                }

                sdr.Close();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
        Find the presentation correspoding to the given abstract
        Input: abstractId - int with the id of the abstract
        Output: presentation
         */
        public Presentation findPresentationForAbstract(int abstractId)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT P.* FROM Presentations P INNER JOIN AbstractPaper AP ON AP.Id = P.idabstract WHERE AP.id = @idAbstract";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@idAbstract", SqlDbType.Int);
                cmd.Parameters["@idAbstract"].Value = abstractId;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (!sdr.HasRows)
                {
                    throw new RepositoryException("Presentation not found.");
                }
                string presentationRes = sdr[2].ToString();

                Byte[] emptyByteArray = new Byte[64];
                Presentation presentation = new Presentation(sdr[0].ToString(), sdr[1].ToString(), emptyByteArray, sdr[3].ToString(), Int32.Parse(sdr[4].ToString()));

                if (presentationRes != "")
                {
                    presentation.setPresentation((byte[])sdr[2]);

                }
                sdr.Close();
                con.Close();
                return presentation;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }
    }
}
