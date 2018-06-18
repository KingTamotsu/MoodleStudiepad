using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MoodleStudiepad.DAL;

namespace MoodleStudiepad.BU
{
    public class Course {
        public int courseId;
        public string name;
        public string courseCode;
        public int schoolYear;
        public int blockPeriod;
        public int credits;
        private bool successfulEdit;


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

        public List<Course> getNonSubscribedCourses(int id) {
            QueryStrings queryStrings = new QueryStrings();
            List<Course> allCourses = queryStrings.getNonSubscribedCourses(id);
            return allCourses;
        }

        public bool addCourse(Course course) {
            QueryStrings queryStrings = new QueryStrings();
            string data = course.courseCode + "','" + course.name + "','" + course.schoolYear + "','" + course.blockPeriod + "','" + course.credits;
            return queryStrings.addCourse(course, data);
        }

        public bool editCourse(Course course) {
            QueryStrings queryStrings = new QueryStrings();
            successfulEdit = queryStrings.editCourse(course);

            if (successfulEdit) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
