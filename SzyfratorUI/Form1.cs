
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
using Newtonsoft.Json;

namespace SzyfratorUI
{
    public partial class Szyfrator : Form
    {
        byte[] key = new byte[] { 18, 1, 62, 248, 116, 173, 190, 231, 129, 217, 29, 198, 214, 198, 110, 37, 137, 10, 7, 10, 224, 107, 20, 147, 20, 17, 254, 231, 155, 38, 111, 6 };
        byte[] iv = new byte[] { 251, 206, 128, 185, 18, 70, 175, 117, 81, 51, 116, 212, 182, 23, 144, 197, 95, 225, 96, 78, 148, 122, 191, 90, 95, 232, 52, 104, 203, 11, 146, 72 };
        string fileContent = string.Empty;
        string filePath = string.Empty;
        List<Passwords> passwords;
        private Panel buttonPanel = new Panel();
        private Button addNewRowButton = new Button();
        private Button deleteRowButton = new Button();




        public Szyfrator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //byte[] key = Bytes.GenerateKey();
            //byte[] iv = Bytes.GenerateIV();



            try
            {


                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); ;
                    openFileDialog.Filter = "Pliki Szyfratora (*.szyfrator)|*.szyfrator|Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.Title = "Szyfrator - Otwórz plik";
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {

                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        //Read the contents of the file into a stream
                        var fileStream = openFileDialog.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();
                        }

                        Content.Text = Strings.Decrypt(fileContent, key, iv);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wybrany plik, nie jest plikiem programu Szyfrator!", "Niewłaściwy plik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            

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


            try
            {

                Stream myStream;


                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); ;
                saveFileDialog1.Filter = "Pliki Szyfratora (*.szyfrator)|*.szyfrator|Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.Title = "Szyfrator - Zapisz plik";
                saveFileDialog1.RestoreDirectory = true;

                byte[] buffer = Encoding.UTF8.GetBytes(Strings.Encrypt(Content.Text, key, iv));

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        myStream.Write(buffer, 0, buffer.Length);
                        myStream.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Problem z zapisem pliku!", "Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string json = "[{'index':0,'name':'Nazwa','login':'Test','password':'5fd7a17eee119039335adb07','email':'Test@gmail.com','notes':'Jakieś notatki'},{'index':1,'name':'Nazwa','login':'Test','password':'5fd7a17eec845a3bba6cc10c','email':'Test@gmail.com','notes':'Jakieś notatki'},{ 'index':2,'name':'Nazwa','login':'Test','password':'5fd7a17e22ab30886f105c9f','email':'Test@gmail.com','notes':'Jakieś notatki'},{ 'index':3,'name':'Nazwa','login':'Test','password':'5fd7a17e0befe84e2a1739b1','email':'Test@gmail.com','notes':'Jakieś notatki'},{'index':4,'name':'Nazwa','login':'Test','password':'5fd7a17eaca98a53fa8cbbdf','email':'Test@gmail.com','notes':'Jakieś notatki'},{'index':5,'name':'Nazwa','login':'Test','password':'5fd7a17e04b2bc3004e66621','email':'Test@gmail.com','notes':'Jakieś notatki'}]";
            passwords = JsonConvert.DeserializeObject<List<Passwords>>(json);

            string jsonout = JsonConvert.SerializeObject(passwords);

            Console.WriteLine(jsonout);

            SetupLayout();
            SetupDataGridView();

        }

        private void SetupLayout()
        {
            //this.Size = new Size(600, 500);

            addNewRowButton.Text = "Dodaj hasło";
            addNewRowButton.Location = new Point(10, 10);
            addNewRowButton.Click += new EventHandler(addNewRowButton_Click);

            deleteRowButton.Text = "Usuń hasło";
            deleteRowButton.Location = new Point(100, 10);
            deleteRowButton.Click += new EventHandler(deleteRowButton_Click);

            buttonPanel.Controls.Add(addNewRowButton);
            buttonPanel.Controls.Add(deleteRowButton);
            buttonPanel.Height = 50;
            buttonPanel.Dock = DockStyle.Bottom;

            //this.Controls.Add(this.buttonPanel);
            dataGridView1.Controls.Add(this.buttonPanel);
        }

        private void addNewRowButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add();
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0 &&
                this.dataGridView1.SelectedRows[0].Index !=
                this.dataGridView1.Rows.Count - 1)
            {
                this.dataGridView1.Rows.RemoveAt(
                    this.dataGridView1.SelectedRows[0].Index);
            }
        }


        private void SetupDataGridView()
        {
            //this.Controls.Add(dataGridView1);

            dataGridView1.ColumnCount = 7;

            dataGridView1.Name = "dataGridView1";
            //dataGridView1.Location = new Point(8, 8);
            //dataGridView1.Size = new Size(500, 250);
            dataGridView1.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Usługa";
            dataGridView1.Columns[2].Name = "Login";
            dataGridView1.Columns[3].Name = "Hasło";
            dataGridView1.Columns[4].Name = "HiddenPwd";
            dataGridView1.Columns[5].Name = "E-mail";
            dataGridView1.Columns[6].Name = "Notatki";

            dataGridView1.Columns[0].ReadOnly = true;
            //dataGridView1.Columns[4].Visible = false;

            dataGridView1.Columns[5].DefaultCellStyle.Font =
                new Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Italic);

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            //dataGridView1.Dock = DockStyle.Fill;

            dataGridView1.CellFormatting += new
                DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
        }

        private void dataGridView1_CellFormatting(object sender,
        System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void ShowPwd_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0 &&
                this.dataGridView1.SelectedRows[0].Index !=
                this.dataGridView1.Rows.Count - 1)
            {
                dataGridView1.Rows[this.dataGridView1.SelectedRows[0].Index].Cells[3].Value = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Console.WriteLine("Mouse Click");
        }

        private void dataGridView1_CellMouseLeave(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            Console.WriteLine("Mouse Leave");
            if (e != null)
            {
                if (this.dataGridView1.Columns[e.ColumnIndex].Name == "Hasło")
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        try
                        {
                            dataGridView1.Rows[e.RowIndex].Tag = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = new String('\u25CF', dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Length);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("{0} password problem.", e.Value.ToString());
                        }
                    }
                }
            }
        }
    }
}
