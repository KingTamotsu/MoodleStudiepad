using System;
using System.Collections.Generic;
using System.Text;
using MoodleStudiepad.DAL;

namespace MoodleStudiepad.BU
{
    public class UserAccount {
        private int userId;
        private string username;
        private string password;
        private string role;
        private List<string> user;

        public bool checkUser(string username, string password) {
            QueryStrings queryStrings = new QueryStrings();
            user = new List<string>();
            user = queryStrings.selectSingleUser(GetType().Name, username);

            if (user.Count == 0)
            {
                return false;
            }
            else
            {
                if (username == user[1] && password == user[2])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
