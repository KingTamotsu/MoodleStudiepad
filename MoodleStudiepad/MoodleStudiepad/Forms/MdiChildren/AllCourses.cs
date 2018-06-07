using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoodleStudiepad.BU;
using MoodleStudiepad.CC;

namespace MoodleStudiepad.Forms.MdiChildren {
    public partial class AllCourses : Form {
        public AllCourses() {
            InitializeComponent();
            SeeAllCourses seeAllCourses = new SeeAllCourses();
            dGV_Courses.ColumnCount = 6;


            dGV_Courses.DataSource = seeAllCourses.allCourses();
            dGV_Courses.Columns[0].Name = "courseId";
            dGV_Courses.Columns[0].DataPropertyName = "courseId";
            dGV_Courses.Columns[1].Name = "courseCode";
            dGV_Courses.Columns[2].Name = "name";
            dGV_Courses.Columns[3].Name = "schoolYear";
            dGV_Courses.Columns[4].Name = "blockPeriod";
            dGV_Courses.Columns[5].Name = "credits";
            dGV_Courses.Refresh();

        }
    }
}
