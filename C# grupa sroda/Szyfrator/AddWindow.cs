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
    public partial class AddWindow : Form
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        private void ShowPwd_Click(object sender, EventArgs e)
        {
            /*PasswordTextBox.UseSystemPasswordChar = !PasswordTextBox.UseSystemPasswordChar;

            if (PasswordTextBox.UseSystemPasswordChar)
            {
                ShowPwd.Text = "Pokaż hasło";
            }
            else
            {
                ShowPwd.Text = "Ukryj hasło";
            }*/
        }

        private void ShowPwd_MouseDown(object sender, MouseEventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = false;
            ShowPwd.Text = "Ukryj hasło";
        }

        private void ShowPwd_MouseUp(object sender, MouseEventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
            ShowPwd.Text = "Pokaż hasło";
        }
    }
}
