using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoodleStudiepad.BU;
using MoodleStudiepad.CC;
using MoodleStudiepad.DAL;

namespace MoodleStudiepad.Forms.MdiChildren {
    public partial class AllCourses : Form {
        public AllCourses() {
            InitializeComponent();

            SeeStudentOverview seeStudentOverview = new SeeStudentOverview();
            dGV_Courses.DataSource = seeStudentOverview.getAllCoursesForGrid();
        }
    }
}
