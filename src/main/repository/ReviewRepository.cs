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
    public class ReviewRepository<ID, T> : IRepository<ID, ReviewerPaper>
    {
        private string connectionString;
        private DataSet ds;
        private SqlDataAdapter da;

        public ReviewRepository(string conStr)
        {
            this.connectionString = conStr;
            this.da = new SqlDataAdapter();
        }

        public void delete(ID id)
        {
            throw new NotImplementedException();
        }

        public List<ReviewerPaper> findAll()
        {
            List<ReviewerPaper> reviewerPapers = new List<ReviewerPaper>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM ReviewerPaper";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    ReviewerPaper reviewerPaper = new ReviewerPaper(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), Convert.ToDateTime(sdr[2].ToString()), Int32.Parse(sdr[3].ToString()), Int32.Parse(sdr[4].ToString()));
                    reviewerPapers.Add(reviewerPaper);

                }

                sdr.Close();
                con.Close();
                return reviewerPapers;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public ReviewerPaper findOne(ID id)
        {
            throw new NotImplementedException();
        }

        public void save(ReviewerPaper entity)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "Insert into ReviewerPaper values(@comment, @date, @id_bid, @id_review)";
                SqlCommand add_reviewer = new SqlCommand(query, con);
                add_reviewer.Parameters.Add("@comment", SqlDbType.NVarChar, 255).Value = entity.Comment;
                add_reviewer.Parameters.Add("@date", SqlDbType.DateTime).Value = entity.ReviewDateTime;
                add_reviewer.Parameters.Add("@id_bid", SqlDbType.Int).Value = entity.Idbid;
                add_reviewer.Parameters.Add("@id_review", SqlDbType.Int).Value = entity.Idreview;

                int result = add_reviewer.ExecuteNonQuery();
                if (result < 0)
                    throw new RepositoryException("Error inserting the new ReviewerPaper into the Database!");
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public void update(ReviewerPaper entity)
        {
            throw new NotImplementedException();
        }
    }
}
