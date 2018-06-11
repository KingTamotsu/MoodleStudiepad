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

namespace MoodleStudiepad.Forms.MdiChildren {
    public partial class AllCoursesEdit : Form {
        public AllCoursesEdit(Course course) {
            InitializeComponent();
            lbCourseId.Text = course.courseId.ToString();
            tbCourseName.Text = course.name;
            tbCourseCode.Text = course.courseCode;
            tbSchoolYear.Text = course.schoolYear.ToString();
            tbBlockPeriod.Text = course.blockPeriod.ToString();
            tbCredits.Text = course.credits.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Course course = new Course() {
                courseId = Int32.Parse(lbCourseId.Text),
                name = tbCourseName.Text,
                courseCode = tbCourseCode.Text,
                schoolYear = Int32.Parse(tbSchoolYear.Text),
                blockPeriod = Int32.Parse(tbBlockPeriod.Text),
                credits = Int32.Parse(tbCredits.Text)
            };


        }
    }
}
