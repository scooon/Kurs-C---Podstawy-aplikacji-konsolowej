
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Effortless.Net.Encryption;

namespace SzyfratorUI
{
    public partial class Szyfrator : Form
    {

        public Szyfrator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] key = Bytes.GenerateKey();
            byte[] iv = Bytes.GenerateIV();
            //byte[] key= new byte[] { 18, 1, 62, 248, 116, 173, 190, 231, 129, 217, 29, 198, 214, 198, 110, 37, 137, 10, 7, 10, 224, 107, 20, 147, 20, 17, 254, 231, 155, 38, 111, 6 };
            //byte[] iv = new byte[] { 251, 206, 128, 185, 18, 70, 175, 117, 81, 51, 116, 212, 182, 23, 144, 197, 95, 225, 96, 78, 148, 122, 191, 90, 95, 232, 52, 104, 203, 11, 146, 72 };

            for (int i = 0; i < 32; i++)
            {
                Console.Write(iv[i] + ",");
            }
            Console.WriteLine("}");

            string encrypted = Strings.Encrypt("Scooon", key, iv);
            string decrypted = Strings.Decrypt("xxWq9yQeCJYgGXY+2zB0QfJ0LyrOoAz6ho0YV6VGFmQ=", key, iv);
            Console.WriteLine(encrypted);
            Console.WriteLine(decrypted);

            /*string fileContent = string.Empty;
            string filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); ;
                openFileDialog.Filter = "Pliki Szyfratora (*.szyfrator)|*.szyfrator|Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Title = "Szyfrator - Otwórz plik";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    filePath = openFileDialog.FileName;


                    var fileStream = openFileDialog.OpenFile();

                    using (MemoryStream ms = new MemoryStream())
                    {
                        fileStream.CopyTo(ms);
                        deszyfruj(ms.ToArray());
                    }
                }
            }
            */
            //MessageBox.Show(fileContent, "Zawartość pliku: " + filePath, MessageBoxButtons.OK);


        }

        private void Szyfrator_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

   

            /*
            Stream myStream;

            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); ;
            saveFileDialog1.Filter = "Pliki Szyfratora (*.szyfrator)|*.szyfrator|Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.Title = "Szyfrator - Zapisz plik";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Write(buffer, 0, buffer.Length);
                    myStream.Close();
                }
            } */
        }

        



        
    }
}
