using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing.Text;
using MoodleStudiepad.BU;

namespace MoodleStudiepad.DAL {
    public class DBConnection {
        protected SqlConnection conn;

        public SqlConnection connectDB() {
            string connectionString = @"Data Source=moodlestudiepad.database.windows.net;" +
                                   "Initial Catalog=MoodleStudiepad;" + "User id=moodleadmin;" +
                                   "Password=#studiepad01;";
            conn = new SqlConnection(connectionString);
            return conn;
        }

        #region Get

        public UserAccount SelectSingleUser(SqlCommand cmd) {
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

        public Student SelectSingleStudent(SqlCommand cmd) {
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

        public List<Course> SelectCourseByStudentId(SqlCommand cmd) {
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
                            courseId = reader.GetInt32(reader.GetOrdinal("courseId")),
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

        public List<Course> SelectAllCourses(SqlCommand cmd) {
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
                            courseId = reader.GetInt32(reader.GetOrdinal("courseId")),
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

        public List<PrestationIndicator> SelectPrestationIndicators(SqlCommand cmd)
        {
            PrestationIndicator prestationIndicator = new PrestationIndicator();
            List<PrestationIndicator> piList = new List<PrestationIndicator>();

            try
            {
                connectDB();
                conn.Open();
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable schemaTable = reader.GetSchemaTable();


                while (reader.Read())
                {
                    foreach (DataRow row in schemaTable.Rows)
                    {
                        prestationIndicator = new PrestationIndicator()
                        {
                            studentId = reader.GetInt32(reader.GetOrdinal("studentId")),
                            courseId = reader.GetInt32(reader.GetOrdinal("courseId")),
                            piCode = reader.GetInt32(reader.GetOrdinal("piCode")),
                            grade = reader.GetDecimal(reader.GetOrdinal("grade"))
                        };
                    }

                    piList.Add(prestationIndicator);
                }
            }
            catch (System.Data.SqlClient.SqlException error)
            {
                throw error;
            }
            this.conn.Close();
            return piList;
        }

        public List<PrestationIndicator> SelectAverageGrades(SqlCommand cmd)
        {
            PrestationIndicator prestationIndicator = new PrestationIndicator();
            List<PrestationIndicator> gradeList = new List<PrestationIndicator>();

            try
            {
                connectDB();
                conn.Open();
                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable schemaTable = reader.GetSchemaTable();


                while (reader.Read())
                {
                    foreach (DataRow row in schemaTable.Rows)
                    {
                        prestationIndicator = new PrestationIndicator()
                        {
                            courseId = reader.GetInt32(reader.GetOrdinal("courseId")),
                            avgGrade = reader.GetDecimal(reader.GetOrdinal("avgGrade"))
                        };
                    }
                    // Remove excessive zeroes
                    string zeroLess = prestationIndicator.avgGrade.ToString("N1");
                    prestationIndicator.avgGrade = Decimal.Parse(zeroLess);
                    gradeList.Add(prestationIndicator);
                }
            }
            catch (System.Data.SqlClient.SqlException error)
            {
                throw error;
            }
            this.conn.Close();
            return gradeList;
        }

        public List<Course> getNonSubscribedCourses(SqlCommand cmd) {
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
                            courseId = reader.GetInt32(reader.GetOrdinal("courseId")),
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

        #endregion

        #region Add
        //Dit word maar 1 method genaamt execute die je kunt gebruiken voor alle classes om objecten toe te voegen.
        public bool execute(SqlCommand cmd) {
            bool successfulEdit;

            try {
                connectDB();
                conn.Open();
                cmd.Connection = conn;
                if (cmd.ExecuteNonQuery() > 0) {
                    successfulEdit = true;
                }
                else {
                    successfulEdit = false;
                }
            }
            catch (SqlException error) {
                throw error;
            }

            conn.Close();
            return successfulEdit;
        }

        #endregion

        #region Update

        public bool editCourse(SqlCommand cmd) {

            bool successfulEdit;

            try {
                connectDB();
                conn.Open();
                cmd.Connection = conn;
                if (cmd.ExecuteNonQuery() > 0) {
                    successfulEdit = true;
                }
                else {
                    successfulEdit = false;
                }
            }
            catch (SqlException error) {
                throw error;
            }

            conn.Close();
            return successfulEdit;
        }

        #endregion

        #region Delete

        #endregion

    }
}