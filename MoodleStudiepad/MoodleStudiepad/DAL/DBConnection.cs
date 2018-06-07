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


        #region Get

        protected UserAccount SelectSingleUser(SqlCommand cmd) {
            UserAccount userAccount = new UserAccount();

            try {
                connectDB();
                conn.Open();
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable schemaTable = reader.GetSchemaTable();


                while (reader.Read()) {
                    foreach (DataRow row in schemaTable.Rows) {
                        userAccount = new UserAccount() {
                            userId = reader.GetInt32(reader.GetOrdinal("userId")),
                            username = reader.GetString(reader.GetOrdinal("username")),
                            password = reader.GetString(reader.GetOrdinal("password")),
                            role = reader.GetString(reader.GetOrdinal("name"))
                        };
                    }
                }
            }
            catch (SqlException error) {
                throw error;
            }

            conn.Close();

            return userAccount;
        }

        protected Student SelectSingleStudent(SqlCommand cmd) {
            Student student = new Student();



            try {
                connectDB();
                conn.Open();
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable schemaTable = reader.GetSchemaTable();


                while (reader.Read()) {
                    foreach (DataRow row in schemaTable.Rows) {
                        student = new Student() {
                            id = reader.GetInt32(reader.GetOrdinal("studentId")),
                            firstName = reader.GetString(reader.GetOrdinal("firstName")),
                            lastName = reader.GetString(reader.GetOrdinal("lastName")),
                            email = reader.GetString(reader.GetOrdinal("email")),
                            birthDate = reader.GetDateTime(reader.GetOrdinal("birthDate"))
                        };
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException error) {
                throw error;
            }
            this.conn.Close();
            return student;
        }

        protected List<Course> SelectCourseByStudentId(SqlCommand cmd) {
            Course course = new Course();
            List<Course> courseList = new List<Course>();

                try {
                connectDB();
                conn.Open();
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable schemaTable = reader.GetSchemaTable();


                while (reader.Read()) {
                    foreach (DataRow row in schemaTable.Rows) {
                        course = new Course() {
                            id = reader.GetInt32(reader.GetOrdinal("courseId")),
                            name = reader.GetString(reader.GetOrdinal("name")),
                            courseCode = reader.GetString(reader.GetOrdinal("courseCode")),
                            credits = reader.GetInt32(reader.GetOrdinal("credits")),
                            schoolYear = reader.GetInt32(reader.GetOrdinal("schoolYear")),
                            blockPeriod = reader.GetInt32(reader.GetOrdinal("blockPeriod"))
                        };
                    }
                    courseList.Add(course);
                }
            }
            catch (System.Data.SqlClient.SqlException error) {
                throw error;
            }
            this.conn.Close();
            return courseList;
        }

        protected List<Course> SelectAllCourses(SqlCommand cmd) {
            Course course = new Course();
            List<Course> courseList = new List<Course>();

            try {
                connectDB();
                conn.Open();
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable schemaTable = reader.GetSchemaTable();


                while (reader.Read()) {
                    foreach (DataRow row in schemaTable.Rows) {
                        course = new Course() {
                            id = reader.GetInt32(reader.GetOrdinal("courseId")),
                            name = reader.GetString(reader.GetOrdinal("name")),
                            courseCode = reader.GetString(reader.GetOrdinal("courseCode")),
                            credits = reader.GetInt32(reader.GetOrdinal("credits")),
                            schoolYear = reader.GetInt32(reader.GetOrdinal("schoolYear")),
                            blockPeriod = reader.GetInt32(reader.GetOrdinal("blockPeriod"))
                        };
                    }

                    courseList.Add(course);
                }
            }
            catch (System.Data.SqlClient.SqlException error) {
                throw error;
            }
            this.conn.Close();
            return courseList;
        }

        protected DataTable allCoursesForGrid(SqlCommand cmd) {
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            sda.SelectCommand = cmd;
            sda.SelectCommand.Connection = connectDB();
            sda.Fill(dt);
            return dt;
        }

        #endregion

            #region Update

            #endregion

            #region Delete

            #endregion

        }
}