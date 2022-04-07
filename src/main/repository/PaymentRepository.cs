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
    public class PaymentRepository<ID, T> : IRepository<ID, Payment>
    {
        private string connectionString;
        private DataSet ds;
        private SqlDataAdapter da;

        public PaymentRepository(string conStr)
        {
            this.connectionString = conStr;
            this.da = new SqlDataAdapter();
        }

        public List<Payment> findAll()
        {
            List<Payment> payments = new List<Payment>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM Payments";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Payment payment = new Payment(sdr[0].ToString(), Int32.Parse(sdr[1].ToString()), Int32.Parse(sdr[2].ToString()), sdr[3].ToString(), Int32.Parse(sdr[4].ToString()), sdr[5].ToString(), DateTime.Parse(sdr[6].ToString()));
                    payments.Add(payment);

                }

                sdr.Close();
                con.Close();
                return payments;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public Payment findOne(ID id)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM Payments WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@id", SqlDbType.NVarChar);
                cmd.Parameters["@id"].Value = id;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (!sdr.HasRows)
                {
                    throw new RepositoryException("Payment not found.");
                }

                Payment payment = new Payment(sdr[0].ToString(), Int32.Parse(sdr[1].ToString()), Int32.Parse(sdr[2].ToString()), sdr[3].ToString(), Int32.Parse(sdr[4].ToString()), sdr[5].ToString(), DateTime.Parse(sdr[6].ToString()));

                sdr.Close();
                con.Close();
                return payment;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public void save(Payment entity)
        {

        }
        public void delete(ID id)
        {

        }

        public void update(Payment entity)
        {

        }

        /*
         * Pays the registration fee for a conference
         * Input: idUser, idConference
         * Output: the id of the paid fee
         * Throws: RepositoryException
         */
        public string payRegistrationFee(int idusername, int idconference, string cardnumber, int cvv, string cardholder, DateTime expirationdate)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {

                if(this.userPaidConference(idusername, idconference))
                {
                    throw new RepositoryException("Fee already paid!");
                }

                con.Open();
                // insert the payment
                string query = "INSERT INTO Payments(idusername, idconference, cardnumber, cvv, cardholder, expirationdate) OUTPUT Inserted.id VALUES " +
                    "(@idusername, @idconference, @cardnumber, @cvv, @cardholder, @expirationdate)";
                SqlCommand payFee = new SqlCommand(query, con);
                payFee.Parameters.Add("@idusername", SqlDbType.Int).Value = idusername;
                payFee.Parameters.Add("@idconference", SqlDbType.Int).Value = idconference;
                payFee.Parameters.Add("@cardnumber", SqlDbType.NVarChar, 95).Value = cardnumber;
                payFee.Parameters.Add("@cvv", SqlDbType.Int).Value = cvv;
                payFee.Parameters.Add("@cardholder", SqlDbType.NVarChar, 95).Value = cardholder;
                payFee.Parameters.Add("@expirationdate", SqlDbType.DateTime).Value = expirationdate;
                var idFee = payFee.ExecuteScalar();

                return (idFee).ToString();

            }
            catch (SqlException e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
         * Check if user has paid the entrance fee for a conference
         * Input: idUser, idConference
         * Output: true if the user paid, false otherwise
         * Throws: RepositoryException
         */
        public bool userPaidConference(int idUser, int idConference)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();

                string select = "SELECT COUNT(1) FROM Payments WHERE idusername = @idusername AND idconference = @idconference";
                SqlCommand selectPaper = new SqlCommand(select, con);
                selectPaper.Parameters.Add("@idusername", SqlDbType.Int).Value = idUser;
                selectPaper.Parameters.Add("@idconference", SqlDbType.Int).Value = idConference;
                int count = Int32.Parse(selectPaper.ExecuteScalar().ToString());
                if (count > 0)
                {
                    con.Close();
                    return true;
                }
                return false;
            }
            catch (SqlException e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }
    }
}
