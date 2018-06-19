﻿using System;
using System.Collections.Generic;
using System.Text;
using MoodleStudiepad.BU;

namespace MoodleStudiepad.CC
{
    public class CheckUser {

        public bool checkUserOnLogin(string username, string password) {
            UserAccount userAccount = new UserAccount();
            userAccount.checkUser(username, password);

            if (userAccount.checkUser(username, password)) {
                return true;
            }
            else {
                return false;
            }
        }

        public string returnUsername(string username) {
            UserAccount userAccount = new UserAccount();
            string user = userAccount.returnUsername(username);
            return user;
        }

        public int returnUserId(string username) {
            UserAccount userAccount = new UserAccount();
            int userId = userAccount.returnUserId(username);
            return userId;
        }

        public int returnRoleId(string username) {
            UserAccount userAccount = new UserAccount();
            int roleId = userAccount.returnRoleId(username);
            return roleId;
        }
    }
}
