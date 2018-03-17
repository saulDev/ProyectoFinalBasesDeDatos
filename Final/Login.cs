using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Login : Form
    {
        protected string userName = "rinku";
        protected string passwrod = "123";

        public Login()
        {
            InitializeComponent();
        }

        private void btbLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPwd.Text;

            bool authenticated = check_UserPassworMatch(user, password);

            if (authenticated)
            {
                MessageBox.Show("Bienvenido.");
                Girls girlsWindow = new Girls();
                girlsWindow.Show();
            }
            else
                MessageBox.Show("Password o usuario incorrectos.");
        }

        private bool check_UserPassworMatch(string user, string password)
        {
            if (user == "rinku" && password == "123")
            {
                return true;
            }
            return false;
        }
    }
}
