using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodleStudiepad.BU;

namespace MoodleStudiepad.CC {
    public class SeeAllCourses {
        public List<Course> allCourses() {
            Course course = new Course();
            List<Course> allCourses = course.allCourses();
            return allCourses;
        }
    }
}
