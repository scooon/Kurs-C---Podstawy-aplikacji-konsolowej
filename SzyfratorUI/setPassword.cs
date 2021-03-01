using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzyfratorUI
{
    public partial class setPassword : Form
    {
        public setPassword()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            NewPasswordTextbox.UseSystemPasswordChar = false;
            RepeatNewPasswordTextBox.UseSystemPasswordChar = false;
            button1.Text = "Ukryj hasła";
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            NewPasswordTextbox.UseSystemPasswordChar = true;
            RepeatNewPasswordTextBox.UseSystemPasswordChar = true;
            button1.Text = "Pokaż hasła";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            NewPasswordTextbox.UseSystemPasswordChar = true;
            RepeatNewPasswordTextBox.UseSystemPasswordChar = true;
            button1.Text = "Pokaż hasła";
        }

        private void AddPwd_Click(object sender, EventArgs e)
        {
            if (NewPasswordTextbox.Text != "")
            {
                if (NewPasswordTextbox.Text == RepeatNewPasswordTextBox.Text)
                {
                    if (NewPasswordTextbox.Text.Length > 7)
                    {
                        if (Szyfrator.setPassword(NewPasswordTextbox.Text))
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hasło jest za krótkie!", "Niekompletne dane!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Hasła różnią się od siebie!", "Niekompletne dane!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Podaj hasło!", "Niekompletne dane!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
