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
        private bool mouseDown;
        private Point lastLocation;
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

        private void PasswordBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void PasswordBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void PasswordBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
