namespace Restaurant_Management
{
    partial class Login
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
            this.user_id = new MetroFramework.Controls.MetroTextBox();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.button_login = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.error_user = new System.Windows.Forms.Label();
            this.error_password = new System.Windows.Forms.Label();
            this.error_login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user_id
            // 
            // 
            // 
            // 
            this.user_id.CustomButton.Image = null;
            this.user_id.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.user_id.CustomButton.Name = "";
            this.user_id.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.user_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.user_id.CustomButton.TabIndex = 1;
            this.user_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.user_id.CustomButton.UseSelectable = true;
            this.user_id.CustomButton.Visible = false;
            this.user_id.Lines = new string[0];
            this.user_id.Location = new System.Drawing.Point(298, 182);
            this.user_id.MaxLength = 32767;
            this.user_id.Name = "user_id";
            this.user_id.PasswordChar = '\0';
            this.user_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.user_id.SelectedText = "";
            this.user_id.SelectionLength = 0;
            this.user_id.SelectionStart = 0;
            this.user_id.ShortcutsEnabled = true;
            this.user_id.Size = new System.Drawing.Size(197, 23);
            this.user_id.TabIndex = 1;
            this.user_id.UseSelectable = true;
            this.user_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.user_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // password
            // 
            // 
            // 
            // 
            this.password.CustomButton.Image = null;
            this.password.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.password.CustomButton.Name = "";
            this.password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password.CustomButton.TabIndex = 1;
            this.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.CustomButton.UseSelectable = true;
            this.password.CustomButton.Visible = false;
            this.password.Lines = new string[0];
            this.password.Location = new System.Drawing.Point(298, 261);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.ShortcutsEnabled = true;
            this.password.Size = new System.Drawing.Size(197, 23);
            this.password.TabIndex = 1;
            this.password.UseSelectable = true;
            this.password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.AliceBlue;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel1.Location = new System.Drawing.Point(298, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(165, 39);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "LOGIN TO RMS";
            this.metroLabel1.UseStyleColors = true;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.button_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_login.Location = new System.Drawing.Point(346, 357);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(101, 43);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "LOGIN";
            this.button_login.UseSelectable = true;
            this.button_login.UseStyleColors = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(101, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(101, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // error_user
            // 
            this.error_user.AutoSize = true;
            this.error_user.ForeColor = System.Drawing.Color.Red;
            this.error_user.Location = new System.Drawing.Point(301, 208);
            this.error_user.Name = "error_user";
            this.error_user.Size = new System.Drawing.Size(68, 13);
            this.error_user.TabIndex = 6;
            this.error_user.Text = "Input User Id";
            this.error_user.Visible = false;
            // 
            // error_password
            // 
            this.error_password.AutoSize = true;
            this.error_password.ForeColor = System.Drawing.Color.Red;
            this.error_password.Location = new System.Drawing.Point(301, 291);
            this.error_password.Name = "error_password";
            this.error_password.Size = new System.Drawing.Size(79, 13);
            this.error_password.TabIndex = 7;
            this.error_password.Text = "Input password";
            this.error_password.Visible = false;
            // 
            // error_login
            // 
            this.error_login.AutoSize = true;
            this.error_login.ForeColor = System.Drawing.Color.Red;
            this.error_login.Location = new System.Drawing.Point(330, 326);
            this.error_login.Name = "error_login";
            this.error_login.Size = new System.Drawing.Size(155, 13);
            this.error_login.TabIndex = 8;
            this.error_login.Text = "Userid or password didnt match";
            this.error_login.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 461);
            this.Controls.Add(this.error_login);
            this.Controls.Add(this.error_password);
            this.Controls.Add(this.error_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_id);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox user_id;
        private MetroFramework.Controls.MetroTextBox password;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton button_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label error_user;
        private System.Windows.Forms.Label error_password;
        private System.Windows.Forms.Label error_login;
    }
}

