using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoodleStudiepad.BU;
using MoodleStudiepad.CC;
using MoodleStudiepad.DAL;

namespace MoodleStudiepad.Forms.MdiChildren {
    public partial class AllCourses : Form {
        SeeAllCourses seeAllCourses = new SeeAllCourses();
        List<Course> temp = new List<Course>();

        //Contructor
        public AllCourses() {
            InitializeComponent();
            createListview();
            fillListview();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AllCoursesAdd allCoursedAdd = new AllCoursesAdd(this);
            allCoursedAdd.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            var x = listView1.SelectedItems[0];
            Course course = new Course();
            course.courseId = Int32.Parse(x.SubItems[0].Text);
            course.name = x.SubItems[1].Text;
            course.courseCode = x.SubItems[2].Text;
            course.schoolYear = Int32.Parse(x.SubItems[3].Text);
            course.blockPeriod = Int32.Parse(x.SubItems[4].Text);
            course.credits = Int32.Parse(x.SubItems[5].Text);


            AllCoursesEdit allCoursesEdit = new AllCoursesEdit(course, this);
            allCoursesEdit.Show();
        }

        public void createListview() {
            // Set the view to show details.
            listView1.View = View.Details;
            listView1.LabelEdit = false;
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            // Allow the user to edit item text.
            listView1.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;

            listView1.Columns.Add("courseId");
            listView1.Columns.Add("name");
            listView1.Columns.Add("courseCode");
            listView1.Columns.Add("schoolYear");
            listView1.Columns.Add("blockPeriod");
            listView1.Columns.Add("credits");
        }
        public void fillListview() {
            temp = seeAllCourses.allCourses();


            foreach (Course item in temp) {
                listView1.Items.Add(new ListViewItem(new string[] { item.courseId.ToString(), item.name, item.courseCode, item.schoolYear.ToString(), item.blockPeriod.ToString(), item.credits.ToString() }));


            }
        }
        public void refreshListview() {
            listView1.Items.Clear();
            temp.Clear();
            fillListview();
            listView1.Refresh();
        }

        
    }
}
