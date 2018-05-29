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
        private List<UserAccount> user;


        QueryStrings queryStrings = new QueryStrings();


        public bool checkUser(string username, string password) {
            user = new List<UserAccount>();
            user = queryStrings.selectSingleUser(GetType().Name, username);

            if (username == user[1].ToString() && password == user[2].ToString()) {
                return true;
            } else {
                return false;
            }
        }

    }
}
