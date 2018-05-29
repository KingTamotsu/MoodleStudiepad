using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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

        public static List<T> DataReaderMapToList<T>(IDataReader dr) {
            var list = new List<T>();
            var obj = default(T);
            while (dr.Read()) {
                obj = Activator.CreateInstance<T>();
                foreach (var prop in obj.GetType().GetProperties()) {
                    Debug.Write(prop);
                    if (!Equals(dr[prop.Name], DBNull.Value)) {
                        prop.SetValue(obj, dr[prop.Name], null);
                    }
                }

                list.Add(obj);
            }

            return list;
        }

        #endregion


        #region Select Readers

        //Dit is voor een lijst voor strings van wat die leest en geen object
        protected List<string> getsingleReader(SqlCommand cmd) {
            var dataList = new List<string>();

            try {
                connectDB();
                conn.Open();
                cmd.Connection = conn;
                var reader = cmd.ExecuteReader();
                var count = reader.FieldCount;
                while (reader.Read()) {
                    for (var i = 0; i < count; i++) {
                        var row = reader.GetValue(i);
                        dataList.Add(row.ToString());
                    }
                }
            }
            catch (SqlException error) {
                throw error;
            }

            conn.Close();
            
            return dataList;
        }

        #endregion
    }
}