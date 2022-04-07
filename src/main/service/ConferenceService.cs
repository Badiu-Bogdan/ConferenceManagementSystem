using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConferenceManagementSystem.src.main.service
{
    public class ConferenceService
    {
        protected ConferenceRepository<long, Conference> repository;

        public ConferenceService(ConferenceRepository<long, Conference> repository)
        {
            this.repository = repository;
        }

        /*
         Returns a list of topics from the repository
         Throws ServiceException
         */
        public List<Topic> getTopics()
        {
            try
            {
                return this.repository.getTopics();
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public List<Topic> getTopicsForConference(int conferenceId)
        {
            try
            {
                return this.repository.getTopicsForConference(conferenceId);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        /*
         Returns a list of topics with their ids from the repository
         Throws ServiceException
         */
        public List<string> getTopicsIds(int id)
        {
            try
            {
                return this.repository.getTopicsIds(id);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public List<Conference> getConferences()
        {
            try
            {
                return this.repository.findAll();
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public Conference getConferenceForTitle(string title)
        {
            try
            {
                List<Conference> conferences = this.repository.findAll();
                Conference conf = conferences.Find(c => c.getTitle().Equals(title));
                return conf;

            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        /*
         * Returns the conference coresponding to the given id.
         * Param: conference_id = the id of the conference to look for
         * Return: CONFERENCE if found or NULL otherwise
         */
        public Conference getConferenceForId(int conference_id)
        {
            List<Conference> conferences_list = this.getConferences();
            foreach(Conference conference in conferences_list)
            {
                if (conference.getId() == conference_id)
                    return conference;
            }

            return null;
        }

        public void organizeConference(string title, string description, DateTime startDateConf, DateTime endDateConf, DateTime startDateCFP, DateTime endDateCFPProp, DateTime endDateCFPPaper, List<Topic> topics, User currentUser, bool requiresPaper)
        {
            try
            {
                Conference conference = new Conference(title, description, startDateConf, endDateConf, startDateCFP, endDateCFPProp, endDateCFPPaper, topics, requiresPaper);
                conference.setOrganizerId(currentUser.Id);
                this.repository.save(conference);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public void saveSchedule(Dictionary<int, List<List<int>>> scheduleDict, int idConference)
        {
            try
            {
                this.repository.saveSchedule(scheduleDict, idConference);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public Dictionary<int, List<List<int>>> getSchedule(int idConference)
        {
            try
            {
                return this.repository.getSchedule(idConference);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public bool conferenceSectionsOrganized(int idConference)
        {
            try
            {
                Dictionary<int, List<List<int>>> scheduleDict = this.repository.getSchedule(idConference);
                if(scheduleDict.Count > 0)
                {
                    return true;
                }
                return false;
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public void assignChairsToSections(int idConference, Dictionary<int, int> assignDict)
        {
            try
            {
                this.repository.assignChairsToSections(idConference, assignDict);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public bool chairsAssigned(int idConference)
        {
            try
            {
                Dictionary<int, int> assignedChairs = this.repository.getAssignedChairs(idConference);
                if (assignedChairs.Count > 0)
                {
                    return true;
                }
                return false;
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public Dictionary<int, int> getAssignedSessionChairs(int idConference)
        {
            try
            {
                return this.repository.getAssignedChairs(idConference);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public bool isAuthorInSection(int idChair, int idSection, int idConference)
        {
            try
            {
                return this.repository.isAuthorInSection(idChair, idSection, idConference);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public int getNumberAttendances(int idConference, int idTopic)
        {
            try
            {
                return this.repository.getNumberAttendances(idConference, idTopic);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public void joinSession(int idConference, int idTopic, int idUser)
        {
            try
            {
                this.repository.joinSession(idConference, idTopic, idUser);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public String formatTimeFrame(int startHour, int startMin, int endHour, int endMin)
        {
            String format = "";
            if (startHour < 10)
            {
                format += "0";
            }
            format += startHour.ToString();
            format += ":";
            if (startMin < 10)
            {
                format += "0";
            }
            format += startMin.ToString();
            format += "-";
            if (endHour < 10)
            {
                format += "0";
            }
            format += endHour.ToString();
            format += ":";
            if (endMin < 10)
            {
                format += "0";
            }
            format += endMin.ToString();
            return format;
        }

        public List<PCMember> getPCMembersForConference(int idConference)
        {
            try
            {
                return this.repository.getPCMembersForConference(idConference);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public void insertPCMemberForConference(int idConference, int idUser)
        {
            try
            {
                this.repository.insertPCMemberForConference(idConference, idUser);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public bool isPCMemberForConference(int idConference, int idUser)
        {
            try
            {
                return this.repository.isPCMemberForConference(idConference, idUser);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public List<Review> queryOtherReviews(int idProposal)
        {
            try
            {
                return this.repository.queryOtherReviews(idProposal);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public List<Room> getRooms()
        {
            try
            {
                return repository.getRooms();
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public void assignRoomsToSessions(int idConference, Dictionary<Topic, Room> assignedRooms)
        {
            try
            {
                repository.assignRoomsToSessions(idConference, assignedRooms);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public Room getRoomForTopic(int idConference, int idSelectedTopic)
        {
            try
            {
                return repository.getRoomForTopic(idConference, idSelectedTopic);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }
    }
}
