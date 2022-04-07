using ConferenceManagementSystem.main.repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ConferenceManagementSystem.src.main.domain;


namespace ConferenceManagementSystem.src.main.repository
{
    public class UserRepository<ID, T> : IRepository<ID, User>
    {
        private string connectionString;
        private DataSet ds;
        private SqlDataAdapter da;

        public UserRepository(string conStr)
        {
            this.connectionString = conStr;
            this.da = new SqlDataAdapter();
        }

        public User findOne(ID id)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM Users WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (!sdr.HasRows)
                {
                    throw new RepositoryException("User not found.");
                }
                User user = new User(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString(), sdr[5].ToString(), DateTime.Parse(sdr[6].ToString()), sdr[7].ToString(), sdr[8].ToString(), sdr[9].ToString());
                sdr.Close();
                con.Close();
                return user;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public User findOne(String useremail, String password)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM Users WHERE password = @pass AND (email = @email OR username = @user)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@pass", SqlDbType.VarChar);
                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters.Add("@user", SqlDbType.VarChar);
                cmd.Parameters["@pass"].Value = password;
                cmd.Parameters["@email"].Value = useremail;
                cmd.Parameters["@user"].Value = useremail;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (!sdr.HasRows)
                {
                    throw new RepositoryException("User not found.");
                }
                User user = new User(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString(), sdr[5].ToString(), DateTime.Parse(sdr[6].ToString()), sdr[7].ToString(), sdr[8].ToString(), sdr[9].ToString());
                sdr.Close();
                con.Close();
                return user;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }


        public List<User> findAll()
        {
            List<User> users = new List<User>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM Users";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (!sdr.HasRows)
                {
                    throw new RepositoryException("No users in database.");
                }
                while (sdr.Read())
                {
                    int id = Int32.Parse(sdr[0].ToString());
                    User user = new User(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString(), 
                        sdr[3].ToString(), sdr[4].ToString(), sdr[5].ToString(), DateTime.Parse(sdr[6].ToString()),
                        sdr[7].ToString(), sdr[8].ToString(), sdr[9].ToString());

                    users.Add(user);
                }
                
                sdr.Close();
                con.Close();
                return users;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public void save(User entity)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "INSERT INTO Users(firstname, lastname, email, username, password, dob, address, affiliation, website) VALUES " +
                    "(@firstname, @lastname, @email, @username, @password, @dob, @address, @affiliation, @website)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@firstname", SqlDbType.VarChar);
                cmd.Parameters.Add("@lastname", SqlDbType.VarChar);
                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters.Add("@username", SqlDbType.VarChar);
                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters.Add("@dob", SqlDbType.Date);
                cmd.Parameters.Add("@address", SqlDbType.VarChar);
                cmd.Parameters.Add("@affiliation", SqlDbType.VarChar);
                cmd.Parameters.Add("@website", SqlDbType.VarChar);


                cmd.Parameters["@id"].Value = entity.Id;
                cmd.Parameters["@firstname"].Value = entity.FirstName;
                cmd.Parameters["@lastname"].Value = entity.LastName;
                cmd.Parameters["@email"].Value = entity.Email;
                cmd.Parameters["@username"].Value = entity.Username;
                cmd.Parameters["@password"].Value = entity.Password;
                cmd.Parameters["@dob"].Value = entity.Dob;
                cmd.Parameters["@address"].Value = entity.Address;
                cmd.Parameters["@affiliation"].Value = entity.Affiliation;
                cmd.Parameters["@website"].Value = entity.Website;

                int result = cmd.ExecuteNonQuery();
                if (result < 0)
                    throw new RepositoryException("Error inserting the new User into the Database!");
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public void delete(ID id)
        {

        }

        public void update(User entity)
        {

        }

