using System;
using System.Collections.Generic;
using System.Text;
using MoodleStudiepad.BU;

namespace MoodleStudiepad.CC
{
    public class CheckUserOnLogin{

        public void checkUserOnLogin(string username, string password) {
            UserAccount userAccount = new UserAccount();
            userAccount.checkUser(username, password);
        }
    }
}
