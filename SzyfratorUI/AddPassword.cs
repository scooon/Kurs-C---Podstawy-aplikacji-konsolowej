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
    public partial class AddPassword : Form
    {
        public Passwords item = new Passwords();

        private bool mouseDown;
        private Point lastLocation;
        public AddPassword()
        {
            InitializeComponent();
            
        }

        private void AddPwd_Click(object sender, EventArgs e)
        {
            try
            {

                if (service_textbox.Text == "")
                {
                    MessageBox.Show("Podaj nazwę usługi!", "Niekompletne dane!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (haslo_textbox.Text == "")
                {
                    MessageBox.Show("Podaj hasło!", "Niekompletne dane!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if ((email_textbox.Text != "") && (!email_textbox.Text.Contains('@')))
                {
                    MessageBox.Show("Podaj poprawny email!", "Niekompletne dane!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    item.name = service_textbox.Text;
                    item.login = login_textbox.Text;
                    item.password = haslo_textbox.Text;
                    item.email = email_textbox.Text;
                    item.notes = notatki_textbox.Text;
                    this.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Dodawanie nie powiodło się.");
            }
        }

        private void showPwd_Click(object sender, EventArgs e)
        {
            /*if(haslo_textbox.PasswordChar == '\u25CF')
            {
                haslo_textbox.PasswordChar = '\0';
            }
            else
            {
                haslo_textbox.PasswordChar = '\u25CF';
            }

            if(showPwd.Text == "Pokaż hasło")
            {
                showPwd.Text = "Ukryj hasło";
            }
            else
            {
                showPwd.Text = "Pokaż hasło";
            }*/
        }

        private void showPwd_MouseDown(object sender, MouseEventArgs e)
        {
            showPwd.Text = "Ukryj hasło";
            haslo_textbox.UseSystemPasswordChar = false;
        }

        private void showPwd_MouseUp(object sender, MouseEventArgs e)
        {
            showPwd.Text = "Pokaż hasło";
            haslo_textbox.UseSystemPasswordChar = true;
        }

        private void showPwd_MouseLeave(object sender, EventArgs e)
        {
            showPwd.Text = "Pokaż hasło";
            haslo_textbox.UseSystemPasswordChar = true;
        }

        private void AddPassword_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void AddPassword_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void AddPassword_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
            label1.Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.DarkOrange;
            label1.Cursor = Cursors.Arrow;
        }
    }
}
