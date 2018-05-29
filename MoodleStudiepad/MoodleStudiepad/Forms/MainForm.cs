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
    }
}
