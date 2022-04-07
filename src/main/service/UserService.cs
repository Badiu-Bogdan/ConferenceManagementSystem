
using ConferenceManagementSystem.main.repository;
using ConferenceManagementSystem.src.main.domain;
using ConferenceManagementSystem.src.main.repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConferenceManagementSystem.src.main.service
{
    public class UserService
    {
        protected UserRepository<long, User> repository;
        public UserService(UserRepository<long, User> repository)
        {
            this.repository = repository;
        }

        /*
        Login a user based on his username/email and password
       Input: String, String
       Output: The User if found, otherwise throws an exception
        */
        public User loginUser(String useremail, String password)
        {
            try
            {
                User user = this.repository.findOne(useremail, password);
                return user;
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        /*
         Register user in the database
         Input: User that needs to be registered
         Throws ServiceException
         */
        public void registerUser(User entity)
        {
            try
            {
                this.repository.save(entity);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        /*
         * Set the type of user for a given user
         * Input: user = the user whose type will be set
         *        userType = the type to be set
         * Throws ServiceException
         */
        public void setUserType(User user, UserType userType)
        {
            try
            {
                if (userType.getName() == "Other") // this does not change anything in the database
                {
                    return;
                }
                UserType foundUserType = this.repository.getUserTypeByName(userType.getName()); // search for the user type
                User foundUser = this.repository.getUserWithoutId(user);
                this.repository.setUserType(user, foundUserType);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        /*
         Returns a list of user types from the user repository
         Throws ServiceException
         */
        public List<UserType> getUserTypes()
        {
            try
            {
                List<UserType> userTypes = this.repository.getUserTypes();
                return userTypes;
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        /*
         Returns a list of user types from the user repository which can be chosen
         at the registration step
         Throws ServiceException
         */
        public List<UserType> getRegistrationUserTypes()
        {
            try
            {
                List<UserType> userTypes = this.repository.getRegistrationUserTypes();
                return userTypes;
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        /*
         Returns a list of user types from the user repository which can be chosen
         by the user
         Throws ServiceException
         */
        public List<UserType> getUserTypesForUser(User user)
        {
            try
            {
                return this.repository.getUserTypesForUser(user);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        /*
         Returns a list of user types from the user repository
         Throws ServiceException
         */
        public void postponeConference(int idConference, string type, DateTime newDate)
        {
            try
            {
                this.repository.postponeConference(idConference, type, newDate);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public List<(int Cid, int Usid)> getChairsForConference(int conference_id)
        {
            try
            {
                return this.repository.getChairUsers(conference_id);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public void addChair(int cid, int usid)
        {
            try
            {
                this.repository.add_chair(cid, usid);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public void removeChair(int cid, int usid)
        {
            try
            {
                this.repository.remove_chair(cid, usid);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        /*
         Returns a user based on its id
         Throws ServiceException
         */
        public User getUser(int idUser)
        {
            try
            {
                List<User> users = this.repository.findAll();
                return users.Find(usr => usr.Id == idUser);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public List<User> getUsers()
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

        public void createChat(string paperName)
        {
            try
            {
                this.repository.createChat(paperName);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        //check if the given user is requested to discuss
        public bool isRequestedToDiscuss(User loggedUser)
        {
            try
            {
                List<User> usersRequestedToDiscuss = this.repository.requestedToDiscuss();

                if (usersRequestedToDiscuss.Any(user => user.Id == loggedUser.Id))
                    return true;
                return false;
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public string getCommentsForChat(string paperTitle)
        {
            try
            {
                return this.repository.getCommentsForChat(paperTitle);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public void updateVerdictAfterDiscussion(int verdict, string paperTitle, User user)
        {
            try
            {
                this.repository.updateVerdictAfterDiscussion(verdict, paperTitle, user);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public void requestNewEvaluation(int idBid)
        {
            try
            {
                this.repository.new_evaluation(idBid);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public void deleteReviewers(string id_paper)
        {
            try
            {
                this.repository.delete_existing_reviewers(id_paper);
            }
            catch(RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }

        public void updateChat(string comment, string paperTitle, User user)
        {
            try
            {
                this.repository.updateChat(comment, paperTitle, user);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }
        public List<User> getAuthors(int idConference)
        {
            try
            {
                return this.repository.getAuthors(idConference);
            }
            catch (RepositoryException e)
            {
                throw new ServiceException(e.Message);
            }
        }
    }
}
