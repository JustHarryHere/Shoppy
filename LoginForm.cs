using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoppy
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            User Userforsession = new User(1, "test", "test");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = Authenticate(UserName.Text, Password.Text);
            if (user != null)
            {
                MessageBox.Show("Login Successful");
                Form1 mainForm = new Form1(user);
                mainForm.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }



        void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        public static User Authenticate(string username, string password)
        {
            MessageBox.Show("Authenticating user: " + username);
            var users = JsonManager.OpenNormalUsersFromJson("data\\users.json");
            var admins = JsonManager.OpenAdminsFromJson("data\\admins.json");
            var user = users.FirstOrDefault(u => u.Username == username);
            if (user != null && VerifyPassword(password, user))
            {
                return user;
            }
            var admin = admins.FirstOrDefault(a => a.Username == username);
            if (admin != null && VerifyPassword(password, admin))
            {
                return admin;
            }
            MessageBox.Show("User not found or incorect password");
            return null;
        }

        private static bool VerifyPassword(string enteredPassword, User user)
        {
            if(user.Password == enteredPassword)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Incorrect Password");
                return false;
            }
        }
    }
}
