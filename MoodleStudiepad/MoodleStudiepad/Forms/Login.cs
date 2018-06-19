using System;
using System.Windows.Forms;
using MoodleStudiepad.CC;
using MoodleStudiepad.GUI;

namespace MoodleStudiepad {
    public partial class Login : Form {
        private bool checkUser;

        public Login() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (tbUsername.Text == "" && tbPassword.Text == "") {
                MessageBox.Show("Fill in all the fields");
                tbUsername.Focus();
            } else if (tbUsername.Text == "") {
                MessageBox.Show("Give a username");
                tbUsername.Focus();
            } else if (tbPassword.Text == "") {
                MessageBox.Show("Give a password");
                tbPassword.Focus();
            } else if (tbUsername.Text.Length > 0 && tbPassword.Text.Length > 0) {
                CheckUser checkUsername = new CheckUser();
                checkUser = checkUsername.checkUserOnLogin(tbUsername.Text, tbPassword.Text);

                if (checkUser) {
                    CheckUser checkUser = new CheckUser();
                    int id = checkUser.returnUserId(tbUsername.Text);
                    string username = checkUser.returnUsername(tbUsername.Text);
                    int roleId = checkUser.returnRoleId(tbUsername.Text);
                    MessageBox.Show("You are succesfully logged in!");
                    MainForm mainForm = new MainForm(id, username, roleId);
                    mainForm.Show();
                    Hide();
                }
                else {
                    MessageBox.Show("Wrong username or password");
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}