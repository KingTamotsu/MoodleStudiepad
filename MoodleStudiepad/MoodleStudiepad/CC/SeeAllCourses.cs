using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodleStudiepad.BU;

namespace MoodleStudiepad.CC {
    public class SeeAllCourses {
        /// <summary>
        /// This method requires no data and is a trigger for getting all existing courses.
        /// </summary>
        /// <returns>Returns a list of Course objects.</returns>
        public List<Course> allCourses() {
            Course course = new Course();
            List<Course> allCourses = course.allCourses();
            return allCourses;
        }
    }
}
