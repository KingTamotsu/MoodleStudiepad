using System.Collections.Generic;
using System.Data;
using MoodleStudiepad.BU;
using MoodleStudiepad.DAL;

namespace MoodleStudiepad.CC {
    public class SeeStudentOverview {
        public Student getSingleStudent(int id) {
            Student student = new Student();
            Student singleStudent = student.getSingleStudent(id);
            return singleStudent;
        }

        public List<Course> courseByStudent(int id) {
            Course course = new Course();
            List<Course> coursesByStudent = course.coursesByStudent(id);
            return coursesByStudent;
        }

        public DataTable getAllCoursesForGrid() {
            Course course = new Course();
            DataTable allCourses = course.getAllCoursesForGrid();
            return allCourses;
        }
    }
}