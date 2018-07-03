using System.Collections.Generic;
using System.Data;
using MoodleStudiepad.BU;
using MoodleStudiepad.DAL;

namespace MoodleStudiepad.CC {
    public class SeeStudentOverview {
        /// <summary>
        /// This method requires a user id and send it to the business layer.
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>Returns a single student object.</returns>
        public Student getSingleStudent(int id) {
            Student student = new Student();
            Student singleStudent = student.getSingleStudent(id);
            return singleStudent;
        }

        /// <summary>
        /// This method requires a user id and send it to the business layer.
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>Returns a list of courses done by the student.</returns>
        public List<Course> courseByStudent(int id) {
            Course course = new Course();
            List<Course> coursesByStudent = course.coursesByStudent(id);
            return coursesByStudent;
        }
    }
}