using System;
using System.Collections.Generic;
using System.Text;
using MoodleStudiepad.BU;

namespace MoodleStudiepad.CC
{
    public class CheckUser {

        /// <summary>
        /// This method requires a username and password and sends it to the business layer.
        /// </summary>
        /// <param name="username">The username</param>
        /// <param name="password">The password</param>
        /// <returns>Returns a bool.</returns>
        public bool checkUserOnLogin(string username, string password) {
            UserAccount userAccount = new UserAccount();
            return userAccount.checkUser(username, password);
        }

        /// <summary>
        /// This method requires a username and sends it to the business layer.
        /// </summary>
        /// <param name="username">The username</param>
        /// <returns>Returns a username of the selected user.</returns>
        public string returnUsername(string username) {
            UserAccount userAccount = new UserAccount();
            string user = userAccount.returnUsername(username);
            return user;
        }

        /// <summary>
        /// This method requires a username and sends it to the business layer.
        /// </summary>
        /// <param name="username">The username</param>
        /// <returns>Returns the user id from the selected user.</returns>
        public int returnUserId(string username) {
            UserAccount userAccount = new UserAccount();
            int userId = userAccount.returnUserId(username);
            return userId;
        }

        /// <summary>
        /// This method requires a username and sends it to the business layer.
        /// </summary>
        /// <param name="username">The username</param>
        /// <returns>Returns the role id from the selected user.</returns>
        public int returnRoleId(string username) {
            UserAccount userAccount = new UserAccount();
            int roleId = userAccount.returnRoleId(username);
            return roleId;
        }
    }
}
