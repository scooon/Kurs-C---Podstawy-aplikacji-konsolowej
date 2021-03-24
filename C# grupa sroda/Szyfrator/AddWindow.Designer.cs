namespace Szyfrator
{
    partial class AddWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWindow));
            this.Addbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nazwaUslugiTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EMailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.ShowPwd = new System.Windows.Forms.Button();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.notes = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Addbutton
            // 
            this.Addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbutton.ForeColor = System.Drawing.Color.DarkOrange;
            this.Addbutton.Location = new System.Drawing.Point(24, 363);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(339, 43);
            this.Addbutton.TabIndex = 0;
            this.Addbutton.Text = "Dodaj hasło";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa usługi:";
            // 
            // nazwaUslugiTextBox
            // 
            this.nazwaUslugiTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.nazwaUslugiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nazwaUslugiTextBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.nazwaUslugiTextBox.Location = new System.Drawing.Point(24, 49);
            this.nazwaUslugiTextBox.Name = "nazwaUslugiTextBox";
            this.nazwaUslugiTextBox.Size = new System.Drawing.Size(339, 22);
            this.nazwaUslugiTextBox.TabIndex = 2;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginTextBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.LoginTextBox.Location = new System.Drawing.Point(24, 98);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(339, 22);
            this.LoginTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login:";
            // 
            // EMailTextBox
            // 
            this.EMailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.EMailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EMailTextBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.EMailTextBox.Location = new System.Drawing.Point(24, 147);
            this.EMailTextBox.Name = "EMailTextBox";
            this.EMailTextBox.Size = new System.Drawing.Size(339, 22);
            this.EMailTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(21, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-Mail:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.PasswordTextBox.Location = new System.Drawing.Point(24, 196);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(339, 22);
            this.PasswordTextBox.TabIndex = 8;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.DarkOrange;
            this.password.Location = new System.Drawing.Point(21, 172);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(54, 21);
            this.password.TabIndex = 7;
            this.password.Text = "Hasło:";
            // 
            // ShowPwd
            // 
            this.ShowPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPwd.ForeColor = System.Drawing.Color.DarkOrange;
            this.ShowPwd.Location = new System.Drawing.Point(25, 233);
            this.ShowPwd.Name = "ShowPwd";
            this.ShowPwd.Size = new System.Drawing.Size(339, 27);
            this.ShowPwd.TabIndex = 9;
            this.ShowPwd.Text = "Pokaż hasło";
            this.ShowPwd.UseVisualStyleBackColor = true;
            this.ShowPwd.Click += new System.EventHandler(this.ShowPwd_Click);
            this.ShowPwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPwd_MouseDown);
            this.ShowPwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPwd_MouseUp);
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.NotesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotesTextBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.NotesTextBox.Location = new System.Drawing.Point(24, 298);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(339, 45);
            this.NotesTextBox.TabIndex = 11;
            // 
            // notes
            // 
            this.notes.AutoSize = true;
            this.notes.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes.ForeColor = System.Drawing.Color.DarkOrange;
            this.notes.Location = new System.Drawing.Point(21, 274);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(68, 21);
            this.notes.TabIndex = 10;
            this.notes.Text = "Notatki:";
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CloseButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.CloseButton.Location = new System.Drawing.Point(354, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Padding = new System.Windows.Forms.Padding(5);
            this.CloseButton.Size = new System.Drawing.Size(32, 32);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "X";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.CloseButton.MouseHover += new System.EventHandler(this.CloseButton_MouseHover);
            // 
            // AddWindow
            // 
            this.AcceptButton = this.Addbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(390, 418);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.ShowPwd);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.EMailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nazwaUslugiTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Addbutton);
            this.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddWindow";
            this.Text = "AddWindow";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddWindow_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazwaUslugiTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EMailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button ShowPwd;
        private System.Windows.Forms.TextBox NotesTextBox;
        private System.Windows.Forms.Label notes;
        private System.Windows.Forms.Label CloseButton;
    }
}