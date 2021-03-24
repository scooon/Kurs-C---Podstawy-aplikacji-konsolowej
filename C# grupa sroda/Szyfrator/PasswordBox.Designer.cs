namespace Szyfrator
{
    partial class PasswordBox
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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(128, 32);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(101, 18);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Podaj hasło:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AcceptsReturn = true;
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.passwordTextBox.Location = new System.Drawing.Point(104, 60);
            this.passwordTextBox.MaxLength = 16;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(148, 23);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(104, 99);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(148, 30);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Zaloguj";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CloseButton.Location = new System.Drawing.Point(325, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Padding = new System.Windows.Forms.Padding(5);
            this.CloseButton.Size = new System.Drawing.Size(32, 32);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "X";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.CloseButton.MouseHover += new System.EventHandler(this.CloseButton_MouseHover);
            // 
            // PasswordBox
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(360, 163);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "PasswordBox";
            this.Text = "PasswordBox";
            this.Load += new System.EventHandler(this.PasswordBox_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PasswordBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PasswordBox_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PasswordBox_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label CloseButton;
    }
}