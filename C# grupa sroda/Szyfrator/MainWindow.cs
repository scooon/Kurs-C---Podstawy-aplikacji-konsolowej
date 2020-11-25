using Effortless.Net.Encryption;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szyfrator
{
    public partial class MainWindow : Form
    {
        byte[] key = new byte[] { 17, 130, 130, 153, 33, 221, 125, 39, 153, 21, 70, 237, 221, 117, 119, 242, 67, 58, 49, 116, 182, 81, 134, 199, 214, 82, 99, 163, 47, 166, 137, 44 };
        byte[] iv = new byte[] { 250, 2, 75, 71, 151, 241, 49, 69, 47, 80, 146, 192, 48, 133, 25, 62, 199, 75, 214, 1, 169, 209, 127, 190, 254, 239, 77, 151, 30, 255, 236, 63 };


        public MainWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hej!", "Powitanie!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Szyfruj_Click(object sender, EventArgs e)
        {
            // Encrypting/decrypting strings
            //byte[] key = Bytes.GenerateKey();
            
            
            //byte[] iv = Bytes.GenerateIV();
            


            string encrypted = Strings.Encrypt(tekst.Text, key, iv);
            tekst.Text = encrypted;
            string decrypted = Strings.Decrypt(encrypted, key, iv);
        }

        

        
    }
}
