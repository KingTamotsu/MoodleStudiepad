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

namespace MoodleStudiepad
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (tbUsername.Text == "" && tbPassword.Text == "") {

                MessageBox.Show("Fill in all the fields"); 
                tbUsername.Focus();
            }
            else if (tbUsername.Text == "") {
                MessageBox.Show("Give a username");
                tbUsername.Focus();
            } else if ( tbPassword.Text == ""){
                MessageBox.Show("Give a password");
                tbPassword.Focus();
            
            }

            CheckUser checkUser = new CheckUser();
            checkUser.checkUserOnLogin(tbUsername.Text, tbPassword.Text);
        }
    }
}
