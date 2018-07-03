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

        /// <summary>
        /// This method is used to setup the connection string.
        /// </summary>
        /// <returns>The connection string.</returns>
        public SqlConnection connectDB() {
            string connectionString = @"Data Source=moodlestudiepad.database.windows.net;" +
                                   "Initial Catalog=MoodleStudiepad;" + "User id=moodleadmin;" +
                                   "Password=#studiepad01;";
            conn = new SqlConnection(connectionString);
            return conn;
        }

        #region Get
        /// <summary>
        /// This methods gets a single user from the database.
        /// </summary>
        /// <param name="cmd">querystring</param>
        /// <returns>Returns a single user object.</returns>
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
                            roleId = reader.GetInt32(reader.GetOrdinal("roleId"))
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

        /// <summary>
        /// This method gets a single student from the database.
        /// </summary>
        /// <param name="cmd">querystring</param>
        /// <returns>Returns a single student object.</returns>
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

        /// <summary>
        /// This method gets all the courses a user is subscribed to.
        /// </summary>
        /// <param name="cmd">querystring</param>
        /// <returns>Returns a list of all the courses that a user is subscribed to.</returns>
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

        /// <summary>
        /// This method gets all the courses that exist in the database.
        /// </summary>
        /// <param name="cmd">querystring</param>
        /// <returns>Returns a list of all the existing courses.</returns>
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

        /// <summary>
        /// This method gets the prestation indicators from a single student.
        /// </summary>
        /// <param name="cmd">querystring</param>
        /// <returns>Returns a list of prestation indicators.</returns>
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

        /// <summary>
        /// This method gets all the average grades from the prestation indicators.
        /// </summary>
        /// <param name="cmd">querystring</param>
        /// <returns>Returns a list of grades from the prestation indicators.</returns>
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

        /// <summary>
        /// This method gets a list of courses the student is not subscribed to.
        /// </summary>
        /// <param name="cmd">querystring</param>
        /// <returns>Returns a list of non-subscribed courses.</returns>
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
        /// <summary>
        /// This method is used to add something to the database. It is a universal sql-query: it can add anything that is supported in the database.
        /// </summary>
        /// <param name="cmd">querystring</param>
        /// <returns>Returns a bool wetter it succeed or not.</returns>
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
        /// <summary>
        /// This method edits a course in the database.
        /// </summary>
        /// <param name="cmd">querystring</param>
        /// <returns>Returns a bool whether it succeed or not.</returns>
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
    }
}