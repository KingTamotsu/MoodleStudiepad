using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodleStudiepad.BU;

namespace MoodleStudiepad.CC {
    public class AddCourse {
        /// <summary>
        /// This method requires a newCourse object and sends it to the business layer.
        /// </summary>
        /// <param name="newCourse">Course Object</param>
        /// <returns>Returns a bool whether it succeeded or not.</returns>
        public bool addCourse(Course newCourse) {
            Course course = new Course();
            return course.addCourse(newCourse);
        }
    }
}
