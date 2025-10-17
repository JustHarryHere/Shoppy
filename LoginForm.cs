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
            User user = Authenticate(username.Text, passwordTextBox.Text);
        }

        public static User Authenticate(string username, string password)
        {
            var users = JsonManager.OpenUsersFromJson("User.json");
            var user = users.FirstOrDefault(u => u.Username == username);
            if (user != null && VerifyPassword(password, user.Password))
            {
                return user;
            }
            return null;
        }

        private static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            // Replace with your hash verification logic
            return HashPassword(enteredPassword) == storedHash;
        }

        private static string HashPassword(string password)
        {
            using var sha = System.Security.Cryptography.SHA256.Create();
            var bytes = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }
}
