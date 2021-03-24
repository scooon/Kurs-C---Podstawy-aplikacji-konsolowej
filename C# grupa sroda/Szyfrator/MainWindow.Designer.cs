namespace Szyfrator
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.title = new System.Windows.Forms.Label();
            this.OpenButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.passwordsDataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiddenPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.Location = new System.Drawing.Point(416, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(124, 33);
            this.title.TabIndex = 0;
            this.title.Text = "Szyfrator";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OpenButton
            // 
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.Location = new System.Drawing.Point(29, 65);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(96, 39);
            this.OpenButton.TabIndex = 2;
            this.OpenButton.Text = "Otwórz";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(29, 155);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(96, 39);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // passwordsDataGridView
            // 
            this.passwordsDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.passwordsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.passwordsDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.passwordsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.passwordsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.passwordsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.passwordsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.passwordsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.passwordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passwordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Login,
            this.Email,
            this.Password_Column,
            this.hiddenPwd,
            this.Notes});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.passwordsDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.passwordsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.passwordsDataGridView.EnableHeadersVisualStyles = false;
            this.passwordsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.passwordsDataGridView.Location = new System.Drawing.Point(163, 65);
            this.passwordsDataGridView.Name = "passwordsDataGridView";
            this.passwordsDataGridView.RowHeadersVisible = false;
            this.passwordsDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.passwordsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.passwordsDataGridView.Size = new System.Drawing.Size(785, 326);
            this.passwordsDataGridView.TabIndex = 6;
            this.passwordsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.passwordsDataGridView_CellClick);
            this.passwordsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.passwordsDataGridView_CellContentClick);
            this.passwordsDataGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.passwordsDataGridView_CellMouseLeave);
            this.passwordsDataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.passwordsDataGridView_CellMouseUp);
            // 
            // ID
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ID.DefaultCellStyle = dataGridViewCellStyle3;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Nazwa";
            this.Name.Name = "Name";
            // 
            // Login
            // 
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            // 
            // Email
            // 
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            // 
            // Password_Column
            // 
            this.Password_Column.HeaderText = "Hasło";
            this.Password_Column.Name = "Password_Column";
            // 
            // hiddenPwd
            // 
            this.hiddenPwd.HeaderText = "hiddenPwd";
            this.hiddenPwd.Name = "hiddenPwd";
            this.hiddenPwd.Visible = false;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notatki";
            this.Notes.Name = "Notes";
            // 
            // add
            // 
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Location = new System.Drawing.Point(29, 110);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(96, 39);
            this.add.TabIndex = 7;
            this.add.Text = "Dodaj";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(29, 200);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(96, 39);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Usuń";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CloseButton.Location = new System.Drawing.Point(965, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Padding = new System.Windows.Forms.Padding(5);
            this.CloseButton.Size = new System.Drawing.Size(32, 32);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "X";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.CloseButton.MouseHover += new System.EventHandler(this.CloseButton_MouseHover);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1000, 519);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.add);
            this.Controls.Add(this.passwordsDataGridView);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.title);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Szyfrator.Properties.Settings.Default, "Szyfrator", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Text = global::Szyfrator.Properties.Settings.Default.Szyfrator;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.passwordsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView passwordsDataGridView;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiddenPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.Label CloseButton;
    }
}

