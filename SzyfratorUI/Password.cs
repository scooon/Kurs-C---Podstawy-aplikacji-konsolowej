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
        public Password()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string haslo = "szyfr";
            if (PasswordBox.Text == haslo)
            {




                DialogResult result = MessageBox.Show("Witaj!", "Witaj! Logowanie przebiegło pomyślnie!");
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    Szyfrator mainWindow = new Szyfrator();
                    mainWindow.Show();
                    //this.Close();
                }

            }
            else
            {

                DialogResult result = MessageBox.Show("Hasło nieprawidłowe!", "Logowanie nieudane :(");

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }

            }
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            PasswordBox.PasswordChar = '*';
            PasswordBox.MaxLength = 32;
            PasswordBox.TextAlign = HorizontalAlignment.Center;
        }
    }
}
