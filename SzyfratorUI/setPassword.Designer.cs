namespace SzyfratorUI
{
    partial class setPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.NewPasswordTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RepeatNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddPwd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ustaw nowe hasło";
            // 
            // NewPasswordTextbox
            // 
            this.NewPasswordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.NewPasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewPasswordTextbox.ForeColor = System.Drawing.Color.DarkOrange;
            this.NewPasswordTextbox.Location = new System.Drawing.Point(84, 82);
            this.NewPasswordTextbox.Name = "NewPasswordTextbox";
            this.NewPasswordTextbox.Size = new System.Drawing.Size(190, 21);
            this.NewPasswordTextbox.TabIndex = 1;
            this.NewPasswordTextbox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wpisz nowe hasło:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Powtórz nowe hasło:";
            // 
            // RepeatNewPasswordTextBox
            // 
            this.RepeatNewPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.RepeatNewPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RepeatNewPasswordTextBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.RepeatNewPasswordTextBox.Location = new System.Drawing.Point(84, 124);
            this.RepeatNewPasswordTextBox.Name = "RepeatNewPasswordTextBox";
            this.RepeatNewPasswordTextBox.Size = new System.Drawing.Size(190, 21);
            this.RepeatNewPasswordTextBox.TabIndex = 3;
            this.RepeatNewPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(84, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pokaż hasła";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // AddPwd
            // 
            this.AddPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPwd.Location = new System.Drawing.Point(84, 208);
            this.AddPwd.Name = "AddPwd";
            this.AddPwd.Size = new System.Drawing.Size(190, 34);
            this.AddPwd.TabIndex = 6;
            this.AddPwd.Text = "Dodaj hasło";
            this.AddPwd.UseVisualStyleBackColor = false;
            this.AddPwd.Click += new System.EventHandler(this.AddPwd_Click);
            // 
            // setPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(358, 280);
            this.Controls.Add(this.AddPwd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RepeatNewPasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewPasswordTextbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "setPassword";
            this.ShowInTaskbar = false;
            this.Text = "setPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewPasswordTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RepeatNewPasswordTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddPwd;
    }
}