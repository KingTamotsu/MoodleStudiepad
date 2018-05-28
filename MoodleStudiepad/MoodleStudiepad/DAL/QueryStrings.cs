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
        
        public List<UserAccount> selectSingleUser(string table, string username) {
            List<UserAccount> readerList = base.getSingleUserReader(new SqlCommand("Select *" + " FROM " + "[" + table + "] INNER JOIN Roles ON UserAccount.roleId = Roles.roleId" + " Where Username = '" + username + "'", base.conn));
            return readerList;
        }

        #endregion
    }
}
