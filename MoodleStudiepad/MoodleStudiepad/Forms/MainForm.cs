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
using MoodleStudiepad.Forms.MdiChildren;

namespace MoodleStudiepad.GUI {
    public partial class MainForm : Form {
        private int userId;
        private int roleId;
        public MainForm(int id, string username, int roleId) {
            InitializeComponent();
            lblName.Text = username;
            userId = id;
            roleId = 1;
            this.roleId = roleId;
            checkRoleId();
        }


        public void checkRoleId() {
            if (roleId != 1) {
                studieToolStripMenuItem.Visible = false;
                resultatenToolStripMenuItem.Visible = false;
                personalToolStripMenuItem.Visible = false;
            }
            if (roleId != 2) {
                
            }
            if (roleId != 3) {
                tempToolStripMenuItem.Visible = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            Login loginForm = new Login();
            loginForm.Show();
        }

        #region Toolstrip Buttons                                                                                                 //

        private void overzichtOnderwijseenhedenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubscribedCourseOverview mdiSubscribedCourseOverview = new SubscribedCourseOverview();
            mdiSubscribedCourseOverview.MdiParent = this;
            mdiSubscribedCourseOverview.Show();
        }

        /// <summary>
        /// Log out button. Shows a pop-up first with a yes/no if the user wants to log out.
        /// </summary>
        private void logOut2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var logoutConfirmation = MessageBox.Show("Are you sure you want to log out?", "Log out?", MessageBoxButtons.YesNo);
            if (logoutConfirmation == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tempToolStripMenuItem_Click(object sender, EventArgs e) {
            AllCourses allCourses = new AllCourses();
            allCourses.MdiParent = this;
            allCourses.Show();
        }

        private void pIToolStripMenuItem_Click(object sender, EventArgs e) {
            PrestationIndicatorOverview mdiPrestationIndicatorOverview = new PrestationIndicatorOverview();
            mdiPrestationIndicatorOverview.MdiParent = this;
            mdiPrestationIndicatorOverview.Show();
        }

        private void eCToolStripMenuItem_Click(object sender, EventArgs e) {
            CreditOverview mdiCreditOverview = new CreditOverview();
            mdiCreditOverview.MdiParent = this;
            mdiCreditOverview.Show();
        }
        #endregion

        private void inschrijvenToolStripMenuItem_Click(object sender, EventArgs e) {
            SubscribeToCourse mdiSubscribeToCourse = new SubscribeToCourse(userId);
            mdiSubscribeToCourse.MdiParent = this;
            mdiSubscribeToCourse.Show();
        }
    }
}
