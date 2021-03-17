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

        int index = 0;

        private bool mouseDown;
        private Point lastLocation;

        public MainWindow()
        {
            InitializeComponent();
            SetupDataGridView();
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
                    string input = deszyfruj(content);
                    string pass = input.Substring(0, input.IndexOf("|password|"));
                    string json = input.Substring(input.IndexOf("|password|") + 10);
                    if (pass.Length > 0)
                    {
                        PasswordBox checkPwd = new PasswordBox();
                        checkPwd.Show();
                        checkPwd.FormClosed += delegate
                        {
                            if (Password.checkPassword(PasswordBox.getPassword(), pass))
                            {
                                Password.setPassword(pass);
                                passwords = JsonConvert.DeserializeObject<List<Password>>(json);
                                PopulateDataGridView(passwords);
                            }
                            else
                            {
                                MessageBox.Show("Złe hasło!", "Złe hasło!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            
                        };
                        
                    }
                }
            }



        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Password.getPassword() != "")
            {
                //byte[] byteArray = Encoding.UTF8.GetBytes(szyfruj(json));
                string json = Password.getPassword() + "|password|" + getData();
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
            passwords = JsonConvert.DeserializeObject<List<Password>>(json);


            PopulateDataGridView(passwords);

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
            index += 1;
            this.passwordsDataGridView.Rows.Add(index.ToString());
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            if (this.passwordsDataGridView.SelectedRows.Count > 0)
            {
                this.passwordsDataGridView.Rows.RemoveAt(
                    this.passwordsDataGridView.SelectedRows[0].Index);
            }
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
            unhidePwd(sender, e);
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

        private void unhidePwd(object sender, DataGridViewCellEventArgs e)
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

        private void passwordsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            unhidePwd(sender, e);
        }

        private void PopulateDataGridView(List<Password> passwords)
        {
            for (int i = 0; i < passwords.Count; i++)
            {
                index += 1;
                passwordsDataGridView.Rows.Add(index.ToString(), passwords[i].name, passwords[i].login, passwords[i].email, new String('\u25CF', passwords[i].password.Length), passwords[i].password, passwords[i].notes);
            }
            

        }

        private void add_Click(object sender, EventArgs e)
        {
            
            if (Password.getPassword() == "")
            {
                newPassword newPwd = new newPassword();
                newPwd.Show();
                newPwd.FormClosed += delegate
                {
                    Password.setHash(newPassword.getPassword());
                    if(Password.getPassword() != "")
                    {
                        addItem();
                    }
                };
            }
            else
            {
                addItem();
            }
            
        }

        private void addItem()
        {
            AddWindow add = new AddWindow();
            add.Show();
            add.FormClosed += delegate
            {
                if (add.newItem != null)
                {
                    index += 1;
                    passwordsDataGridView.Rows.Add(index.ToString(), add.newItem.name, add.newItem.login, add.newItem.email, new String('\u25CF', add.newItem.password.Length), add.newItem.password, add.newItem.notes);
                }
                //MessageBox.Show("subForm has closed");
            };
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.passwordsDataGridView.SelectedRows.Count > 0)
            {
                this.passwordsDataGridView.Rows.RemoveAt(
                    this.passwordsDataGridView.SelectedRows[0].Index);
            }
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        string getData()
        {
            List<Password> data = new List<Password>();

            for (int i = 0; i < passwordsDataGridView.Rows.Count; i++)
            {
                if (passwordsDataGridView.Rows[i] != null)
                {
                    Password item = new Password();

                    if(passwordsDataGridView.Rows[i].Cells[0].Value != null)
                    {
                        item.id = Convert.ToInt32(passwordsDataGridView.Rows[i].Cells[0].Value);
                    }
                    else
                    {
                        item.id = 0;
                    }

                    if (passwordsDataGridView.Rows[i].Cells[1].Value != null)
                    {
                        item.name = passwordsDataGridView.Rows[i].Cells[1].Value.ToString();
                    }
                    else
                    {
                        item.name = "";
                    }
                    if (passwordsDataGridView.Rows[i].Cells[2].Value != null)
                    {
                        item.login = passwordsDataGridView.Rows[i].Cells[2].Value.ToString();
                    }
                    else
                    {
                        item.login = "";
                    }
                    if (passwordsDataGridView.Rows[i].Cells[3].Value != null)
                    {
                        item.email = passwordsDataGridView.Rows[i].Cells[3].Value.ToString();
                    }
                    else
                    {
                        item.email = "";
                    }
                    if (passwordsDataGridView.Rows[i].Cells[5].Value != null)
                    {
                        item.password = passwordsDataGridView.Rows[i].Cells[5].Value.ToString();
                    }
                    else
                    {
                        item.password = "";
                    }
                    if (passwordsDataGridView.Rows[i].Cells[6].Value != null)
                    {
                        item.notes = passwordsDataGridView.Rows[i].Cells[6].Value.ToString();
                    }
                    else
                    {
                        item.notes = "";
                    }

                    data.Add(item);
                }
            }

            return JsonConvert.SerializeObject(data);
        }

    }
}
