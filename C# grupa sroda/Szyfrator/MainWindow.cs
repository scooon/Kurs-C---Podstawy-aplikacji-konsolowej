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

        private Panel buttonPanel = new Panel();
        //private DataGridView passwordsDataGridView = new DataGridView();
        private Button addNewRowButton = new Button();
        private Button deleteRowButton = new Button();

        public MainWindow()
        {
            InitializeComponent();
            SetupLayout();
            SetupDataGridView();
            PopulateDataGridView();
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

        private void passwordsDataGridView_CellFormatting(object sender,
        System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (e != null)
            {
                if (this.passwordsDataGridView.Columns[e.ColumnIndex].Name == "Release Date")
                {
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = DateTime.Parse(e.Value.ToString())
                                .ToLongDateString();
                            e.FormattingApplied = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("{0} is not a valid date.", e.Value.ToString());
                        }
                    }
                }
            }
        }

        private void addNewRowButton_Click(object sender, EventArgs e)
        {
            this.passwordsDataGridView.Rows.Add();
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            if (this.passwordsDataGridView.SelectedRows.Count > 0 &&
                this.passwordsDataGridView.SelectedRows[0].Index !=
                this.passwordsDataGridView.Rows.Count - 1)
            {
                this.passwordsDataGridView.Rows.RemoveAt(
                    this.passwordsDataGridView.SelectedRows[0].Index);
            }
        }

        private void SetupLayout()
        {
            //this.Size = new Size(600, 500);

            addNewRowButton.Text = "Add Row";
            addNewRowButton.Location = new Point(10, 10);
            addNewRowButton.Click += new EventHandler(addNewRowButton_Click);

            deleteRowButton.Text = "Delete Row";
            deleteRowButton.Location = new Point(100, 10);
            deleteRowButton.Click += new EventHandler(deleteRowButton_Click);

            buttonPanel.Controls.Add(addNewRowButton);
            buttonPanel.Controls.Add(deleteRowButton);
            buttonPanel.Height = 50;
            buttonPanel.Dock = DockStyle.Bottom;

            this.Controls.Add(this.buttonPanel);
        }

        private void SetupDataGridView()
        {
            //this.Controls.Add(passwordsDataGridView);

            passwordsDataGridView.ColumnCount = 7;

            passwordsDataGridView.Name = "passwordsDataGridView";
            //passwordsDataGridView.Location = new Point(8, 8);
            //passwordsDataGridView.Size = new Size(500, 250);
            passwordsDataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            passwordsDataGridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            passwordsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            
            passwordsDataGridView.RowHeadersVisible = false;

            passwordsDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            passwordsDataGridView.MultiSelect = false;
            passwordsDataGridView.Dock = DockStyle.None;

            passwordsDataGridView.CellFormatting += new
                DataGridViewCellFormattingEventHandler(
                passwordsDataGridView_CellFormatting);
        }

        private void passwordsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e != null) && (e.RowIndex >= 0))
            {
                if (passwordsDataGridView.Rows[e.RowIndex].Cells[5].Value != null)
                {
                    passwordsDataGridView.Rows[e.RowIndex].Cells[4].Value = passwordsDataGridView.Rows[e.RowIndex].Cells[5].Value;
                    Console.WriteLine(passwordsDataGridView.Rows[e.RowIndex].Cells[4].Value);

                }
            }
        }

        private void passwordsDataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void passwordsDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if ((e != null) && (e.RowIndex >= 0))
            {
                if (passwordsDataGridView.Rows[e.RowIndex].Cells[4].Value != null)
                {
                    if (!passwordsDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString().Contains('\u25CF'))
                    {
                        passwordsDataGridView.Rows[e.RowIndex].Cells[5].Value = passwordsDataGridView.Rows[e.RowIndex].Cells[4].Value;
                        passwordsDataGridView.Rows[e.RowIndex].Cells[4].Value = new String('\u25CF', passwordsDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString().Length);
                        Console.WriteLine(passwordsDataGridView.Rows[e.RowIndex].Cells[5].Value);

                    }
                }
            }
        }

        private void PopulateDataGridView()
        {

            string[] row0 = { "11/22/1968", "29", "Revolution 9",
            "Beatles", "The Beatles [White Album]" };
            string[] row1 = { "1960", "6", "Fools Rush In",
            "Frank Sinatra", "Nice 'N' Easy" };
            string[] row2 = { "11/11/1971", "1", "One of These Days",
            "Pink Floyd", "Meddle" };
            string[] row3 = { "1988", "7", "Where Is My Mind?",
            "Pixies", "Surfer Rosa" };
            string[] row4 = { "5/1981", "9", "Can't Find My Mind",
            "Cramps", "Psychedelic Jungle" };
            string[] row5 = { "6/10/2003", "13",
            "Scatterbrain. (As Dead As Leaves.)",
            "Radiohead", "Hail to the Thief" };
            string[] row6 = { "6/30/1992", "3", "Dress", "P J Harvey", "Dry" };

            passwordsDataGridView.Rows.Add(row0);
            passwordsDataGridView.Rows.Add(row1);
            passwordsDataGridView.Rows.Add(row2);
            passwordsDataGridView.Rows.Add(row3);
            passwordsDataGridView.Rows.Add(row4);
            passwordsDataGridView.Rows.Add(row5);
            passwordsDataGridView.Rows.Add(row6);

        }

    }
}
