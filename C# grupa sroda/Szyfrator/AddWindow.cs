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
        public Password newItem;
        private bool mouseDown;
        private Point lastLocation;

        public AddWindow()
        {
            InitializeComponent();
        }


        public void test()
        {

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

        private void Addbutton_Click(object sender, EventArgs e)
        {
            newItem = new Password();

            if(nazwaUslugiTextBox.Text == "")
            {
                MessageBox.Show("Podaj nazwę usługi!", "Niekompletne dane", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (LoginTextBox.Text == "")
            {
                MessageBox.Show("Podaj login!", "Niekompletne dane", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((EMailTextBox.Text == "") || (!EMailTextBox.Text.Contains('@')))
            {
                MessageBox.Show("Podaj prawidłowy e-mail!", "Niekompletne dane", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (PasswordTextBox.Text == "")
            {
                MessageBox.Show("Podaj hasło!", "Niekompletne dane", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                newItem.name = nazwaUslugiTextBox.Text;
                newItem.login = LoginTextBox.Text;
                newItem.email = EMailTextBox.Text;
                newItem.password = PasswordTextBox.Text;
                newItem.notes = NotesTextBox.Text;
                this.Close();
            }
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseHover(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
            CloseButton.Cursor = Cursors.Hand;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.DarkOrange;
            CloseButton.Cursor = Cursors.Arrow;
        }

        private void AddWindow_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void AddWindow_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void AddWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
    }
}
