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
    }
}
