using System;
using System.Collections.Generic;
using System.Text;
using MoodleStudiepad.DAL;

namespace MoodleStudiepad.BU
{
    public class Course {
        public int id;
        public string name;
        public string courseCode;
        public int credits;
        public int schoolYear;
        public int blockPeriod;



        public List<Course> coursesByStudent(int id) {
            QueryStrings queryStrings = new QueryStrings();
            List<Course> coursesByStudent = queryStrings.getCouresesbyStudentId(id);
            return coursesByStudent;
        }

        public List<Course> allCourses() {
            QueryStrings queryStrings = new QueryStrings();
            List<Course> allCourses = queryStrings.getAllCourses();
            return allCourses;
        }
    }
}
