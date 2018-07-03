using System;
using System.Collections.Generic;
using System.Text;
using MoodleStudiepad.DAL;

namespace MoodleStudiepad.BU
{
    public class UserAccount {
        public int userId;
        public string username;
        public string password;
        public int roleId;

        /// <summary>
        /// This method requires a username and password. Then the method checks wetter the data passed in is the same as in the database.
        /// </summary>
        /// <param name="username">The username</param>
        /// <param name="password">The password</param>
        /// <returns>Returns a bool wetter the data is the same as the database.</returns>
        public bool checkUser(string username, string password) {
            QueryStrings queryStrings = new QueryStrings();
            UserAccount user = new UserAccount();
            user = queryStrings.selectSingleUser(username);

            if (user == null) {
                return false;
            }
            else {
                if (username == user.username && password == user.password) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }

        /// <summary>
        /// This method requires a username in order to get the username of the user.
        /// </summary>
        /// <param name="username">The username</param>
        /// <returns>Returns the username.</returns>
        public string returnUsername(string username) {
            QueryStrings queryStrings = new QueryStrings();
            UserAccount user = new UserAccount();
            user = queryStrings.selectSingleUser(username);
            return user.username;
        }

        /// <summary>
        /// This method requires a username in order to get the id of the user
        /// </summary>
        /// <param name="username">The username</param>
        /// <returns>Returns the user id.</returns>
        public int returnUserId(string username) {
            QueryStrings queryStrings = new QueryStrings();
            UserAccount user = new UserAccount();
            user = queryStrings.selectSingleUser(username);
            return user.userId;
        }

        /// <summary>
        /// This method requires a username in order to get the role id of the user.
        /// </summary>
        /// <param name="username">The username</param>
        /// <returns>Returns the role id.</returns>
        public int returnRoleId(string username) {
            QueryStrings queryStrings = new QueryStrings();
            UserAccount user = new UserAccount();
            user = queryStrings.selectSingleUser(username);
            return user.roleId;
        }
    }
}
