using System;
using System.Collections.Generic;
using MoodleStudiepad.DAL;

namespace MoodleStudiepad.BU {
    public class Student {
        #region Properties
        public int id;
        public string firstName;
        public string lastName;
        public string email;
        public DateTime birthDate;


        #endregion

        public Student() {

        }

        #region methods

        public void register() {

        }

        public Student getSingleStudent(int id) {
            QueryStrings queryStrings = new QueryStrings();
            Student singleStudent = queryStrings.getSingleStudentById(id);
            return singleStudent;
        }
        #endregion
    }
}