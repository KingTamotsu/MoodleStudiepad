using System;
using System.Collections.Generic;
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

        #endregion
    }
}