        /*
         Retrieve all the types of users from the TypeOfUsers table
        Input: -
        Output: list of user types
        Throws RepositoryException
         */
        public List<UserType> getUserTypes()
        {
            List<UserType> userTypes = new List<UserType>();

            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM TypeOfUsers";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    UserType userType = new UserType(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString());
                    userTypes.Add(userType);
                }
                sdr.Close();
                con.Close();
                return userTypes;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
         Retrieve the types of users available at the registration screen
        Input: -
        Output: list of user types: Admin, Steering Committee Member
        Throws RepositoryException
         */
        public List<UserType> getRegistrationUserTypes()
        {
            List<UserType> userTypes = new List<UserType>();

            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM TypeOfUsers WHERE name IN ('Admin', 'Steering Committee Member')";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    UserType userType = new UserType(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString());
                    userTypes.Add(userType);
                }
                sdr.Close();
                con.Close();
                return userTypes;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
         Create an entry in the UsersTypeOfUsers table by linking an user and its type
        Input: user and userType
        Output: -
        Throws RepositoryException
         */
        public void setUserType(User user, UserType userType)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "INSERT INTO UsersTypeOfUsers (iduser, idtype) VALUES (@iduser, @idtype)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@iduser", SqlDbType.Int);
                cmd.Parameters.Add("@idtype", SqlDbType.Int);


                cmd.Parameters["@iduser"].Value = user.Id;
                cmd.Parameters["@idtype"].Value = userType.getId();
                
                int result = cmd.ExecuteNonQuery();
                if (result < 0)
                    throw new RepositoryException("Error inserting a new entry into the Database regarding the relationship" +
                        "between a user and a type!");
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
         Receives a user without an id. Based on its characteristics,
         the id of the user is found and set correspondingly
        Input: User without id
        Output: User with id
        Throws RepositoryException
         */
        public User getUserWithoutId(User user)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT id FROM Users WHERE password = @pass AND email = @email AND username = @user";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@pass", SqlDbType.VarChar);
                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters.Add("@user", SqlDbType.VarChar);
                cmd.Parameters["@pass"].Value = user.Password;
                cmd.Parameters["@email"].Value = user.Email;
                cmd.Parameters["@user"].Value = user.Username;
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    user.Id = Int32.Parse(sdr[0].ToString());
                }
                sdr.Close();
                con.Close();
                return user;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
         Retrieves the user type from the TypeOfUsers table by name
        Input: name of the user type to be retrieved
        Output: The corresponding user type
        Throws RepositoryException
         */
        public UserType getUserTypeByName(string name)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM TypeOfUsers WHERE name = @name";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = name;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (!sdr.HasRows)
                {
                    throw new RepositoryException("User type not found by name " + name + ".");
                }
                UserType userType = new UserType(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString());
                sdr.Close();
                con.Close();
                return userType;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
         Retrieves the user type from the TypeOfUsers table by name
        Input: name of the user type to be retrieved
        Output: The corresponding user type
        Throws RepositoryException
         */
        public List<UserType> getUserTypesForUser(User user)
        {
            List<UserType> userTypes = new List<UserType>();

            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT tou.id, tou.name, tou.description FROM TypeOfUsers tou INNER JOIN UsersTypeOfUsers utou" +
                    " ON tou.id = utou.idtype WHERE utou.iduser = @iduser";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@iduser", SqlDbType.Int);
                cmd.Parameters["@iduser"].Value = user.Id;
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    UserType userType = new UserType(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString());
                    userTypes.Add(userType);
                }
                sdr.Close();
                con.Close();
                return userTypes;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }


        /*
        Change the date for the end of the Conference
        Input: id of the conference to be changed, newDate for the endDateCFP
        Output: -
        Throws RepositoryException
         */
        public void postponeConference(int idConference, string type, DateTime newDate)
        { 

            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "UPDATE Conferences SET endDateCFPPaper = @newDate WHERE id = @id";
                if(type == "Proposal")
                {
                    query = "UPDATE Conferences SET endDateCFPProposal = @newDate WHERE id = @id";
                }
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@newDate", SqlDbType.DateTime);
                cmd.Parameters.Add("@id", SqlDbType.Int);


                cmd.Parameters["@newDate"].Value = newDate;
                cmd.Parameters["@id"].Value = idConference;

                cmd.ExecuteNonQuery();
                
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
         * Returns a list of pairs (Cid, Usid)=(conference_id, user_id) with all users that are going to the conference
         * Input: conference_id
         * Output: A list of pairs with users and conferences
         * Throws: RepositoryException
         */
        public List<(int Cid, int Usid)> getChairUsers(int conference_id)
        {
            List<(int Cid, int Usid)> chairUsers = new List<(int, int)>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                string query = "Select * from ChairsUsers where Cid = @conference_id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@conference_id", SqlDbType.Int).Value = conference_id;
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    int Cid = Int32.Parse(sdr[0].ToString());
                    int Usid = Int32.Parse(sdr[1].ToString());
                    chairUsers.Add((Cid, Usid));
                }
                sdr.Close();
                con.Close();
                return chairUsers;
            }
            catch(Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public void add_chair(int Cid, int Usid)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                try
                {
                    string query = "INSERT INTO ChairsUsers values(@cid, @usid)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@cid", SqlDbType.Int).Value = Cid;
                    cmd.Parameters.Add("@usid", SqlDbType.Int).Value = Usid;
                    cmd.ExecuteNonQuery();
                }
                catch(Exception error)
                {

                }
            }
            catch(Exception e)
            {
                throw new RepositoryException(e.Message);
            }
        }

        public void remove_chair(int Cid, int Usid)
        {
            SqlConnection con = new SqlConnection(this.connectionString);

            try
            {
                con.Open();
                string query = "Delete from ChairsUsers where Cid = @cid AND Usid = @usid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@cid", SqlDbType.Int).Value = Cid;
                cmd.Parameters.Add("@usid", SqlDbType.Int).Value = Usid;
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw new RepositoryException(e.Message);
                
            }
        }

        /*
         * Insert into the database the necessary data in order to use the chat functionality
         * Input: paperName - name of the paper being discussed
         * Output: -
         * Throws: RepositoryException
         */
        public void createChat(string paperName)
        {
            List<int> reviewerPaperIds = new List<int>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                string query = "select rp.id from ReviewerPaper rp " +
                    "join BidProposals bp on rp.idbid = bp.id " +
                    "join Papers p on p.idabstract = bp.idproposal " +
                    "where p.title = @paperName";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@paperName", SqlDbType.VarChar).Value = paperName;
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    reviewerPaperIds.Add(Int32.Parse(sdr[0].ToString()));
                }
                sdr.Close();

                query = "Insert into chat values ('')";
                SqlCommand cmd2 = new SqlCommand(query, con);
                cmd2.ExecuteNonQuery();



                reviewerPaperIds.ForEach(reviewerPaperId =>
                {
                    query = "insert into Revaluation values(@reviewPaperId,(SELECT id FROM Chat WHERE id = (SELECT MAX(id) FROM Chat)),-1)";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@reviewPaperId", SqlDbType.Int).Value = reviewerPaperId;
                    sdr = cmd.ExecuteReader();
                    sdr.Close();
                });

                con.Close();

            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
         * List of all users that are requested to discuss
         * Input: -
         * Output: list of users
         * Throws: RepositoryException
         */
        public List<User> requestedToDiscuss()
        {
            List<User> usersRequestedToDiscuss = new List<User>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                string query = "select users.* from Users users join BidProposals bp on bp.idreviewer = users.id " +
                    "join ReviewerPaper rp on rp.idbid = bp.id " +
                    "join Revaluation r on r.idReviwerPaper = rp.id";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    usersRequestedToDiscuss.Add(new User(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString(),
                        sdr[3].ToString(), sdr[4].ToString(), sdr[5].ToString(), DateTime.Parse(sdr[6].ToString()),
                        sdr[7].ToString(), sdr[8].ToString(), sdr[9].ToString()));
                }
                sdr.Close();
                con.Close();
                return usersRequestedToDiscuss;

            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }


        /*
         * Get the comments of all reviewers acording to the given paper title
         * Input: paperTitle - name of the paper being discussed
         * Output: string of comments
         * Throws: RepositoryException
         */
        public string getCommentsForChat(string paperTitle) 
        {
            string comments = "";
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                string query = "select distinct chat.comments from Chat chat " +
                    "join Revaluation re on re.idchat = chat.id " +
                    "join ReviewerPaper rp on re.idReviwerPaper = rp.id " +
                    "join BidProposals bp on rp.idbid = bp.id " +
                    "join Papers p on bp.idproposal = p.idabstract " +
                    "where p.title = @paperTitle ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@paperTitle", SqlDbType.VarChar).Value = paperTitle;
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    comments = sdr[0].ToString();
                }
                sdr.Close();
                con.Close();
                return comments;

            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
         * Update the decission of the reviewer
         * Input: the verdict: 1 for accepted, 0 for rejected, the paperTitle that is being discussed about and the user who is the reviewer
         * Output: -
         * Throws: RepositoryException
         */
        public void updateVerdictAfterDiscussion(int verdict, string paperTitle, User user)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                string query2 = "update Revaluation set finalVerdict = @verdict " +
                    "where id = " +
                    "(select revaluation.id from Revaluation revaluation " +
                    "join ReviewerPaper rp on revaluation.idReviwerPaper = rp.id " +
                    "join BidProposals bp on bp.id = rp.idbid " +
                    "join Papers p on bp.idproposal = p.idabstract " +
                    "join Users u on bp.idreviewer = u.id " +
                    "where p.title =  @paperTitle and u.id = @idUser)";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.Parameters.Add("@paperTitle", SqlDbType.VarChar).Value = paperTitle;
                cmd2.Parameters.Add("@idUser", SqlDbType.Int).Value = user.Id;
                cmd2.Parameters.Add("@verdict", SqlDbType.Int).Value = verdict;
                cmd2.ExecuteReader();


                con.Close();

            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public void updateChat(string comments, string paperTitle, User user)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();


                string query = "select distinct chat.comments from Chat chat " +
                    "join Revaluation re on re.idchat = chat.id " +
                    "join ReviewerPaper rp on re.idReviwerPaper = rp.id " +
                    "join BidProposals bp on rp.idbid = bp.id " +
                    "join Papers p on bp.idproposal = p.idabstract " +
                    "where p.title = @paperTitle ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@paperTitle", SqlDbType.VarChar).Value = paperTitle;
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    comments = sdr[0].ToString() + user.FirstName + ' ' + user.LastName + ": " + comments + System.Environment.NewLine;
                }
                sdr.Close();

                /////////////////////////////////////////////////////////////////////////

                query = "update chat set comments = @comments where id =  " +
                    "(select distinct chat.id from Chat chat " +
                    "join Revaluation re on re.idchat = chat.id " +
                    "join ReviewerPaper rp on re.idReviwerPaper = rp.id " +
                    "join BidProposals bp on rp.idbid = bp.id " +
                    "join Papers p on bp.idproposal = p.idabstract " +
                    "where p.title = @paperTitle)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@paperTitle", SqlDbType.VarChar).Value = paperTitle;
                cmd.Parameters.Add("@comments", SqlDbType.VarChar).Value = comments;
                cmd.ExecuteReader();
                con.Close();

                /////////////////////////////////////////////////////////////////////////

            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /// <summary>
        ///  Aici Functia facuta pentru request new e
        /// </summary>
        /// <param name="id_bid"></param>
        public void new_evaluation(int id_bid)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "update ReviewerPaper set idreview=1 where idbid=@idbid";
                SqlCommand updatePaper = new SqlCommand(query, con);
                updatePaper.Parameters.Add("@idbid", SqlDbType.Int).Value = id_bid;
                updatePaper.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public void delete_existing_reviewers(string id_paper)
        {
            SqlConnection con = new SqlConnection(this.connectionString);

            try
            {
                con.Open();
                String query = "delete from ReviewerPaper where id in (select rp.id from Papers p " +
                    "join AbstractPaper ap on p.idabstract = ap.id " +
                    "join BidProposals bp on bp.idproposal = ap.id " +
                    "join ReviewerPaper rp on rp.idbid = bp.id " +
                    "where p.id = @id_paper )";

                SqlCommand delete_reviewers = new SqlCommand(query, con);
                delete_reviewers.Parameters.Add("@id_paper", SqlDbType.UniqueIdentifier).Value = new Guid(id_paper);
                delete_reviewers.ExecuteNonQuery();

                con.Close();

            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public List<User> getAuthors(int idConference)
        {
            List<User> authors = new List<User>();
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                string query = "SELECT DISTINCT U.* FROM Users U " +
                    "INNER JOIN AuthorsAbstractPaper AAP ON U.id = AAP.idauthor " +
                    "INNER JOIN AbstractPaper AP ON AP.id = AAP.idpaper " +
                    "WHERE AP.idconference = @idconference";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@idconference", SqlDbType.Int).Value = idConference;
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    authors.Add(new User(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString(),
                        sdr[3].ToString(), sdr[4].ToString(), sdr[5].ToString(), DateTime.Parse(sdr[6].ToString()),
                        sdr[7].ToString(), sdr[8].ToString(), sdr[9].ToString()));
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
    }
}