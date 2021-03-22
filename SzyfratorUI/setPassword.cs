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
        private bool mouseDown;
        private Point lastLocation;
        public setPassword()
        {
            InitializeComponent();
            NewPasswordTextbox.UseSystemPasswordChar = true;
            RepeatNewPasswordTextBox.UseSystemPasswordChar = true;
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
                        if (Passwords.hashPassword(NewPasswordTextbox.Text))
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

        private void NewPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            if(NewPasswordTextbox.Text.Length <= 8)
            {
                progressBar1.Value = (NewPasswordTextbox.Text.Length * 100) / 8;
            }
            else
            {
                progressBar1.Value = 100;
            }
        }

        private void setPassword_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void setPassword_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void setPassword_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
            label5.Cursor = Cursors.Hand;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.DarkOrange;
            label5.Cursor = Cursors.Arrow;
        }
    }
}
