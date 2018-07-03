using System;
using System.Collections.Generic;
using MoodleStudiepad.DAL;

namespace MoodleStudiepad.BU {
    public class Student {
        public int id;
        public string firstName;
        public string lastName;
        public string email;
        public DateTime birthDate;

        /// <summary>
        /// This method requires a user id in order to get a user object from the database.
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>Returns a student object.</returns>
        public Student getSingleStudent(int id) {
            QueryStrings queryStrings = new QueryStrings();
            Student singleStudent = queryStrings.getSingleStudentById(id);
            return singleStudent;
        }
    }
}