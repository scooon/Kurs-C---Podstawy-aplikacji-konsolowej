using Effortless.Net.Encryption;
using Newtonsoft.Json;
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

        List<Password> passwords = new List<Password>();

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
            string json = JsonConvert.SerializeObject(passwords);
            byte[] byteArray = Encoding.UTF8.GetBytes(szyfruj(json));
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            string json = "[{'id':0,'name':'Nazwa','login':'Test','password':'5fda49edd6b82aabb37e2925','email':'Test@gmail.com','notes':'Jakieś notatki'},{'id':1,'name':'Nazwa','login':'Test','password':'5fda49eda7d62eb642d6d5ac','email':'Test@gmail.com','notes':'Jakieś notatki'},{'id':2,'name':'Nazwa','login':'Test','password':'5fda49eddefaac2371438b74','email':'Test@gmail.com','notes':'Jakieś notatki'},{'id':3,'name':'Nazwa','login':'Test','password':'5fda49edc16c2b741bcb0df5','email':'Test@gmail.com','notes':'Jakieś notatki'},{'id':4,'name':'Nazwa','login':'Test','password':'5fda49ed9d8b2e57be1dd37c','email':'Test@gmail.com','notes':'Jakieś notatki'},{'id':5,'name':'Nazwa','login':'Test','password':'5fda49edf1e39babf724fbe5','email':'Test@gmail.com','notes':'Jakieś notatki'}]";
            //List<Password> passwords = JsonConvert.DeserializeObject<List<Password>>(json);
            //Console.WriteLine(passwords[2].password);

            string json2 = JsonConvert.SerializeObject(passwords);

            //Console.WriteLine(json2);
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
