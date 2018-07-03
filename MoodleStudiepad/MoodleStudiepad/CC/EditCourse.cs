using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodleStudiepad.BU;

namespace MoodleStudiepad.CC {
    public class EditCourse {
        /// <summary>
        /// This method requires a Course object and send it to the Business Layer.
        /// </summary>
        /// <param name="editedCourse">Course object</param>
        /// <returns>Returns a bool wetter it succeed or not.</returns>
        public bool editCourse(Course editedCourse) {
            Course course = new Course();
            return course.editCourse(editedCourse);
        }
    }
}
