namespace SzyfratorUI
{
    partial class AddPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPassword));
            this.AddPwd = new System.Windows.Forms.Button();
            this.service = new System.Windows.Forms.Label();
            this.service_textbox = new System.Windows.Forms.TextBox();
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.haslo_textbox = new System.Windows.Forms.TextBox();
            this.haslo = new System.Windows.Forms.Label();
            this.showPwd = new System.Windows.Forms.Button();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.notatki_textbox = new System.Windows.Forms.TextBox();
            this.notatki = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddPwd
            // 
            this.AddPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPwd.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPwd.Location = new System.Drawing.Point(12, 366);
            this.AddPwd.Name = "AddPwd";
            this.AddPwd.Size = new System.Drawing.Size(328, 39);
            this.AddPwd.TabIndex = 0;
            this.AddPwd.Text = "Dodaj hasło";
            this.AddPwd.UseVisualStyleBackColor = true;
            this.AddPwd.Click += new System.EventHandler(this.AddPwd_Click);
            // 
            // service
            // 
            this.service.AutoSize = true;
            this.service.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service.Location = new System.Drawing.Point(8, 9);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(113, 21);
            this.service.TabIndex = 1;
            this.service.Text = "Nazwa usługi:";
            // 
            // service_textbox
            // 
            this.service_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.service_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.service_textbox.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service_textbox.ForeColor = System.Drawing.Color.DarkOrange;
            this.service_textbox.Location = new System.Drawing.Point(12, 33);
            this.service_textbox.Name = "service_textbox";
            this.service_textbox.Size = new System.Drawing.Size(328, 20);
            this.service_textbox.TabIndex = 2;
            // 
            // login_textbox
            // 
            this.login_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.login_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_textbox.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_textbox.ForeColor = System.Drawing.Color.DarkOrange;
            this.login_textbox.Location = new System.Drawing.Point(12, 80);
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.Size = new System.Drawing.Size(328, 20);
            this.login_textbox.TabIndex = 4;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(8, 56);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(55, 21);
            this.login.TabIndex = 3;
            this.login.Text = "Login:";
            // 
            // haslo_textbox
            // 
            this.haslo_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.haslo_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.haslo_textbox.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haslo_textbox.ForeColor = System.Drawing.Color.DarkOrange;
            this.haslo_textbox.Location = new System.Drawing.Point(12, 127);
            this.haslo_textbox.Name = "haslo_textbox";
            this.haslo_textbox.Size = new System.Drawing.Size(328, 20);
            this.haslo_textbox.TabIndex = 6;
            this.haslo_textbox.UseSystemPasswordChar = true;
            // 
            // haslo
            // 
            this.haslo.AutoSize = true;
            this.haslo.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haslo.Location = new System.Drawing.Point(8, 103);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(54, 21);
            this.haslo.TabIndex = 5;
            this.haslo.Text = "Hasło:";
            // 
            // showPwd
            // 
            this.showPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPwd.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPwd.Location = new System.Drawing.Point(12, 162);
            this.showPwd.Name = "showPwd";
            this.showPwd.Size = new System.Drawing.Size(328, 25);
            this.showPwd.TabIndex = 7;
            this.showPwd.Text = "Pokaż hasło";
            this.showPwd.UseVisualStyleBackColor = true;
            this.showPwd.Click += new System.EventHandler(this.showPwd_Click);
            this.showPwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPwd_MouseDown);
            this.showPwd.MouseLeave += new System.EventHandler(this.showPwd_MouseLeave);
            this.showPwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showPwd_MouseUp);
            // 
            // email_textbox
            // 
            this.email_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.email_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_textbox.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_textbox.ForeColor = System.Drawing.Color.DarkOrange;
            this.email_textbox.Location = new System.Drawing.Point(14, 227);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(328, 20);
            this.email_textbox.TabIndex = 9;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(10, 203);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(60, 21);
            this.email.TabIndex = 8;
            this.email.Text = "E-Mail:";
            // 
            // notatki_textbox
            // 
            this.notatki_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.notatki_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notatki_textbox.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notatki_textbox.ForeColor = System.Drawing.Color.DarkOrange;
            this.notatki_textbox.Location = new System.Drawing.Point(14, 273);
            this.notatki_textbox.Multiline = true;
            this.notatki_textbox.Name = "notatki_textbox";
            this.notatki_textbox.Size = new System.Drawing.Size(328, 66);
            this.notatki_textbox.TabIndex = 11;
            // 
            // notatki
            // 
            this.notatki.AutoSize = true;
            this.notatki.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notatki.Location = new System.Drawing.Point(10, 249);
            this.notatki.Name = "notatki";
            this.notatki.Size = new System.Drawing.Size(68, 21);
            this.notatki.TabIndex = 10;
            this.notatki.Text = "Notatki:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // AddPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(352, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notatki_textbox);
            this.Controls.Add(this.notatki);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.email);
            this.Controls.Add(this.showPwd);
            this.Controls.Add(this.haslo_textbox);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.login_textbox);
            this.Controls.Add(this.login);
            this.Controls.Add(this.service_textbox);
            this.Controls.Add(this.service);
            this.Controls.Add(this.AddPwd);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPassword";
            this.Text = "AddPassword";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddPassword_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddPassword_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddPassword_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPwd;
        private System.Windows.Forms.Label service;
        private System.Windows.Forms.TextBox service_textbox;
        private System.Windows.Forms.TextBox login_textbox;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.TextBox haslo_textbox;
        private System.Windows.Forms.Label haslo;
        private System.Windows.Forms.Button showPwd;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox notatki_textbox;
        private System.Windows.Forms.Label notatki;
        private System.Windows.Forms.Label label1;
    }
}