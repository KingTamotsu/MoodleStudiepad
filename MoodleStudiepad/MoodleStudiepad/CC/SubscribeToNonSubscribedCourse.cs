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
        public List<Course> getNonSubscribedCourses(int id) {
            Course course = new Course();
            List<Course> allCourses = course.getNonSubscribedCourses(id);
            return allCourses;
        }

        public bool subscribeToNonSubscribedCourse(int courseId, int studentId) {
            Course course = new Course();
            return course.subscribeToNonSubscribedCourse(courseId, studentId);
        }
    }
}
