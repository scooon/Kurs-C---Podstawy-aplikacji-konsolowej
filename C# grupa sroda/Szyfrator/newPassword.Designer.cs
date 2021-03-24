namespace Szyfrator
{
    partial class newPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordStrong = new System.Windows.Forms.ProgressBar();
            this.showPwd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.setPwd = new System.Windows.Forms.Button();
            this.newPasswordTextbox = new System.Windows.Forms.TextBox();
            this.repeatNewPasswordTextbox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ustal nowe hasło";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nowe hasło:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Powtórz nowe hasło:";
            // 
            // passwordStrong
            // 
            this.passwordStrong.Location = new System.Drawing.Point(37, 205);
            this.passwordStrong.MarqueeAnimationSpeed = 250;
            this.passwordStrong.Name = "passwordStrong";
            this.passwordStrong.Size = new System.Drawing.Size(321, 12);
            this.passwordStrong.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.passwordStrong.TabIndex = 3;
            // 
            // showPwd
            // 
            this.showPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPwd.Location = new System.Drawing.Point(37, 238);
            this.showPwd.Name = "showPwd";
            this.showPwd.Size = new System.Drawing.Size(321, 45);
            this.showPwd.TabIndex = 4;
            this.showPwd.Text = "Pokaż hasła";
            this.showPwd.UseVisualStyleBackColor = false;
            this.showPwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPwd_MouseDown);
            this.showPwd.MouseLeave += new System.EventHandler(this.showPwd_MouseLeave);
            this.showPwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showPwd_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Długość hasła:";
            // 
            // setPwd
            // 
            this.setPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setPwd.Location = new System.Drawing.Point(37, 300);
            this.setPwd.Name = "setPwd";
            this.setPwd.Size = new System.Drawing.Size(321, 45);
            this.setPwd.TabIndex = 6;
            this.setPwd.Text = "Ustaw nowe hasło";
            this.setPwd.UseVisualStyleBackColor = false;
            this.setPwd.Click += new System.EventHandler(this.setPwd_Click);
            // 
            // newPasswordTextbox
            // 
            this.newPasswordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.newPasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPasswordTextbox.ForeColor = System.Drawing.Color.DarkOrange;
            this.newPasswordTextbox.Location = new System.Drawing.Point(37, 89);
            this.newPasswordTextbox.Name = "newPasswordTextbox";
            this.newPasswordTextbox.Size = new System.Drawing.Size(321, 26);
            this.newPasswordTextbox.TabIndex = 7;
            this.newPasswordTextbox.UseSystemPasswordChar = true;
            this.newPasswordTextbox.TextChanged += new System.EventHandler(this.newPasswordTextbox_TextChanged);
            // 
            // repeatNewPasswordTextbox
            // 
            this.repeatNewPasswordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.repeatNewPasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repeatNewPasswordTextbox.ForeColor = System.Drawing.Color.DarkOrange;
            this.repeatNewPasswordTextbox.Location = new System.Drawing.Point(37, 148);
            this.repeatNewPasswordTextbox.Name = "repeatNewPasswordTextbox";
            this.repeatNewPasswordTextbox.Size = new System.Drawing.Size(321, 26);
            this.repeatNewPasswordTextbox.TabIndex = 8;
            this.repeatNewPasswordTextbox.UseSystemPasswordChar = true;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CloseButton.Location = new System.Drawing.Point(364, 3);
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
            // newPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(399, 368);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.repeatNewPasswordTextbox);
            this.Controls.Add(this.newPasswordTextbox);
            this.Controls.Add(this.setPwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showPwd);
            this.Controls.Add(this.passwordStrong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "newPassword";
            this.ShowInTaskbar = false;
            this.Text = "newPassword";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.newPassword_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.newPassword_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.newPassword_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar passwordStrong;
        private System.Windows.Forms.Button showPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button setPwd;
        private System.Windows.Forms.TextBox newPasswordTextbox;
        private System.Windows.Forms.TextBox repeatNewPasswordTextbox;
        private System.Windows.Forms.Label CloseButton;
    }
}