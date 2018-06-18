using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodleStudiepad.BU;

namespace MoodleStudiepad.DAL {
    public class QueryStrings {
        DBConnection dbConnection = new DBConnection();

        #region SelectQuerries

        public UserAccount selectSingleUser(string username) {
            UserAccount readerList = dbConnection.SelectSingleUser(new SqlCommand("Select * FROM UserAccount INNER JOIN Roles ON UserAccount.roleId = Roles.roleId" + " Where Username = '" + username + "'"));
            return readerList;
        }

        public Student getSingleStudentById( int id) {
            Student readerList = dbConnection.SelectSingleStudent(new SqlCommand(
                "SELECT stu.*, cou.courseCode, cou.name FROM Student stu, Course cou INNER JOIN StudentCourse sc1 ON studentId = sc1.studentId WHERE stu.studentId = sc1.studentId AND cou.courseId = sc1.courseId AND stu.studentId = " + id + " Order BY stu.studentId;"));
            return readerList;
        }

        public List<Course> getCouresesbyStudentId(int id) {
            List<Course> readerList = dbConnection.SelectCourseByStudentId(new SqlCommand("SELECT cou.* FROM Student stu, Course cou INNER JOIN StudentCourse sc1 ON studentId = sc1.studentId WHERE stu.studentId = sc1.studentId AND cou.courseId = sc1.courseId AND stu.studentId = " + id + "Order BY cou.courseId;"));
            return readerList;
        }

        public List<Course> getAllCourses() {
            List<Course> readerList = dbConnection.SelectAllCourses(new SqlCommand("Select * FROM Course"));
            return readerList;
        }

        // Get pi by student id
        public List<PrestationIndicator> getPrestationIndicatorsById(int id)
        {
            List<PrestationIndicator> readerList = dbConnection.SelectPrestationIndicators(new SqlCommand("SELECT stu.studentId, cou.courseId, pre.piCode, pre.grade FROM Student stu, Course cou, PrestationIndicator pre INNER JOIN StudentCourse sc1 ON sc1.studentId = sc1.studentId WHERE stu.studentId = sc1.studentId AND cou.courseId = sc1.courseId AND stu.studentId = " + id + " AND stu.studentId = pre.studentId AND cou.courseId = pre.courseId ORDER BY stu.studentId;"));
            return readerList;
        }

        public List<PrestationIndicator> getAverageGradeById(int id)
        {
            List<PrestationIndicator> readerList = dbConnection.SelectAverageGrades(new SqlCommand("SELECT cou.courseId, ROUND(SUM(pre.grade*pre.weight)/SUM(pre.weight), 1) AS avgGrade FROM Student stu, Course cou, PrestationIndicator pre WHERE stu.studentId = pre.studentId AND cou.courseId = pre.courseId AND stu.studentId = " + id + " GROUP BY cou.courseId ORDER BY cou.courseId"));
            return readerList;
        }

        // Get avg. grade by student id
        // SELECT stu.studentId, stu.firstName, stu.lastName, pre.courseId, cou.name, (SUM(pre.grade*pre.weight)/SUM(pre.weight))AS avgGrade FROM Student stu, Course cou, PrestationIndicator pre WHERE stu.studentId = pre.studentId AND cou.courseId = pre.courseId AND stu.studentId = '2' GROUP BY stu.studentId, stu.firstName, stu.lastName, cou.name, pre.courseId ORDER BY pre.courseId

        // Get past courses
        // SELECT stu.studentId, stu.firstName, stu.lastName, cou.courseCode, cou.name FROM Student stu, Course cou, PreviousCourse pco INNER JOIN StudentCourse sc1 ON sc1.studentId = sc1.studentId WHERE stu.studentId = sc1.studentId AND cou.courseId = sc1.courseId AND stu.studentId = '2' AND stu.studentId = pco.studentId AND cou.courseId = pco.courseId ORDER BY stu.studentId;

        // Get passed courses
        // SELECT stu.studentId, stu.firstName, stu.lastName, cou.courseCode, cou.name, pco.passed FROM Student stu, Course cou, PreviousCourse pco INNER JOIN StudentCourse sc1 ON sc1.studentId = sc1.studentId WHERE stu.studentId = sc1.studentId AND cou.courseId = sc1.courseId AND stu.studentId = '2' AND stu.studentId = pco.studentId AND cou.courseId = pco.courseId ORDER BY stu.studentId;

        // Get inactive courses
        //SELECT DISTINCT cou.* FROM Student stu, Course cou INNER JOIN StudentCourse sco ON cou.courseId = sco.courseId WHERE stu.studentId = sco.studentId AND sco.courseId NOT IN(SELECT cou.courseId FROM Course cou INNER JOIN StudentCourse sco ON cou.courseId = sco.courseId WHERE sco.studentId = 3)
        #endregion

        #region Add

        public bool addCourse(Course course, string data) {
            return dbConnection.execute(new SqlCommand("INSERT into Course (courseCode, name , schoolYear, blockPeriod, credits) VALUES ('" + data + "')"));
        }

        #endregion

        #region Update

        public bool editCourse(Course course) {
            return dbConnection.editCourse(new SqlCommand("UPDATE Course SET courseCode = '"+ course.courseCode + "' , name ='" + course.name + "', schoolYear = " + course.schoolYear + ", blockPeriod = " + course.blockPeriod + ", credits = " + course.credits + " WHERE courseId = " + course.courseId +";"));
        }



        #endregion
    }
}
