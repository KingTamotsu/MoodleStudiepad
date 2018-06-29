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
            this.roleId = roleId;
            checkRoleId();
        }

        public void checkRoleId() {

            eCToolStripMenuItem.Visible = false;
            overzichtOnderwijseenhedenToolStripMenuItem.Visible = false;
            uitschrijvenToolStripMenuItem.Visible = false;
            personalToolStripMenuItem.Visible = false;

            if (roleId != 1) {
                studieToolStripMenuItem.Visible = false;
                resultatenToolStripMenuItem.Visible = false;
            }
            if (roleId != 3) {
                tempToolStripMenuItem.Visible = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void inschrijvenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubscribeToCourse mdiSubscribeToCourse = new SubscribeToCourse(userId);
            mdiSubscribeToCourse.MdiParent = this;
            mdiSubscribeToCourse.Show();
        }

        #region Toolstrip Buttons

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

        #region Mouseover colours
        private bool studieDropdown = false;
        private bool resultDropdown = false;

        private void logOut2ToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            logOut2ToolStripMenuItem.ForeColor = Color.Black;
        }

        private void logOut2ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            logOut2ToolStripMenuItem.ForeColor = Color.White;
        }

        private void studieToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            if (!studieDropdown)
            {
                studieToolStripMenuItem.ForeColor = Color.Black;
            }
        }

        private void studieToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (!studieDropdown)
            {
                studieToolStripMenuItem.ForeColor = Color.White;
            }
        }

        private void studieToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            studieDropdown = true;
            studieToolStripMenuItem.ForeColor = Color.Black;
        }

        private void studieToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            studieDropdown = false;
            studieToolStripMenuItem.ForeColor = Color.White;
        }

        private void resultatenToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            if (!resultDropdown)
            {
                resultatenToolStripMenuItem.ForeColor = Color.Black;
            }
        }

        private void resultatenToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (!resultDropdown)
            {
                resultatenToolStripMenuItem.ForeColor = Color.White;
            }
        }

        private void resultatenToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            resultDropdown = true;
            resultatenToolStripMenuItem.ForeColor = Color.Black;
        }

        private void resultatenToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            resultDropdown = false;
            resultatenToolStripMenuItem.ForeColor = Color.White;
        }

        private void overzichtOnderwijseenhedenToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            overzichtOnderwijseenhedenToolStripMenuItem.ForeColor = Color.Black;
        }

        private void overzichtOnderwijseenhedenToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            overzichtOnderwijseenhedenToolStripMenuItem.ForeColor = Color.White;
        }

        private void inschrijvenToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            inschrijvenToolStripMenuItem.ForeColor = Color.Black;
        }

        private void inschrijvenToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            inschrijvenToolStripMenuItem.ForeColor = Color.White;
        }

        private void uitschrijvenToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            uitschrijvenToolStripMenuItem.ForeColor = Color.Black;
        }

        private void uitschrijvenToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            uitschrijvenToolStripMenuItem.ForeColor = Color.White;
        }

        private void pIToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            pIToolStripMenuItem.ForeColor = Color.Black;
        }

        private void pIToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            pIToolStripMenuItem.ForeColor = Color.White;
        }

        private void eCToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            eCToolStripMenuItem.ForeColor = Color.Black;
        }

        private void eCToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            eCToolStripMenuItem.ForeColor = Color.White;
        }

        private void personalToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            personalToolStripMenuItem.ForeColor = Color.Black;
        }

        private void personalToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            personalToolStripMenuItem.ForeColor = Color.White;
        }

        private void tempToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            tempToolStripMenuItem.ForeColor = Color.Black;
        }

        private void tempToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            tempToolStripMenuItem.ForeColor = Color.White;
        }
        #endregion
    }
}
