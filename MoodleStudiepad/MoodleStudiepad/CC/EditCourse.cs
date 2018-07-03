using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodleStudiepad.BU;

namespace MoodleStudiepad.CC {
    public class EditCourse {
        /// <summary>
        /// This method requires a course object and sends it to the business layer.
        /// </summary>
        /// <param name="editedCourse">Course object</param>
        /// <returns>Returns a bool whether it succeeded or not.</returns>
        public bool editCourse(Course editedCourse) {
            Course course = new Course();
            return course.editCourse(editedCourse);
        }
    }
}
