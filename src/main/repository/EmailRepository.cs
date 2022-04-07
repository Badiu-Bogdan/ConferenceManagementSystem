using ConferenceManagementSystem.main.repository;
using ConferenceManagementSystem.src.main.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagementSystem.src.main.repository
{
    public class EmailRepository<ID, T> : IRepository<ID, Email>
    {
        private string connectionString;
        private DataSet ds;
        private SqlDataAdapter da;
        public EmailRepository(string conStr)
        {
            this.connectionString = conStr;
            this.da = new SqlDataAdapter();
        }

        public List<Email> findAll()
        {
            List<Email> emails = new List<Email>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM Emails";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Email email = new Email(sdr[0].ToString(), Int32.Parse(sdr[1].ToString()), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString());
                    emails.Add(email);

                }

                sdr.Close();
                con.Close();
                return emails;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public Email findOne(ID id)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM Emails WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@id", SqlDbType.NVarChar);
                cmd.Parameters["@id"].Value = id;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (!sdr.HasRows)
                {
                    throw new RepositoryException("Email not found.");
                }

                Email email = new Email(sdr[0].ToString(), Int32.Parse(sdr[1].ToString()), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString());

                sdr.Close();
                con.Close();
                return email;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public void save(Email entity)
        {
            
        }

        public void update(Email entity)
        {
           
        }
        public void delete(ID id)
        {

        }

        public string sendEmail(int idUser, string consignee, string subject, string message)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                // insert the email
                string query = "INSERT INTO Emails(idUser, consignee, subject, message) OUTPUT Inserted.id VALUES " +
                    "(@idUser, @consignee, @subject, @message)";
                SqlCommand send = new SqlCommand(query, con);
                send.Parameters.Add("@idUser", SqlDbType.Int).Value = idUser;
                send.Parameters.Add("@consignee", SqlDbType.NVarChar, 95).Value = consignee;
                send.Parameters.Add("@subject", SqlDbType.NVarChar, 95).Value = subject;
                send.Parameters.Add("@message", SqlDbType.NVarChar, 95).Value = message;
                var idEmail = send.ExecuteScalar();

                return (idEmail).ToString();
            }
            catch (SqlException e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }
    }
}
