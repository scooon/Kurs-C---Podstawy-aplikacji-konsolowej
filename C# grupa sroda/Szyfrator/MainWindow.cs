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

        string content, path;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OpenButton_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "Pliki Szyfratora (*.szyfrator)|*.szyfrator|Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    path = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        content = reader.ReadToEnd();
                    }
                    tekst.Text = deszyfruj(content);

                }
            }



        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            byte[] byteArray = Encoding.UTF8.GetBytes(szyfruj(tekst.Text));
            
            Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.Filter = "Pliki Szyfratora (*.szyfrator)|*.szyfrator|Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    myStream.Write(byteArray, 0, byteArray.Length);
                    myStream.Close();
                }
            }
        }

        private void Szyfruj_Click(object sender, EventArgs e)
        {
            // Encrypting/decrypting strings
            //byte[] key = Bytes.GenerateKey();


            //byte[] iv = Bytes.GenerateIV();



            
            
        }


        string deszyfruj(string zaszyfrowane)
        {
            try
            {
                return Strings.Decrypt(zaszyfrowane, key, iv);
            }
            catch(Exception)
            {
                MessageBox.Show("Błąd! To nie jest plik programu Szyfrator", "Szyfrator - Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Błąd! To nie jest plik programu Szyfrator";
            }
        }

        string szyfruj(string odszyfrowane)
        {
            try
            {
                return Strings.Encrypt(odszyfrowane, key, iv);
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd zapisu!", "Szyfrator - Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Błąd zapisu!";

            }
        }

    }
}
