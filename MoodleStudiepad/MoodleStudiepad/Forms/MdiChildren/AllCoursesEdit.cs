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
            tbCourseName.Text = course.name;
            tbCourseCode.Text = course.courseCode;
            tbSchoolYear.Text = course.schoolYear.ToString();
            tbBlockPeriod.Text = course.blockPeriod.ToString();
            tbCredits.Text = course.credits.ToString();
        }
    }
}
