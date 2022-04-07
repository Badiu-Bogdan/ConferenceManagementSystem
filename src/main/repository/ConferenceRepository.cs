using ConferenceManagementSystem.main.repository;
using ConferenceManagementSystem.src.main.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ConferenceManagementSystem.src.main.repository
{
    public class ConferenceRepository<ID, T> : IRepository<ID, Conference>
    {
        private string connectionString;
        private DataSet ds;
        private SqlDataAdapter da;

        public ConferenceRepository(string conStr)
        {
            this.connectionString = conStr;
            this.da = new SqlDataAdapter();
        }

        public Conference findOne(ID id)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM Conferences WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (!sdr.HasRows)
                {
                    throw new RepositoryException("Conference not found.");
                }
                Conference conference = new Conference(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString(), DateTime.Parse(sdr[3].ToString()), DateTime.Parse(sdr[4].ToString()), DateTime.Parse(sdr[5].ToString()), DateTime.Parse(sdr[6].ToString()), DateTime.Parse(sdr[7].ToString()), new List<Topic>(), Boolean.Parse(sdr[9].ToString()));
                conference.setOrganizerId(int.Parse(sdr[8].ToString()));
                sdr.Close();
                con.Close();
                return conference;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public Conference findOne(String title)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM Conferences WHERE title = @title";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@title", SqlDbType.VarChar);
                cmd.Parameters["@title"].Value = title;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (!sdr.HasRows)
                {
                    throw new RepositoryException("Conference not found.");
                }
                Conference conference = new Conference(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString(), DateTime.Parse(sdr[3].ToString()), DateTime.Parse(sdr[4].ToString()), DateTime.Parse(sdr[5].ToString()), DateTime.Parse(sdr[6].ToString()), DateTime.Parse(sdr[7].ToString()), new List<Topic>(), Boolean.Parse(sdr[9].ToString()));
                conference.setTopics(getTopicsForConference(conference.getId()));
                conference.setOrganizerId(int.Parse(sdr[8].ToString()));
                sdr.Close();
                con.Close();
                return conference;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
        Retrieves the conferences from the Conferences table
        Input: -
        Output: The conferences
        Throws RepositoryException
         */
        public List<Conference> findAll()
        {
            List<Conference> conferences = new List<Conference>();

            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM Conferences";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    int id = Int32.Parse(sdr[0].ToString());
                    Conference conference = new Conference(id, sdr[1].ToString(), sdr[2].ToString(),
                        DateTime.Parse(sdr[3].ToString()), DateTime.Parse(sdr[4].ToString()), DateTime.Parse(sdr[5].ToString()),
                        DateTime.Parse(sdr[6].ToString()), DateTime.Parse(sdr[7].ToString()), this.getTopicsForConference(id),
                        Boolean.Parse(sdr[9].ToString()));
                    conference.setOrganizerId(int.Parse(sdr[8].ToString()));
                    conferences.Add(conference);
                }
                sdr.Close();
                con.Close();
                return conferences;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public void save(Conference conference)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                // Add the conference
                con.Open();
                String query = "INSERT INTO Conferences(title, description, startDateCFP, endDateCFPProposal, endDateCFPPaper, startDateConf, endDateConf, organizerid, requiresPaper) VALUES " +
                    "(@title, @desc, @startcfp, @endcfpprop, @endcfppaper, @startconf, @endconf, @orgid, @requiresPaper)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@title", SqlDbType.VarChar);
                cmd.Parameters.Add("@desc", SqlDbType.VarChar);
                cmd.Parameters.Add("@startcfp", SqlDbType.DateTime);
                cmd.Parameters.Add("@endcfpprop", SqlDbType.DateTime);
                cmd.Parameters.Add("@endcfppaper", SqlDbType.DateTime);
                cmd.Parameters.Add("@startconf", SqlDbType.DateTime);
                cmd.Parameters.Add("@endconf", SqlDbType.DateTime);
                cmd.Parameters.Add("@orgid", SqlDbType.Int);
                cmd.Parameters.Add("@requiresPaper", SqlDbType.Bit);


                cmd.Parameters["@title"].Value = conference.getTitle();
                cmd.Parameters["@desc"].Value = conference.getDescription();
                cmd.Parameters["@startcfp"].Value = conference.getStartCFP();
                cmd.Parameters["@endcfpprop"].Value = conference.getEndCFPProp();
                cmd.Parameters["@endcfppaper"].Value = conference.getEndCFPPaper();
                cmd.Parameters["@startconf"].Value = conference.getStartDate();
                cmd.Parameters["@endconf"].Value = conference.getEndDate();
                cmd.Parameters["@orgid"].Value = conference.getOrganizerId(); // must be set before
                cmd.Parameters["@requiresPaper"].Value = conference.getRequiresPaper() ? 1 : 0;

                int result = cmd.ExecuteNonQuery();
                if (result < 0)
                    throw new RepositoryException("Error inserting the new User into the Database!");

                // Select the id of the conference added
                query = "SELECT id FROM Conferences WHERE title = @title AND organizerid = @orgid";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@title", SqlDbType.VarChar);
                cmd.Parameters.Add("@orgid", SqlDbType.Int);

                cmd.Parameters["@title"].Value = conference.getTitle();
                cmd.Parameters["@orgid"].Value = conference.getOrganizerId();
                int conferenceId = -1;

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    conferenceId = Int32.Parse(sdr[0].ToString());
                }
                sdr.Close();

                if (conferenceId == -1)
                {
                    throw new RepositoryException("Could not find id of the freshly added conference.");
                }

                // Link the topics
                List<Topic> topics = conference.getTopics();
                for (int i = 0; i < topics.Count; i++)
                {
                    query = "INSERT INTO ConferencesTopics VALUES (@confid, " +
                        "(SELECT id FROM Topics WHERE name = @topic)" +
                        ")";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@confid", SqlDbType.Int);
                    cmd.Parameters.Add("@topic", SqlDbType.VarChar);

                    cmd.Parameters["@confid"].Value = conferenceId;
                    cmd.Parameters["@topic"].Value = topics[i].Name;
                    cmd.ExecuteNonQuery();
                }

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

        public void update(Conference entity)
        {

        }

        /*
        Retrieves the topics from the Topics table
        Input: -
        Output: The topics
        Throws RepositoryException
         */
        public List<Topic> getTopics()
        {
            List<Topic> topics = new List<Topic>();

            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                string query = "SELECT * FROM Topics";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Topic topic = new Topic(Int32.Parse(sdr[0].ToString()), sdr[1].ToString());
                    topics.Add(topic);
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
        Retrieves the topics for a given conference
        Input: -
        Output: The topics
        Throws RepositoryException
         */
        public List<Topic> getTopicsForConference(int conferenceId)
        {
            List<Topic> topics = new List<Topic>();

            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                string query = "SELECT T.id, T.name FROM Topics T INNER JOIN ConferencesTopics CT ON T.id = CT.idtopic WHERE idconference = @conferenceId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@conferenceId", SqlDbType.Int);
                cmd.Parameters["@conferenceId"].Value = conferenceId;
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Topic topic = new Topic(Int32.Parse(sdr[0].ToString()), sdr[1].ToString());
                    topics.Add(topic);
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
        Retrieves the topics for the given conference with their ids from the Topics table
        Input: -
        Output: The topics as a list of strings
        Throws RepositoryException
         */
        public List<string> getTopicsIds(int id)
        {
            List<string> topics = new List<string>();

            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                string query = "SELECT topic.id, topic.name FROM Topics topic " +
                    "INNER JOIN ConferencesTopics conftop ON topic.id = conftop.idtopic " +
                    "INNER JOIN Conferences conf ON conf.id = conftop.idconference " +
                    "where conf.id = @idconf";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@idconf", SqlDbType.Int);
                cmd.Parameters["@idconf"].Value = id;
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    string topic = sdr[0].ToString() + "." + sdr[1].ToString();
                    topics.Add(topic);
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
        Saves the schedule for a conference
        Input: scheduleDict - <idTopic, List of Tuples (List<int>)> in which:
        0=year, 1=month, 2=day, 3=startHour, 4=startMin, 5=endHour, 6=endMin, 7=idAbstract
        Output: -
        Throws RepositoryException
         */
        public void saveSchedule(Dictionary<int, List<List<int>>> scheduleDict, int idConference)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                string query;
                // for each schedule entry
                foreach (KeyValuePair<int, List<List<int>>> entry in scheduleDict)
                {
                    int idTopic = entry.Key;
                    List<List<int>> schedules = entry.Value;
                    for (int i = 0; i < schedules.Count; i++)
                    {
                        List<int> tuple = schedules[i];
                        int idAbstract = tuple[7];
                        DateTime dtStart = DateTime.Parse(tuple[0] + "-" + tuple[1] + "-" + tuple[2] + " " + tuple[3] + ":" + tuple[4]);
                        DateTime dtEnd = DateTime.Parse(tuple[0] + "-" + tuple[1] + "-" + tuple[2] + " " + tuple[5] + ":" + tuple[6]);

                        // select idConferencesTopic
                        query = "SELECT id from ConferencesTopics WHERE idconference = @confId AND idtopic = @topicId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add("@confId", SqlDbType.Int);
                        cmd.Parameters.Add("@topicId", SqlDbType.Int);
                        cmd.Parameters["@confId"].Value = idConference;
                        cmd.Parameters["@topicId"].Value = idTopic;
                        SqlDataReader sdr = cmd.ExecuteReader();
                        int id = 0;
                        while (sdr.Read())
                        {
                            id = Int32.Parse(sdr[0].ToString());
                        }
                        sdr.Close();

                        query = "INSERT INTO Schedules VALUES (@dtStart, @dtEnd, @sectionId, @abstractId)";
                        cmd = new SqlCommand(query, con);
                        cmd.Parameters.Add("@dtStart", SqlDbType.DateTime);
                        cmd.Parameters.Add("@dtEnd", SqlDbType.DateTime);
                        cmd.Parameters.Add("@sectionId", SqlDbType.Int);
                        cmd.Parameters.Add("@abstractId", SqlDbType.Int);
                        cmd.Parameters["@dtStart"].Value = dtStart;
                        cmd.Parameters["@dtEnd"].Value = dtEnd;
                        cmd.Parameters["@sectionId"].Value = id;
                        cmd.Parameters["@abstractId"].Value = idAbstract;
                        cmd.ExecuteNonQuery();
                    }
                }
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
        Get the schedule for a conference
        Input: id of the conference
        Output: scheduleDict - <idTopic, List of Tuples (List<int>)> in which:
        0=year, 1=month, 2=day, 3=startHour, 4=startMin, 5=endHour, 6=endMin, 7=idAbstract
        Throws RepositoryException
         */
        public Dictionary<int, List<List<int>>> getSchedule(int idConference)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            Dictionary<int, List<List<int>>> scheduleDict = new Dictionary<int, List<List<int>>>();
            try
            {
                con.Open();

                string query = "SELECT S.id, S.dtStart, S.dtEnd, CT.idtopic, S.idAbstract " +
                    "FROM Schedules S INNER JOIN ConferencesTopics CT ON S.idSection = CT.id " +
                    "WHERE S.idSection IN (" +
                    "SELECT id FROM ConferencesTopics WHERE idconference = @idconf)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@idconf", SqlDbType.Int);
                cmd.Parameters["@idconf"].Value = idConference;
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    DateTime dtStart = DateTime.Parse(sdr[1].ToString());
                    DateTime dtEnd = DateTime.Parse(sdr[2].ToString());
                    int idSection = Int32.Parse(sdr[3].ToString());
                    int idAbstract = Int32.Parse(sdr[4].ToString());
                    List<int> tuple = new List<int>();
                    tuple.Add(dtStart.Year);
                    tuple.Add(dtStart.Month);
                    tuple.Add(dtStart.Day);
                    tuple.Add(dtStart.Hour);
                    tuple.Add(dtStart.Minute);
                    tuple.Add(dtEnd.Hour);
                    tuple.Add(dtEnd.Minute);
                    tuple.Add(idAbstract);

                    // add the tuple in the dict
                    if (!scheduleDict.ContainsKey(idSection))
                    {
                        scheduleDict.Add(idSection, new List<List<int>>());
                    }
                    scheduleDict[idSection].Add(tuple);

                }
                sdr.Close();

                con.Close();
                return scheduleDict;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
        Assignes chairs to sections
        Input: id of the conference, dictionary <idTopic, id
        Output: scheduleDict - <idTopic, List of Tuples (List<int>)> in which:
        0=year, 1=month, 2=day, 3=startHour, 4=startMin, 5=endHour, 6=endMin, 7=idAbstract
        Throws RepositoryException
         */
        public void assignChairsToSections(int idConference, Dictionary<int, int> assignDict)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query;
                SqlCommand cmd;

                foreach (KeyValuePair<int, int> entry in assignDict)
                {
                    // select idConferencesTopic
                    query = "SELECT id from ConferencesTopics WHERE idconference = @confId AND idtopic = @topicId";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@confId", SqlDbType.Int);
                    cmd.Parameters.Add("@topicId", SqlDbType.Int);
                    cmd.Parameters["@confId"].Value = idConference;
                    cmd.Parameters["@topicId"].Value = entry.Key;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    int id = 0;
                    while (sdr.Read())
                    {
                        id = Int32.Parse(sdr[0].ToString());
                    }
                    sdr.Close();

                    query = "INSERT INTO SessionChairsSections (idConference, idChair, idSection) VALUES (@confId, @chairId, @sectionId)";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@confId", SqlDbType.Int);
                    cmd.Parameters.Add("@chairId", SqlDbType.Int);
                    cmd.Parameters.Add("@sectionId", SqlDbType.Int);
                    cmd.Parameters["@confId"].Value = idConference;
                    cmd.Parameters["@chairId"].Value = entry.Value;
                    cmd.Parameters["@sectionId"].Value = id;
                    cmd.ExecuteNonQuery();
                }

                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
        Get a dictionary of chairs and the sections they are assigned to
        Input: id of the conference
        Output: assignedDict <topicId, chairId>
        Throws RepositoryException
         */
        public Dictionary<int, int> getAssignedChairs(int idConference)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            Dictionary<int, int> assignedDict = new Dictionary<int, int>();
            try
            {
                con.Open();

                string query = "SELECT CT.idtopic, SCS.idChair " +
                    "FROM SessionChairsSections SCS INNER JOIN ConferencesTopics CT ON SCS.idSection = CT.id " +
                    "WHERE SCS.idConference = @idconf";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@idconf", SqlDbType.Int);
                cmd.Parameters["@idconf"].Value = idConference;
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    int idTopic = Int32.Parse(sdr[0].ToString());
                    int idChair = Int32.Parse(sdr[1].ToString());
                    assignedDict.Add(idTopic, idChair);
                }
                sdr.Close();
                con.Close();

                return assignedDict;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
         Check if an author is in a section
        Input: idChair, idSection, idConference
        Output: true if the author is in a section, false otherwise
         */
        public bool isAuthorInSection(int idChair, int idSection, int idConference)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            Dictionary<int, int> assignDict = new Dictionary<int, int>();
            try
            {
                con.Open();

                // select all authors for a given topic(section) for a given conference
                string query = "SELECT AAP.idauthor FROM Schedules S " +
                    "INNER JOIN ConferencesTopics CT ON S.idSection = CT.id " +
                    "INNER JOIN AuthorsAbstractPaper AAP ON AAP.idpaper = S.idAbstract " +
                    "WHERE CT.idTopic = @idtopic AND CT.idconference = @idconf";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@idtopic", SqlDbType.Int);
                cmd.Parameters.Add("@idconf", SqlDbType.Int);
                cmd.Parameters["@idtopic"].Value = idSection;
                cmd.Parameters["@idconf"].Value = idConference;
                SqlDataReader sdr = cmd.ExecuteReader();
                int idAuthor;
                while (sdr.Read())
                {
                    idAuthor = Int32.Parse(sdr[0].ToString());
                    if (idChair == idAuthor){
                        sdr.Close();
                        return true;
                    }
                }
                sdr.Close();

                con.Close();
                return false;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
         Check if an author is in a section
        Input: idChair, idSection, idConference
        Output: true if the author is in a section, false otherwise
         */
        public int getNumberAttendances(int idConference, int idTopic)
        {
            int idSession = this.getConferenceTopicId(idConference, idTopic);
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();

                // select all authors for a given topic(section) for a given conference
                string query = "SELECT COUNT(1) FROM Attendances WHERE idSection = @idSection";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@idSection", SqlDbType.Int);
                cmd.Parameters["@idSection"].Value = idSession;
                SqlDataReader sdr = cmd.ExecuteReader();
                int result = -1;
                while (sdr.Read())
                {
                    result = Int32.Parse(sdr[0].ToString());
                }
                sdr.Close();

                con.Close();
                return result;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
        Retrieve the id of the Conference Topic
        Input: idConference, idTopic
        Output: the id from the ConferencesTopics table corresponding to the input values
        */
        private int getConferenceTopicId(int idConference, int idTopic)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();

                // select all authors for a given topic(section) for a given conference
                string query = "SELECT id FROM ConferencesTopics WHERE idconference = @confId AND idtopic = @topicId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@confId", SqlDbType.Int);
                cmd.Parameters.Add("@topicId", SqlDbType.Int);
                cmd.Parameters["@confId"].Value = idConference;
                cmd.Parameters["@topicId"].Value = idTopic;
                SqlDataReader sdr = cmd.ExecuteReader();
                int result = -1;
                while (sdr.Read())
                {
                    result = Int32.Parse(sdr[0].ToString());
                }
                sdr.Close();

                con.Close();
                return result;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
        A user joins a session of a conference
        Input: idConference, idTopic (=session), idUser
        Output: -
        */
        public void joinSession(int idConference, int idTopic, int idUser)
        {
            int idSession = this.getConferenceTopicId(idConference, idTopic);
            if(this.userJoinedSession(idSession, idUser))
            {
                throw new RepositoryException("You have already joined this session.");
            }

            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();

                String query = "INSERT INTO Attendances VALUES (@userId, @sectionId)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@userId", SqlDbType.Int);
                cmd.Parameters.Add("@sectionId", SqlDbType.Int);
                cmd.Parameters["@userId"].Value = idUser;
                cmd.Parameters["@sectionId"].Value = idSession;
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
        Check if a user has already joined a given session
        Input: idSession, idUser
        Output: true if the user joined the session, false otherwise
        */
        public bool userJoinedSession(int idSession, int idUser)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();

                // select all authors for a given topic(section) for a given conference
                string query = "SELECT COUNT(1) FROM Attendances WHERE idUser = @userId AND idSection = @sectionId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@userId", SqlDbType.Int);
                cmd.Parameters.Add("@sectionId", SqlDbType.Int);
                cmd.Parameters["@userId"].Value = idUser;
                cmd.Parameters["@sectionId"].Value = idSession;
                SqlDataReader sdr = cmd.ExecuteReader();
                int result = -1;
                while (sdr.Read())
                {
                    result = Int32.Parse(sdr[0].ToString());
                }
                sdr.Close();

                con.Close();
                if(result >= 1)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
        Retrieve all pc members for a given conference
        Input: idConference
        Output: list containing the pc members
        */
        public List<PCMember> getPCMembersForConference(int idConference)
        {
            List<PCMember> pcMembers = new List<PCMember>();

            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query = "SELECT U.* FROM PCMembersConferences PCMC " +
                    "INNER JOIN Users U ON U.id = PCMC.idUser " +
                    "WHERE PCMC.idConference = @confId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@confId", SqlDbType.Int);
                cmd.Parameters["@confId"].Value = idConference;
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    int id = Int32.Parse(sdr[0].ToString());
                    PCMember pcMember = new PCMember(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString(), sdr[5].ToString(), DateTime.Parse(sdr[6].ToString()), sdr[7].ToString(), sdr[8].ToString(), sdr[9].ToString());
                    pcMembers.Add(pcMember);
                }
                sdr.Close();
                con.Close();
                return pcMembers;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
        Mark a user as a PCMember for a given conference
        Input: idConference, idUser
        Output: -
        */
        public void insertPCMemberForConference(int idConference, int idUser)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();

                String query = "INSERT INTO PCMembersConferences VALUES (@userId, @conferenceId)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@userId", SqlDbType.Int);
                cmd.Parameters.Add("@conferenceId", SqlDbType.Int);
                cmd.Parameters["@userId"].Value = idUser;
                cmd.Parameters["@conferenceId"].Value = idConference;
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
        Check if a given user is a PC Member for a given conference
        Input: idConference, idUser
        Output: true if the user is a PC member for the conference, false otherwise
        */
        public bool isPCMemberForConference(int idConference, int idUser)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                string query = "SELECT * FROM PCMembersConferences WHERE idUser = @userId AND idConference = @conferenceId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@userId", SqlDbType.Int);
                cmd.Parameters.Add("@conferenceId", SqlDbType.Int);
                cmd.Parameters["@userId"].Value = idUser;
                cmd.Parameters["@conferenceId"].Value = idConference;
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    sdr.Close();
                    con.Close();
                    return true;
                }
                sdr.Close();
                con.Close();
                return false;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
        Get all the rooms
        Input: 
        Output: list of rooms
        */
        public List<Room> getRooms()
        {
            List<Room> rooms = new List<Room>();

            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                string query = "SELECT * FROM Rooms";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Room room = new Room(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), Int32.Parse(sdr[2].ToString()));
                    rooms.Add(room);
                }
                sdr.Close();
                con.Close();
                return rooms;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
        Assing some selected rooms to different sessions
        Input: idConference, assignedRooms = <Topic, Room>
        Output: -
        */
        public void assignRoomsToSessions(int idConference, Dictionary<Topic, Room> assignedRooms)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                String query;
                SqlCommand cmd;

                foreach (KeyValuePair<Topic, Room> entry in assignedRooms)
                {
                    // select idConferencesTopic
                    query = "SELECT id from ConferencesTopics WHERE idconference = @confId AND idtopic = @topicId";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@confId", SqlDbType.Int);
                    cmd.Parameters.Add("@topicId", SqlDbType.Int);
                    cmd.Parameters["@confId"].Value = idConference;
                    cmd.Parameters["@topicId"].Value = entry.Key.Id;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    int id = 0;
                    while (sdr.Read())
                    {
                        id = Int32.Parse(sdr[0].ToString());
                    }
                    sdr.Close();

                    query = "INSERT INTO SessionsRooms (idSession, idRoom) VALUES (@sessionId, @roomId)";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@sessionId", SqlDbType.Int);
                    cmd.Parameters.Add("@roomId", SqlDbType.Int);
                    cmd.Parameters["@sessionId"].Value = id;
                    cmd.Parameters["@roomId"].Value = entry.Value.Id;
                    cmd.ExecuteNonQuery();
                }

                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        /*
        Get the assigned room for a topic
        Input: idConference, idSelectedTopic
        Output: the assigned room
        */
        public Room getRoomForTopic(int idConference, int idSelectedTopic)
        {
            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                Room room = null;

                // select idConferencesTopic
                String query = "SELECT R.* FROM Rooms R INNER JOIN SessionsRooms SR ON R.id = SR.idRoom " +
                    "INNER JOIN ConferencesTopics CT ON CT.id = SR.idSession " +
                    "WHERE CT.idconference = @confId AND idtopic = @topicId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@confId", SqlDbType.Int);
                cmd.Parameters.Add("@topicId", SqlDbType.Int);
                cmd.Parameters["@confId"].Value = idConference;
                cmd.Parameters["@topicId"].Value = idSelectedTopic;
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    room = new Room(Int32.Parse(sdr[0].ToString()), sdr[1].ToString(), Int32.Parse(sdr[2].ToString()));
                }
                sdr.Close();
                con.Close();

                return room;
            }
            catch (Exception e)
            {
                con.Close();
                throw new RepositoryException(e.Message);
            }
        }

        public List<Review> queryOtherReviews(int idProposal)
        {
            List<Review> reviews = new List<Review>();

            SqlConnection con = new SqlConnection(this.connectionString);
            try
            {
                con.Open();
                string query = "SELECT R.* FROM Reviews R " +
                    "INNER JOIN  ReviewerPaper RP ON R.id = RP.idreview " +
                    "INNER JOIN BidProposals BP ON RP.idbid = BP.id " +
                    "WHERE idproposal = @idproposal";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@idproposal", SqlDbType.Int);
                cmd.Parameters["@idproposal"].Value = idProposal;
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
    }
}
