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
        /// This method requires a id of the user and send it to the Business Layer.
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>Returns a list of courses that the user has not yet followed.</returns>
        public List<Course> getNonSubscribedCourses(int id) {
            Course course = new Course();
            List<Course> allCourses = course.getNonSubscribedCourses(id);
            return allCourses;
        }

        /// <summary>
        /// This method requires a courseId and a studentId and send it to the Business Layer.
        /// </summary>
        /// <param name="courseId">The course Id</param>
        /// <param name="studentId">The student Id</param>
        /// <returns>Returns a bool wetter it succeed or not.</returns>
        public bool subscribeToNonSubscribedCourse(int courseId, int studentId) {
            Course course = new Course();
            return course.subscribeToNonSubscribedCourse(courseId, studentId);
        }
    }
}
