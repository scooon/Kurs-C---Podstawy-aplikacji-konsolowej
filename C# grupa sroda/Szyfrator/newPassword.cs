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
    public partial class newPassword : Form
    {
        public newPassword()
        {
            InitializeComponent();
        }

        private void newPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            if (newPasswordTextbox.Text.Length > 6)
            {
                passwordStrong.Value = 100;
            }
            else
            {
                passwordStrong.Value = (100 / 6) * newPasswordTextbox.Text.Length;
            }
        }

        private void showPwd_MouseDown(object sender, MouseEventArgs e)
        {
            newPasswordTextbox.UseSystemPasswordChar = false;
            repeatNewPasswordTextbox.UseSystemPasswordChar = false;
            showPwd.Text = "Ukryj hasło";
        }

        private void showPwd_MouseUp(object sender, MouseEventArgs e)
        {
            newPasswordTextbox.UseSystemPasswordChar = true;
            repeatNewPasswordTextbox.UseSystemPasswordChar = true;
            showPwd.Text = "Pokaż hasło";
        }

        private void showPwd_MouseLeave(object sender, EventArgs e)
        {
            newPasswordTextbox.UseSystemPasswordChar = true;
            repeatNewPasswordTextbox.UseSystemPasswordChar = true;
            showPwd.Text = "Pokaż hasło";
        }
    }
}
