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
        Passwords item = new Passwords();
        public AddPassword()
        {
            InitializeComponent();
            
        }

        private void AddPwd_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                item.name = service_textbox.Text;
                item.login = login_textbox.Text;
                item.password = haslo_textbox.Text;
                item.email = email_textbox.Text;
                item.notes = notatki_textbox.Text;
                
            }
            catch (Exception)
            {

                MessageBox.Show("Dodawanie nie powiodło się.");
            }
        }

        private void showPwd_Click(object sender, EventArgs e)
        {
            if(haslo_textbox.PasswordChar == '\u25CF')
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
            }
        }
    }
}
