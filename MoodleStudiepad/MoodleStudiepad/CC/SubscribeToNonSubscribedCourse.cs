using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodleStudiepad.BU;

namespace MoodleStudiepad.CC
{
    public class SubscribeToNonSubscribedCourse
    {
        /// <summary>
        /// This method requires a user id and send it to the business layer.
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>Returns a list of courses that the user has not yet followed.</returns>
        public List<Course> getNonSubscribedCourses(int id) {
            Course course = new Course();
            List<Course> allCourses = course.getNonSubscribedCourses(id);
            return allCourses;
        }

        /// <summary>
        /// This method requires a course id and a student id and send it to the business layer.
        /// </summary>
        /// <param name="courseId">The course Id</param>
        /// <param name="studentId">The student Id</param>
        /// <returns>Returns a bool whether it succeeded or not.</returns>
        public bool subscribeToNonSubscribedCourse(int courseId, int studentId) {
            Course course = new Course();
            return course.subscribeToNonSubscribedCourse(courseId, studentId);
        }
    }
}
