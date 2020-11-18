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
        public PasswordBox()
        {
            InitializeComponent();
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "test")
            {
                Console.WriteLine("Zalogowano!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Błędne hasło!", "Wpisane hasło jest nieprawidłowe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void PasswordBox_Load(object sender, EventArgs e)
        {

        }
    }
}
