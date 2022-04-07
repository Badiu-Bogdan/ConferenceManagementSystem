using ConferenceManagementSystem.main.repository;
using ConferenceManagementSystem.src.main.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace ConferenceManagementSystem.src.main.repository
{
    public class AbstractPaperRepository<ID, T> : IRepository<ID, AbstractPaper>
    {
        private string connectionString;
        private DataSet ds;
        private SqlDataAdapter da;

        public AbstractPaperRepository(string conStr)
        {
            this.connectionString = conStr;
            this.da = new SqlDataAdapter();
        }

        public AbstractPaper findOne(ID id)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM AbstractPaper WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (!sdr.HasRows)
                {
                    throw new RepositoryException("AbstractPaper not found.");
                }

                AbstractPaper abstractPaper = new AbstractPaper(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString(), Int32.Parse(sdr[7].ToString()), sdr[6].ToString());

                sdr.Close();
                con.Close();
                return abstractPaper;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public AbstractPaper findOne(string name)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM AbstractPaper WHERE name = @name";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar);
                cmd.Parameters["@name"].Value = name;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (!sdr.HasRows)
                {
                    throw new RepositoryException("User not found.");
                }

                AbstractPaper abstractPaper = new AbstractPaper(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString(), Int32.Parse(sdr[7].ToString()), sdr[6].ToString());

                sdr.Close();
                con.Close();
                return abstractPaper;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }


        public List<AbstractPaper> findAll()
        {
            List<AbstractPaper> abstractPapers = new List<AbstractPaper>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM AbstractPaper";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    AbstractPaper abstractPaper = new AbstractPaper(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString(), Int32.Parse(sdr[5].ToString()), sdr[6].ToString());
                    abstractPapers.Add(abstractPaper);
                    
                }

                sdr.Close();
                con.Close();
                return abstractPapers;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public List<AbstractPaper> getAbstractsForBids(int userId)
        {
            List<AbstractPaper> abstractPapers = new List<AbstractPaper>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "select * from AbstractPaper " +
                    "where id in " +
                    "( " +
                    "select distinct idpaper from AuthorsAbstractPaper " +
                    "where idpaper not in " +
                    "(select idpaper from AuthorsAbstractPaper where idauthor = @userId))";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    AbstractPaper abstractPaper = new AbstractPaper(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString(), Int32.Parse(sdr[5].ToString()), sdr[6].ToString());
                    abstractPapers.Add(abstractPaper);

                }

                sdr.Close();
                con.Close();
                return abstractPapers;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public List<AbstractPaper> getAbstractsByConferenceId(int id_conference)
        {
            List<AbstractPaper> abstractPapers = new List<AbstractPaper>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "Select * from AbstractPaper where idconference = @id_conference";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@id_conference", SqlDbType.Int).Value = id_conference;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                while (sdr.Read())
                {
                    AbstractPaper abstractPaper = new AbstractPaper(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString(), Int32.Parse(sdr[5].ToString()), sdr[6].ToString());
                    abstractPapers.Add(abstractPaper);

                }
                sdr.Close();
                con.Close();
                return abstractPapers;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public void save(AbstractPaper entity)
        {

        }

        public void delete(ID id)
        {

        }

        public void update(AbstractPaper entity)
        {

        }

        /*
        Uploads an abstract paper for a conference and a user
        Input: path of the file to be uploaded, name, keywords, topics, metainformations, the id of the conference and the format of the paper (pdf or docx)
        Output: id of the abstract paper
        Throws RepositoryException
        */
        public int uploadAbstractPaper(string name, string abstractPaper, string keywords, string metainfo, int idConf)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();

                // insert the paper
                string query = "INSERT INTO AbstractPaper(name, keywords, metainfo, abstractpaper, idconference) OUTPUT Inserted.id VALUES " +
                    "(@name, @keywords, @metainfo, @abstractpaper, @idconference)";
                SqlCommand addPaper = new SqlCommand(query, con);
                addPaper.Parameters.Add("@name", SqlDbType.NVarChar, 95).Value = name;
                addPaper.Parameters.Add("@keywords", SqlDbType.NVarChar, 95).Value = keywords;
                addPaper.Parameters.Add("@metainfo", SqlDbType.NVarChar, 95).Value = metainfo;
                addPaper.Parameters.Add("@abstractpaper", SqlDbType.NVarChar, 2655).Value = abstractPaper;
                addPaper.Parameters.Add("@idconference", SqlDbType.Int).Value = idConf;
                var idPaper = addPaper.ExecuteScalar();

                return Int32.Parse(idPaper.ToString());

            }
            catch (SqlException e)
            {
                con.Close();
                if (e.Number == 2627)
                {
                    throw new RepositoryException("Name is not available");
                }
                throw new RepositoryException(e.Message);
            }
        }

        public void linkTopicsToAbstractPaper(List<int> topics, int idPaper)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                string query;
                topics.ForEach(idTopic =>
                {
                    // insert the author-paper entry
                    query = "INSERT INTO AbstractPaperTopics VALUES (@idtopic, @idpaper)";
                    SqlCommand linkTopicsPaper = new SqlCommand(query, con);
                    linkTopicsPaper.Parameters.Add("@idtopic", SqlDbType.Int).Value = idTopic;
                    linkTopicsPaper.Parameters.Add("@idpaper", SqlDbType.Int).Value = idPaper;
                    linkTopicsPaper.ExecuteNonQuery();
                });
            }
            catch (SqlException e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }

        }

        public void linkAuthorsToAbstractPaper(List<int> authors, int idPaper)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                string query;
                authors.ForEach(idAuthor =>
                {
                    // insert the author-paper entry
                    query = "INSERT INTO AuthorsAbstractPaper VALUES (@authorid, @paperid)";
                    SqlCommand linkAuthorPaper = new SqlCommand(query, con);
                    linkAuthorPaper.Parameters.Add("@authorid", SqlDbType.Int).Value = idAuthor;
                    linkAuthorPaper.Parameters.Add("@paperid", SqlDbType.Int).Value = idPaper;
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
        Uploads a new abstract paper version for a conference and a user
        Input: path of the file to be uploaded, the name and the format of the abstract paper (pdf or docx)
        Output: -
        Throws RepositoryException
        */
        public void uploadNewAbstractVersion(string name, string newAbstract)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();

                string query = "UPDATE AbstractPaper SET abstractpaper = @abstractpaper WHERE name = @name";
                SqlCommand updatePaper = new SqlCommand(query, con);
                updatePaper.Parameters.Add("@abstractpaper", SqlDbType.NVarChar, 2655).Value = newAbstract;
                updatePaper.Parameters.Add("@name", SqlDbType.NVarChar, 95).Value = name;
                updatePaper.ExecuteNonQuery();

                con.Close();
            }
            catch (SqlException e)
            {
                con.Close();
                if (e.Number == 2627)
                {
                    throw new RepositoryException("Name is not available");
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
        Retrieve all the verdicts
        Input: -
        Output: List of verdicts
         */
        public List<Verdict> getVerdicts()
        {
            List<Verdict> verdicts = new List<Verdict>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM Verdicts";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Verdict verdict = new Verdict(sdr[0].ToString(), sdr[1].ToString());
                    verdicts.Add(verdict);
                }

                sdr.Close();
                con.Close();
                return verdicts;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
        Retrieve a verdict by its id
        Input: id of the verdict to be retrieved
        Output: The foudn verdict
         */
        public Verdict getVerdictById(int id)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM Verdicts WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (!sdr.HasRows)
                {
                    throw new RepositoryException("Verdict not found.");
                }

                Verdict verdict = new Verdict(sdr[0].ToString(), sdr[1].ToString());
                sdr.Close();
                con.Close();
                return verdict;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
        A user bids for a proposal (abstractPaper) with a selectedVerdict
        Input: user - the user who bids
               abstractPaper - the paper that is bid
               selectedVerdict - the verdict selected by the user for the paper
        Output: -
         */
        public void bidProposal(User user, AbstractPaper abstractPaper, Verdict selectedVerdict)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                string query = "INSERT INTO BidProposals VALUES (@reviewerid, @proposalid, @verdictid, GETDATE())";
                SqlCommand bidProposal = new SqlCommand(query, con);
                bidProposal.Parameters.Add("@reviewerid", SqlDbType.Int).Value = user.Id;
                bidProposal.Parameters.Add("@proposalid", SqlDbType.Int).Value = abstractPaper.Id;
                bidProposal.Parameters.Add("@verdictid", SqlDbType.Int).Value = selectedVerdict.getId();
                bidProposal.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }            
        }

        public List<BidProposal> getAllBidProposals()
        {
            List<BidProposal> bidProposals = new List<BidProposal>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM BidProposals";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    BidProposal bidProposal = new BidProposal(Int32.Parse(sdr[0].ToString()), Int32.Parse(sdr[1].ToString()), Int32.Parse(sdr[2].ToString()), Int32.Parse(sdr[3].ToString()));
                    bidProposals.Add(bidProposal);
                }

                sdr.Close();
                con.Close();
                return bidProposals;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public List<BidProposal> getBidProposalsByPaper(string id_paper)
        {
            List<BidProposal> bidProposals = new List<BidProposal>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM BidProposals WHERE idproposal = @proposal_id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@proposal_id", SqlDbType.NVarChar, 1000).Value = id_paper;
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    BidProposal bidProposal = new BidProposal(Int32.Parse(sdr[0].ToString()), Int32.Parse(sdr[1].ToString()), Int32.Parse(sdr[2].ToString()), Int32.Parse(sdr[3].ToString()));
                    bidProposals.Add(bidProposal);
                }

                sdr.Close();
                con.Close();
                return bidProposals;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
        Retrieve all the bid proposals made by a given user
        Input: -
        Output: List of bid proposals
         */
        public List<BidProposal> getBidProposalsByUser(User user)
        {
            List<BidProposal> bidProposals = new List<BidProposal>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM BidProposals WHERE idreviewer = @reviewerid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@reviewerid", SqlDbType.Int).Value = user.Id;
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    BidProposal bidProposal = new BidProposal(Int32.Parse(sdr[0].ToString()), Int32.Parse(sdr[1].ToString()), Int32.Parse(sdr[2].ToString()), Int32.Parse(sdr[3].ToString()));
                    bidProposals.Add(bidProposal);
                }

                sdr.Close();
                con.Close();
                return bidProposals;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
        Get a list of all the topics name related to a given abstract
        Input: idAbstract - int with the id of the abstract
        Output: list of strings
         */
        public List<string> getTopicsForAnAbstract(int idAbstract)
        {
            List<string> topics = new List<string>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "select t.name from Topics t " +
                    "join AbstractPaperTopics apt on t.id = apt.idtopic " +
                    "where apt.idpaper = @idAbstract";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@idAbstract", SqlDbType.Int);
                cmd.Parameters["@idAbstract"].Value = idAbstract;
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    topics.Add(sdr[0].ToString());
                }

                sdr.Close();
                con.Close();
                return topics;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
       Get a list of all the authors name related to a given abstract
       Input: idAbstract - int with the id of the abstract
       Output: list of strings
    */
        public List<string> getAuthorsForAbstract(int idAbstract)
        {
            List<string> authors = new List<string>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "select u.firstname, u.lastname from Users u " +
                    "join AuthorsAbstractPaper aap on u.id = aap.idauthor " +
                    "where aap.idpaper = @idAbstract";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@idAbstract", SqlDbType.Int);
                cmd.Parameters["@idAbstract"].Value = idAbstract;
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    authors.Add(sdr[0].ToString() + " " + sdr[1].ToString());
                }

                sdr.Close();
                con.Close();
                return authors;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
        Get the ids of the authors for a given paper abstract
        Input: idPaper - int with the id of the paper
        Output: list of ids
         */
        public List<int> getAuthorIdsForPaperAbstract(int idPaper)
        {
            List<int> authorIds = new List<int>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT idauthor FROM AuthorsAbstractPaper WHERE idpaper = @paperid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@paperid", SqlDbType.Int);
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
        Check if a given abstract has assigned a paper
        Input: idAbstract - id of the abstract
        Output: true if there exists a paper associated with that abstract, false otherwise
         */
        public bool abstractHasPaper(int idAbstract)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT P.id FROM Papers P INNER JOIN AbstractPaper AP ON P.idabstract = AP.id WHERE AP.id = @abstractid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@abstractid", SqlDbType.Int);
                cmd.Parameters["@abstractid"].Value = idAbstract;
                SqlDataReader sdr = cmd.ExecuteReader();
                bool found = false;
                if (sdr.Read())
                {
                    found = true;
                }
                sdr.Close();
                con.Close();
                return found;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
        Retrieve all the possible reviews
        Input: -
        Output: List of reviews
         */
        public List<Review> getReviews()
        {
            List<Review> reviews = new List<Review>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM Reviews";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Review review = new Review(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), Int32.Parse(sdr[2].ToString()));
                    reviews.Add(review);
                }

                sdr.Close();
                con.Close();
                return reviews;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public AbstractPaper getAbstractForId(int abstractId)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                AbstractPaper abstractPaper = null;
                con.Open();
                String query = "SELECT * FROM AbstractPaper where id=@abstractId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@abstractid", SqlDbType.Int);
                cmd.Parameters["@abstractid"].Value = abstractId;
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                    abstractPaper = new AbstractPaper(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString(), Int32.Parse(sdr[5].ToString()), sdr[6].ToString());
                sdr.Close();
                con.Close();
                return abstractPaper;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public List<int> getTopicsForAbstract(int abstractId)
        {
            List<int> topicIds = new List<int>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT idtopic FROM AbstractPaperTopics WHERE idpaper = @paperId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@paperId", SqlDbType.Int);
                cmd.Parameters["@paperId"].Value = abstractId;
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    topicIds.Add(Int32.Parse(sdr[0].ToString()));
                }

                sdr.Close();
                con.Close();
                return topicIds;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }
        /*
        Check if a given abstract has assigned a presentation
        Input: idAbstract - id of the abstract
        Output: true if there exists a presentation associated with that abstract, false otherwise
         */
        public bool abstractHasPresentation(int idAbstract)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT P.id FROM Presentations P INNER JOIN AbstractPaper AP ON P.idabstract = AP.id WHERE AP.id = @abstractid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@abstractid", SqlDbType.Int);
                cmd.Parameters["@abstractid"].Value = idAbstract;
                SqlDataReader sdr = cmd.ExecuteReader();
                bool found = false;
                if (sdr.Read())
                {
                    found = true;
                }
                sdr.Close();
                con.Close();
                return found;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }
    }
}
