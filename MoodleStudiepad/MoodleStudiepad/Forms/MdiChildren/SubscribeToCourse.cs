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
    public partial class SubscribeToCourse : Form {

        public List<Course> allCourses = new List<Course>();
        private int id;
        public SubscribeToCourse(int id) {
            InitializeComponent();
            //this.id = id;
            fillListCheckbox();
            this.id = 3;
        }

        public void fillListCheckbox() {
            SubscribeToNonSubscribedCourse subscribeToCourse = new CC.SubscribeToNonSubscribedCourse();
            allCourses = subscribeToCourse.getNonSubscribedCourses(id);

            foreach (Course course in allCourses) {
                string courseCode = course.courseCode;
                string courseName = course.name;

                string completeCourse = string.Join(" ",courseCode, courseName);

                cLBNonSubscribedCoureses.Items.Add(completeCourse);
            }
        }

        private void btnSubscribe_Click(object sender, EventArgs e) {
            SubscribeToNonSubscribedCourse subscribeToNonSubscribedCourse = new SubscribeToNonSubscribedCourse();
            subscribeToNonSubscribedCourse.subscribeToNonSubscribedCourse(
                allCourses[cLBNonSubscribedCoureses.SelectedIndex].courseId, id);
            cLBNonSubscribedCoureses.Items.Clear();
            fillListCheckbox();
        }

        private void cLBNonSubscribedCoureses_ItemCheck(object sender, ItemCheckEventArgs e) {
            for (int ix = 0; ix < cLBNonSubscribedCoureses.Items.Count; ++ix)
                if (ix != e.Index) cLBNonSubscribedCoureses.SetItemChecked(ix, false);
        }
    }
}
