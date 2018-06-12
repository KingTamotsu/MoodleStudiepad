using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodleStudiepad.BU;

namespace MoodleStudiepad.CC
{
    class SeePrestationIndicators
    {
        //public List<Course> allCourses()
        //{
        //    Course course = new Course();
        //    List<Course> allCourses = course.allCourses();
        //    return allCourses;
        //}

        public List<PrestationIndicator> getPrestationIndicators(int id)
        {
            PrestationIndicator prestationIndicator = new PrestationIndicator();
            List<PrestationIndicator> piList = prestationIndicator.getPrestationIndicators(id);
            return piList;
        }
    }
}
