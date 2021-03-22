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
    public partial class Password : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        private string haslo = "";
        public Password()
        {
            InitializeComponent();
        }

        public string getPassword()
        {
            return haslo;
        }

        private void login_Click(object sender, EventArgs e)
        {
            haslo = PasswordBox.Text;
            this.Close();
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordBox.PasswordChar = '*';
            PasswordBox.TextAlign = HorizontalAlignment.Center;
        }

        private void Password_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Password_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Password_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
            label2.Cursor = Cursors.Hand;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DarkOrange;
            label2.Cursor = Cursors.Arrow;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
