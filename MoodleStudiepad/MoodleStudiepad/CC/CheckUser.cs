using System;
using System.Collections.Generic;
using System.Text;
using MoodleStudiepad.BU;

namespace MoodleStudiepad.CC
{
    public class CheckUser{

        public bool checkUserOnLogin(string username, string password) {
            UserAccount userAccount = new UserAccount();
            userAccount.checkUser(username, password);

            if (userAccount.checkUser(username, password)) {
                return true;
            } else {
                return false;
            }
        }
    }
}
