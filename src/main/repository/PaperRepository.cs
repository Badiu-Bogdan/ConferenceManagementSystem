using ConferenceManagementSystem.main.repository;
using ConferenceManagementSystem.src.main.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace ConferenceManagementSystem.src.main.repository
{
    public class PaperRepository<ID, T> : IRepository<ID, Paper>
    {
        private string connectionString;
        private DataSet ds;
        private SqlDataAdapter da;

        public PaperRepository(string conStr)
        {
            this.connectionString = conStr;
            this.da = new SqlDataAdapter();
        }

        public Paper findOne(ID id)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM Papers WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@id", SqlDbType.NVarChar);
                cmd.Parameters["@id"].Value = id;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (!sdr.HasRows)
                {
                    throw new RepositoryException("Paper not found.");
                }
                string paperRes = sdr[2].ToString();

                Byte[] emptyByteArray = new Byte[64];
                Paper paper = new Paper(sdr[0].ToString(), sdr[1].ToString(), emptyByteArray, sdr[3].ToString(), Int32.Parse(sdr[4].ToString()));

                if (paperRes != "")
                {
                    paper.setPaper((byte[])sdr[2]);
                    
                }
                sdr.Close();
                con.Close();
                return paper;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public Paper findOne(string title)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM Papers WHERE title = @title";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@title", SqlDbType.NVarChar);
                cmd.Parameters["@title"].Value = title;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (!sdr.HasRows)
                {
                    throw new RepositoryException("Paper not found.");
                }
                string paperRes = sdr[2].ToString();

                Byte[] emptyByteArray = new Byte[64];
                Paper paper = new Paper(sdr[0].ToString(), sdr[1].ToString(), emptyByteArray, sdr[3].ToString(), Int32.Parse(sdr[4].ToString()));

                if (paperRes != "")
                {
                    paper.setPaper((byte[])sdr[2]);

                }
                sdr.Close();
                con.Close();
                return paper;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }


        public List<Paper> findAll()
        {
            List<Paper> papers = new List<Paper>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM Papers";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                
                while (sdr.Read())
                {
                    string paperRes = sdr[2].ToString();
                    if (paperRes != "")
                    {
                        Paper paper = new Paper(sdr[0].ToString(), sdr[1].ToString(), (byte[])sdr[2], sdr[3].ToString(), Int32.Parse(sdr[4].ToString()));
                        papers.Add(paper);
                    }
                    else
                    {
                        Byte[] emptyByteArray = new Byte[64];
                        Paper paper = new Paper(sdr[0].ToString(), sdr[1].ToString(), emptyByteArray, sdr[3].ToString(), Int32.Parse(sdr[4].ToString()));
                        papers.Add(paper);
                    }                    
                }

                sdr.Close();
                con.Close();
                return papers;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public void save(Paper entity)
        {
            
        }

        public void delete(ID id)
        {

        }

        public void update(Paper entity)
        {

        }

        /*
        Uploads a full paper for a conference and a user
        Input: path of the file to be uploaded, the user, the id of the conference and the format of the paper (pdf or docx)
        Output: id of the paper
        Throws RepositoryException
        References: https://docs.microsoft.com/en-us/sql/relational-databases/blob/create-client-applications-for-filestream-data?view=sql-server-ver15
        https://www.akadia.com/services/dotnet_read_write_blob.html this one actually worked for storing an image/paper/file anyway
         */
        public string uploadFullPaper(string path, string title, User user, int idAbstract, string fileFormat)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();

                byte[] paper = getResource(path);

                // insert the paper
                string query = "INSERT INTO Papers(id, title, paper, format, idabstract) OUTPUT Inserted.id VALUES (NEWID(), @title, @paper, @format, @abstractid)";
                SqlCommand addPaper = new SqlCommand(query, con);
                addPaper.Parameters.Add("@title", SqlDbType.NVarChar, 95).Value = title;
                addPaper.Parameters.Add("@paper", SqlDbType.Image, paper.Length).Value = paper;
                addPaper.Parameters.Add("@format", SqlDbType.NVarChar, 10).Value = fileFormat;
                addPaper.Parameters.Add("@abstractid", SqlDbType.Int).Value = idAbstract;
                var idPaper = addPaper.ExecuteScalar();

                return ((Guid)idPaper).ToString();

            }
            catch (SqlException e)
            {
                con.Close();
                if(e.Number == 2627)
                {
                    throw new RepositoryException("Title is not available");
                }
                throw new RepositoryException(e.Message);
            }
        }

        public void linkAuthorsToPaper(List<int> authors, string idPaper)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                string query;
                authors.ForEach(idAuthor =>
                {
                // insert the author-paper entry
                    query = "INSERT INTO AuthorsPapers VALUES (@authorid, @paperid)";
                    SqlCommand linkAuthorPaper = new SqlCommand(query, con);
                    linkAuthorPaper.Parameters.Add("@authorid", SqlDbType.Int).Value = idAuthor;
                    linkAuthorPaper.Parameters.Add("@paperid", SqlDbType.NVarChar, 1000).Value = idPaper;
                    linkAuthorPaper.ExecuteNonQuery();
                });
            }
            catch (SqlException e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }

        }

        /*
        Uploads a new paper version for a conference and a user
        Input: path of the file to be uploaded, the user, the id of the conference and the format of the paper (pdf or docx)
        Output: -
        Throws RepositoryException
        */
        public void uploadNewPaperVersion(string path, string idPaper, int idAbstract, string fileFormat)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();

                byte[] paper = getResource(path);

                string query = "UPDATE Papers SET paper = @paper, format = @format WHERE id = @id AND idabstract = @idabstract";
                SqlCommand updatePaper = new SqlCommand(query, con);
                updatePaper.Parameters.Add("@paper", SqlDbType.Image, paper.Length).Value = paper;
                updatePaper.Parameters.Add("@format", SqlDbType.NVarChar, 10).Value = fileFormat;
                updatePaper.Parameters.Add("@id", SqlDbType.NVarChar, 1000).Value = idPaper;
                updatePaper.Parameters.Add("@idabstract", SqlDbType.Int).Value = idAbstract;
                updatePaper.ExecuteNonQuery();

                con.Close();
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
        Read a resource from the user's local machine
        Input: path of the resource
        Output: byte array containing the bytes of that resource
         */
        private byte[] getResource(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            byte[] paper = br.ReadBytes((int)fs.Length);

            br.Close();
            fs.Close();

            return paper;
        }

        /*
        Download a paper from the db to the local filesystem
        Input: paper to be downloaded
        Output: -
         */
        public void savePaperToFilesystem(Paper paper, string path)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                // Read the paper bytes directly from the db
                con.Open();
                String query = "SELECT Paper FROM Papers WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@id", SqlDbType.NVarChar);
                cmd.Parameters["@id"].Value = paper.getId();
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.SequentialAccess);
                if (!sdr.HasRows)
                {
                    throw new RepositoryException("No papers in database.");
                }
                while (sdr.Read())
                {
                    FileStream fs = new FileStream(path + "\\" + paper.getTitle() + paper.getFormat(), FileMode.OpenOrCreate, FileAccess.Write);
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
        Get the ids of the authors for a given paper
        Input: idPaper - string with the id of the paper
        Output: list of ids
         */
        public List<int> getAuthorIdsForPaper(string idPaper)
        {
            List<int> authorIds = new List<int>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT idauthor FROM AuthorsPapers WHERE idpaper = @paperid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@paperid", SqlDbType.NVarChar);
                cmd.Parameters["@paperid"].Value = idPaper;
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    authorIds.Add(Int32.Parse(sdr[0].ToString()));
                }

                sdr.Close();
                con.Close();
                return authorIds;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }


        /*
        Change the current acceptance of the given abstract paper
        Input: idAbstract - int with the id of the abstract
        Output: -
         */
        public void changeAcceptance(int idAbstract)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "update AbstractPaper set isAccepted = 1 where id = " +
                    "(select id from " +
                    "(select ap.* from AbstractPaper ap join " +
                    "(select ap.id as d from AbstractPaper ap join BidProposals bp on bp.idproposal = ap.id " +
                    "join ReviewerPaper rp on rp.idbid = bp.id " +
                    "join Reviews r on rp.idreview = r.id " +
                    "group by ap.id " +
                    "having sum(r.points) > 0) AS d on ap.id = d.d) AS result " +
                    "where result.id = @idAbstract)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@idAbstract", SqlDbType.Int);
                cmd.Parameters["@idAbstract"].Value = idAbstract;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Close();
                con.Close();

                con.Open();
                query = "update AbstractPaper set isAccepted = NULL where id = " +
                    "(select id from " +
                    "(select ap.* from AbstractPaper ap join " +
                    "(select ap.id as d from AbstractPaper ap join BidProposals bp on bp.idproposal = ap.id " +
                    "join ReviewerPaper rp on rp.idbid = bp.id " +
                    "join Reviews r on rp.idreview = r.id " +
                    "group by ap.id " +
                    "having sum(r.points) = 0) AS d on ap.id = d.d) AS result " +
                    "where result.id = @idAbstract)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@idAbstract", SqlDbType.Int);
                cmd.Parameters["@idAbstract"].Value = idAbstract;
                sdr = cmd.ExecuteReader();
                sdr.Close();
                con.Close();


                con.Open();
                query = "update AbstractPaper set isAccepted = 0 where id = " +
                    "(select id from " +
                    "(select ap.* from AbstractPaper ap join " +
                    "(select ap.id as d from AbstractPaper ap join BidProposals bp on bp.idproposal = ap.id " +
                    "join ReviewerPaper rp on rp.idbid = bp.id " +
                    "join Reviews r on rp.idreview = r.id " +
                    "group by ap.id " +
                    "having sum(r.points) < 0) AS d on ap.id = d.d) AS result " +
                    "where result.id = @idAbstract)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@idAbstract", SqlDbType.Int);
                cmd.Parameters["@idAbstract"].Value = idAbstract;
                sdr = cmd.ExecuteReader();
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
        Find the paper correspoding to the given abstract
        Input: abstractId - int with the id of the abstract
        Output: paper
         */
        public Paper findPaperForAbstract(int abstractId)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT P.* FROM Papers P INNER JOIN AbstractPaper AP ON AP.Id = P.idabstract WHERE AP.id = @idAbstract";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@idAbstract", SqlDbType.Int);
                cmd.Parameters["@idAbstract"].Value = abstractId;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (!sdr.HasRows)
                {
                    throw new RepositoryException("Paper not found.");
                }
                string paperRes = sdr[2].ToString();

                Byte[] emptyByteArray = new Byte[64];
                Paper paper = new Paper(sdr[0].ToString(), sdr[1].ToString(), emptyByteArray, sdr[3].ToString(), Int32.Parse(sdr[4].ToString()));

                if (paperRes != "")
                {
                    paper.setPaper((byte[])sdr[2]);

                }
                sdr.Close();
                con.Close();
                return paper;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
         Get the papers that the given user has to review
         Input: reviewerId - int with the user id
         Output: list of papers
          */
        public List<Paper> getPapersforReviewer(int reviewerId)
        {
            List<Paper> papers = new List<Paper>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "select paper.* from Papers paper join BidProposals bp on bp.idproposal = paper.idabstract join ReviewerPaper rp on rp.idbid = bp.id where bp.idreviewer = @reviewerId and rp.idreview = 1";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@reviewerId", SqlDbType.Int);
                cmd.Parameters["@reviewerId"].Value = reviewerId;
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string paperRes = sdr[2].ToString();
                    if (paperRes != "")
                    {
                        Paper paper = new Paper(sdr[0].ToString(), sdr[1].ToString(), (byte[])sdr[2], sdr[3].ToString(), Int32.Parse(sdr[4].ToString()));
                        papers.Add(paper);
                    }
                    else
                    {
                        Byte[] emptyByteArray = new Byte[64];
                        Paper paper = new Paper(sdr[0].ToString(), sdr[1].ToString(), emptyByteArray, sdr[3].ToString(), Int32.Parse(sdr[4].ToString()));
                        papers.Add(paper);
                    }
                }

                sdr.Close();
                con.Close();
                return papers;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
         Get the papers that the given reviewer has been requested to discuss about
         Input: reviewerId - int with the user id
         Output: list of papers
          */
        public List<Paper> getPapersforReviewerDiscussion(int reviewerId)
        {
            List<Paper> papers = new List<Paper>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "select paper.* from Papers paper " +
                    "join AbstractPaper ap on paper.idabstract = ap.id " +
                    "join BidProposals bp on bp.idproposal = ap.id " +
                    "join ReviewerPaper rp on rp.idbid = bp.id " +
                    "join Revaluation r on r.idReviwerPaper = rp.id " +
                    "where bp.idreviewer = @reviewerId ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@reviewerId", SqlDbType.Int);
                cmd.Parameters["@reviewerId"].Value = reviewerId;
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string paperRes = sdr[2].ToString();
                    if (paperRes != "")
                    {
                        Paper paper = new Paper(sdr[0].ToString(), sdr[1].ToString(), (byte[])sdr[2], sdr[3].ToString(), Int32.Parse(sdr[4].ToString()));
                        papers.Add(paper);
                    }
                    else
                    {
                        Byte[] emptyByteArray = new Byte[64];
                        Paper paper = new Paper(sdr[0].ToString(), sdr[1].ToString(), emptyByteArray, sdr[3].ToString(), Int32.Parse(sdr[4].ToString()));
                        papers.Add(paper);
                    }
                }

                sdr.Close();
                con.Close();
                return papers;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
         Update the database with the comment and review given by the reviewer to the specific paper
         Input: comment - string with the comment of the user, reviewId - int with the id of the reviewer and paperTitle - string with name of the paper that is reviewed
         Output: -
          */
        public void updateReviewPaper(string comment, int reviewId, string paperTitle)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();

                string query = "update ReviewerPaper set comment = @comment, idreview = @reviewId where id = " +
                    "(select rp.id from ReviewerPaper rp " +
                    "join BidProposals bp on rp.idbid = bp.id " +
                    "join AbstractPaper ap on bp.idproposal = ap.id " +
                    "join Papers p on p.idabstract = ap.id " +
                    "where p.title = @paperTitle)";
                SqlCommand updatePaper = new SqlCommand(query, con);
                updatePaper.Parameters.Add("@comment", SqlDbType.NVarChar, 255).Value = comment;
                updatePaper.Parameters.Add("@paperTitle", SqlDbType.NVarChar, 95).Value = paperTitle;
                updatePaper.Parameters.Add("@reviewId", SqlDbType.Int).Value = reviewId;
                updatePaper.ExecuteNonQuery();

                con.Close();
            }
            catch (SqlException e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }


        /*
         Mark in the database the given abstract paper as accepted
         Input: idAbstract - int with the id of the abstract papers
         Output: -
          */
        public void acceptProposal(int idAbstract)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "UPDATE AbstractPaper " +
                    "SET isAccepted = 1 " +
                    "WHERE id = @idAbstract; ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@idAbstract", SqlDbType.NVarChar);
                cmd.Parameters["@idAbstract"].Value = idAbstract;
                SqlDataReader sdr = cmd.ExecuteReader();

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
         Mark in the database the given abstract paper as rejected
         Input: idAbstract - int with the id of the abstract papers
         Output: -
          */
        public void rejectProposal(int idAbstract)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "UPDATE AbstractPaper " +
                    "SET isAccepted = 0 " +
                    "WHERE id = @idAbstract; ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@idAbstract", SqlDbType.NVarChar);
                cmd.Parameters["@idAbstract"].Value = idAbstract;
                SqlDataReader sdr = cmd.ExecuteReader();

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
         Get the papers that are in contradictory (having sum of the points = 0)
         Input: -
         Output: list of papers
          */
        public List<Paper> getPapersInContradictory()
        {
            List<Paper> papers = new List<Paper>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "select p.* from Papers p " +
                    "join AbstractPaper ap on ap.id = p.idabstract join " +
                    "(select ap.id as d from AbstractPaper ap " +
                    "join BidProposals bp on bp.idproposal = ap.id " +
                    "join ReviewerPaper rp on rp.idbid = bp.id " +
                    "join Reviews r on rp.idreview = r.id " +
                    "group by ap.id " +
                    "having sum(r.points) = 0) AS d on ap.id = d.d";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    string paperRes = sdr[2].ToString();
                    if (paperRes != "")
                    {
                        Paper paper = new Paper(sdr[0].ToString(), sdr[1].ToString(), (byte[])sdr[2], sdr[3].ToString(), Int32.Parse(sdr[4].ToString()));
                        papers.Add(paper);
                    }
                    else
                    {
                        Byte[] emptyByteArray = new Byte[64];
                        Paper paper = new Paper(sdr[0].ToString(), sdr[1].ToString(), emptyByteArray, sdr[3].ToString(), Int32.Parse(sdr[4].ToString()));
                        papers.Add(paper);
                    }
                }

                sdr.Close();
                con.Close();
                return papers;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

    }
}
