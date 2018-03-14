namespace QuanLySieuThi
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
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.staffRadioButton = new System.Windows.Forms.RadioButton();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.loginButton = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.checkHiddenPass = new System.Windows.Forms.CheckBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(237, 94);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(105, 17);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Tên đăng nhập";
            this.userLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(237, 146);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(66, 17);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Mật khẩu";
            this.passLabel.Click += new System.EventHandler(this.passLabel_Click);
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(348, 94);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(154, 22);
            this.userText.TabIndex = 2;
            this.userText.TextChanged += new System.EventHandler(this.userText_TextChanged);
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(348, 141);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(154, 22);
            this.passText.TabIndex = 3;
            this.passText.UseSystemPasswordChar = true;
            this.passText.TextChanged += new System.EventHandler(this.passText_TextChanged);
            // 
            // staffRadioButton
            // 
            this.staffRadioButton.AutoSize = true;
            this.staffRadioButton.Checked = true;
            this.staffRadioButton.Location = new System.Drawing.Point(348, 219);
            this.staffRadioButton.Name = "staffRadioButton";
            this.staffRadioButton.Size = new System.Drawing.Size(237, 21);
            this.staffRadioButton.TabIndex = 5;
            this.staffRadioButton.TabStop = true;
            this.staffRadioButton.Text = "Đăng nhập với tư cách nhân viên";
            this.staffRadioButton.UseVisualStyleBackColor = true;
            this.staffRadioButton.CheckedChanged += new System.EventHandler(this.staffRadioButton_CheckedChanged);
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.Location = new System.Drawing.Point(348, 246);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Size = new System.Drawing.Size(221, 21);
            this.adminRadioButton.TabIndex = 6;
            this.adminRadioButton.Text = "Đăng nhập với tư cách quản lý";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            this.adminRadioButton.CheckedChanged += new System.EventHandler(this.adminRadioButton_CheckedChanged);
            // 
            // loginButton
            // 
            this.loginButton.Enabled = false;
            this.loginButton.Location = new System.Drawing.Point(268, 288);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(94, 34);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Đăng nhập";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(408, 289);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(94, 33);
            this.signupButton.TabIndex = 8;
            this.signupButton.Text = "Đăng ký";
            this.signupButton.UseVisualStyleBackColor = true;
            // 
            // checkHiddenPass
            // 
            this.checkHiddenPass.AutoSize = true;
            this.checkHiddenPass.Location = new System.Drawing.Point(348, 182);
            this.checkHiddenPass.Name = "checkHiddenPass";
            this.checkHiddenPass.Size = new System.Drawing.Size(121, 21);
            this.checkHiddenPass.TabIndex = 9;
            this.checkHiddenPass.Text = "Hiện mật khẩu";
            this.checkHiddenPass.UseVisualStyleBackColor = true;
            this.checkHiddenPass.CheckedChanged += new System.EventHandler(this.checkHiddenPass_CheckedChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(265, 372);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TabIndex = 10;
            // 
            // logoLabel
            // 
            this.logoLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.logoLabel.Image = global::QuanLySieuThi.Properties.Resources.Le_Quy_Don_Technical_University_logo;
            this.logoLabel.Location = new System.Drawing.Point(46, 94);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logoLabel.Size = new System.Drawing.Size(160, 160);
            this.logoLabel.TabIndex = 11;
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 483);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.checkHiddenPass);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.adminRadioButton);
            this.Controls.Add(this.staffRadioButton);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.RadioButton staffRadioButton;
        private System.Windows.Forms.RadioButton adminRadioButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.CheckBox checkHiddenPass;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label logoLabel;
    }
}