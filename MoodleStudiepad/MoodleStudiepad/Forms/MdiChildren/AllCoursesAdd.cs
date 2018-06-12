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
    public partial class AllCoursesAdd : Form {
        private AllCourses form;
        public AllCoursesAdd(AllCourses form) {
            InitializeComponent();
            this.form = form;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            Course course = new Course() {
                name = tbCourseName.Text,
                courseCode = tbCourseCode.Text,
                schoolYear = Int32.Parse(tbSchoolYear.Text),
                blockPeriod = Int32.Parse(tbBlockPeriod.Text),
                credits = Int32.Parse(tbCredits.Text)
            };

            AddCourse addCourse = new AddCourse();
            if (!addCourse.addCourse(course)) {
                MessageBox.Show("Something went wrong please try again!", "Error", MessageBoxButtons.OK);
            }

            form.refreshListview();
        }
    }
}
