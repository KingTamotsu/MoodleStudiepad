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
        public string role;

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

        public string returnUsername(string username) {
            QueryStrings queryStrings = new QueryStrings();
            UserAccount user = new UserAccount();
            user = queryStrings.selectSingleUser(username);
            return user.username;
        }

        public int returnUserId(string username) {
            QueryStrings queryStrings = new QueryStrings();
            UserAccount user = new UserAccount();
            user = queryStrings.selectSingleUser(username);
            return user.userId;
        }

    }
}
