using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using MoodleStudiepad.BU;

namespace MoodleStudiepad.DAL {
    public class DBConnection {
        protected SqlConnection conn;

        public SqlConnection connectDB() {
            var connectionString = @"Data Source=moodlestudiepad.database.windows.net;" +
                                   "Initial Catalog=MoodleStudiepad;" + "User id=moodleadmin;" +
                                   "Password=#studiepad01;";
            conn = new SqlConnection(connectionString);
            return conn;
        }

        #region DataMapperToList

        //Uitzoeken hoe dit werkt met onze checkuser (user with inner join roles get sql c# datamapper)


        

        public static List<T> DataReaderMapToList<T>(IDataReader dr) {
            var list = new List<T>();
            var user = default(T);
            while (dr.Read()) {
                user = Activator.CreateInstance<T>();
                foreach (var prop in user.GetType().GetProperties()) {

                    if (!Equals(dr[prop.Name], DBNull.Value)) prop.SetValue(user, dr[prop.Name], null);
                }

                list.Add(user);
            }

            return list;
        }

        #endregion


        #region Select Readers

        protected List<UserAccount> getSingleUserReader(SqlCommand cmd) {
            var dataList = new List<UserAccount>();

            try {
                connectDB();
                conn.Open();
                cmd.Connection = conn;
                var reader = cmd.ExecuteReader();
                dataList = DataReaderMapToList<UserAccount>(reader);
            }

            catch (SqlException error) {
                //implement error catching
            }

            conn.Close();

            return dataList;
        }

        //Dit is voor een lijst voor strings van wat die leest en geen object
        protected List<string> getsingleReader(SqlCommand cmd) {
            List<string> dataList = new List<string>();

            try {
                connectDB();
                this.conn.Open();
                cmd.Connection = this.conn;
                SqlDataReader reader = cmd.ExecuteReader();
                int count = reader.FieldCount;
                while (reader.Read()) {
                    for (int i = 0; i < count; i++) {

                        object row = reader.GetValue(i);
                        dataList.Add(row.ToString());
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException error) {
                throw error;
            }
            this.conn.Close();

            return dataList;
        }
        #endregion


    }
}