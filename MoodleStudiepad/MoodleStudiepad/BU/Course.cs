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

        /// <summary>
        /// This method requires a user id in order to get a list of courses that the student has completed.
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>Returns the list of courses completed by the student.</returns>
        public List<Course> coursesByStudent(int id) {
            QueryStrings queryStrings = new QueryStrings();
            List<Course> coursesByStudent = queryStrings.getCouresesbyStudentId(id);
            return coursesByStudent;
        }

         /// <summary>
         /// This method gets all existing courses.
         /// </summary>
         /// <returns>Returns a list of all courses.</returns>
        public List<Course> allCourses() {
            QueryStrings queryStrings = new QueryStrings();
            List<Course> allCourses = queryStrings.getAllCourses();
            return allCourses;
        }

        /// <summary>
        /// This method requires a user id and gets all courses that the user is not subscribed to.
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>Returns a list of the courses that the user is not subscribed to.</returns>
        public List<Course> getNonSubscribedCourses(int id) {
            QueryStrings queryStrings = new QueryStrings();
            List<Course> allCourses = queryStrings.getNonSubscribedCourses(id);
            return allCourses;
        }

        /// <summary>
        /// This method requires a course object to add a course entry to the database.
        /// </summary>
        /// <param name="course">The course object</param>
        /// <returns>Returns a bool whether it succeeded or not.</returns>
        public bool addCourse(Course course) {
            QueryStrings queryStrings = new QueryStrings();
            string data = course.courseCode + "','" + course.name + "','" + course.schoolYear + "','" + course.blockPeriod + "','" + course.credits;
            return queryStrings.addCourse(course, data);
        }

        /// <summary>
        /// This methods requires a course object to change a course entry in the database.
        /// </summary>
        /// <param name="course">The course object</param>
        /// <returns>Returns a bool whether it succeeded or not.</returns>
        public bool editCourse(Course course) {
            QueryStrings queryStrings = new QueryStrings();
            return successfulEdit = queryStrings.editCourse(course);
        }

        /// <summary>
        /// This method requires a course id and a student id to add a subscription entry to the database.
        /// </summary>
        /// <param name="courseId">The courseId</param>
        /// <param name="studentId">The studentId</param>
        /// <returns>Returns a bool whether it succeeded or not.</returns>
        public bool subscribeToNonSubscribedCourse(int courseId, int studentId) {
            QueryStrings queryStrings = new QueryStrings();
            return queryStrings.addStudentToCourse(courseId, studentId);
        }
    }
}
