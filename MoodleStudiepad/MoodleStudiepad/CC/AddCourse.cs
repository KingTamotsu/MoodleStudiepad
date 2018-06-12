using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodleStudiepad.BU;

namespace MoodleStudiepad.CC {
    public class AddCourse {
        public bool addCourse(Course newCourse) {
            Course course = new Course();
            return course.addCourse(newCourse);
        }
    }
}
