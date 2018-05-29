using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodleStudiepad.BU;

namespace MoodleStudiepad.DAL {
    public class QueryStrings: DBConnection {


        #region SelectQuerries



        public List<string> selectSingleUser(string table, string username) {
            List<string> readerList = getsingleReader(new SqlCommand("Select *" + " FROM " + table + " INNER JOIN Roles ON UserAccount.roleId = Roles.roleId" + " Where Username = '" + username + "'", base.conn));
            return readerList;
        }

        #endregion
    }
}
