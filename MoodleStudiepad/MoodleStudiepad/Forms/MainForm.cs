using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoodleStudiepad.GUI {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            Login loginForm = new Login();
            loginForm.Show();
        }

        #region MdiChildren
        /// <summary>
        /// Mdi child form testing. Follow this template to create more mdi children. Stored child forms are in Forms/MdiChildren/.
        /// You should rename mdiDebuggingForm to the child's name.
        /// </summary>
        private void debug1ToolStripMenuItem_Click(object sender, EventArgs e)                              // Start method by clicking on the toolstrip button
        {                                                                                                   //
            Forms.MdiChildren.MdiDebuggingForm mdiDebuggingForm = new Forms.MdiChildren.MdiDebuggingForm(); // Make new instance of the form MdiDebuggingForm.cs
            mdiDebuggingForm.MdiParent = this;                                                              // Set parent form to this form (MainForm.cs)
            mdiDebuggingForm.Show();                                                                        // Show the child form
        }                                                                                                   //
        #endregion
    }
}
