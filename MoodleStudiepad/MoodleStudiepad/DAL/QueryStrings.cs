using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodleStudiepad.BU;

namespace MoodleStudiepad.DAL {
    public class QueryStrings: DBConnection {


        #region SelectQuerries

        public UserAccount selectSingleUser(string username) {
            UserAccount readerList = SelectSingleUser(new SqlCommand("Select * FROM UserAccount INNER JOIN Roles ON UserAccount.roleId = Roles.roleId" + " Where Username = '" + username + "'", base.conn));
            return readerList;
        }

        public Student getSingleStudentById( int id) {
            Student readerList = SelectSingleStudent(new SqlCommand(
                "SELECT stu.*, cou.courseCode, cou.name FROM Student stu, Course cou INNER JOIN StudentCourse sc1 ON studentId = sc1.studentId WHERE stu.studentId = sc1.studentId AND cou.courseId = sc1.courseId AND stu.studentId = " + id + " Order BY stu.studentId;",
                base.conn));
            return readerList;
        }

        public List<Course> getCouresesbyStudentId(int id) {
            List<Course> readerList = SelectCourseByStudentId(new SqlCommand("SELECT cou.* FROM Student stu, Course cou INNER JOIN StudentCourse sc1 ON studentId = sc1.studentId WHERE stu.studentId = sc1.studentId AND cou.courseId = sc1.courseId AND stu.studentId = " + id + "Order BY cou.courseId;", base.conn));
            return readerList;
        }

        public List<Course> getAllCourses() {
            List<Course> readerList = SelectAllCourses(new SqlCommand("Select * FROM Course"));
            return readerList;
        }

        // Get pi by student id
        // SELECT stu.studentId, stu.firstName, stu.lastName, cou.courseCode, cou.name, pre.piCode, pre.grade FROM Student stu, Course cou, PrestationIndicator pre INNER JOIN StudentCourse sc1 ON sc1.studentId = sc1.studentId WHERE stu.studentId = sc1.studentId AND cou.courseId = sc1.courseId AND stu.studentId = '2' AND stu.studentId = pre.studentId AND cou.courseId = pre.courseId ORDER BY stu.studentId;

        // Get avg. grade by student id
        // SELECT stu.studentId, stu.firstName, stu.lastName, pre.courseId, cou.name, (SUM(pre.grade*pre.weight)/SUM(pre.weight))AS avgGrade FROM Student stu, Course cou, PrestationIndicator pre WHERE stu.studentId = pre.studentId AND cou.courseId = pre.courseId AND stu.studentId = '2' GROUP BY stu.studentId, stu.firstName, stu.lastName, cou.name, pre.courseId ORDER BY pre.courseId
        
        // Get past modules
        // SELECT stu.studentId, stu.firstName, stu.lastName, cou.courseCode, cou.name FROM Student stu, Course cou, PreviousCourse pco INNER JOIN StudentCourse sc1 ON sc1.studentId = sc1.studentId WHERE stu.studentId = sc1.studentId AND cou.courseId = sc1.courseId AND stu.studentId = '2' AND stu.studentId = pco.studentId AND cou.courseId = pco.courseId ORDER BY stu.studentId;

        // Get passed modules
        // SELECT stu.studentId, stu.firstName, stu.lastName, cou.courseCode, cou.name, pco.passed FROM Student stu, Course cou, PreviousCourse pco INNER JOIN StudentCourse sc1 ON sc1.studentId = sc1.studentId WHERE stu.studentId = sc1.studentId AND cou.courseId = sc1.courseId AND stu.studentId = '2' AND stu.studentId = pco.studentId AND cou.courseId = pco.courseId ORDER BY stu.studentId;

        #endregion

        #region Update

        //UPDATE Course SET courseCode = 'A1A1000', name= 'Weet ik veel', schoolYear= 2, blockPeriod= 2, credits= 100 WHERE courseId = 1;


        #endregion
    }
}
