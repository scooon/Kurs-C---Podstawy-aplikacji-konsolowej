using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szyfrator
{
    public partial class PasswordBox : Form
    {
        private static string pass = "";
        public PasswordBox()
        {
            InitializeComponent();
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            pass = passwordTextBox.Text;
            this.Close();
        }

        public static string getPassword()
        {
            return pass;
        }

        private void PasswordBox_Load(object sender, EventArgs e)
        {

        }
    }
}
