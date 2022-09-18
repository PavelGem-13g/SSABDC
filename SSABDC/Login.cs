using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSABDC
{
    public partial class Login : Form
    {
        private string login;
        private string password;
        public Login()
        {
            InitializeComponent();
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            login = loginTextBox.Text;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            password = passwordTextBox.Text;
        }

        private void loginButtonForm_Click(object sender, EventArgs e)
        {
            if(login == "admin" && password == "admin") 
            {
                Form1.instance.SetLevel(2);
                Form1.instance.SetUserName("admin");
                Form1.instance.UpdateFiles();
            }
            else 
            { 
                Form1.instance.SetUserName("User: ");
            }
        }
    }
}
