namespace Semester_Projekt_1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginForm = new Panel();
            LoginErrorLabelPassword = new Label();
            LoginErrorLabelUsername = new Label();
            LoginLabelStatic = new Label();
            PasswordTextBox = new TextBox();
            UsernameTextBox = new TextBox();
            PasswordLabel = new Label();
            UsernameLabel = new Label();
            LoginButton = new Button();
            LoginForm.SuspendLayout();
            SuspendLayout();
            // 
            // LoginForm
            // 
            LoginForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoginForm.AutoSize = true;
            LoginForm.BackColor = Color.FromArgb(255, 246, 218);
            LoginForm.BorderStyle = BorderStyle.FixedSingle;
            LoginForm.Controls.Add(LoginErrorLabelPassword);
            LoginForm.Controls.Add(LoginErrorLabelUsername);
            LoginForm.Controls.Add(LoginLabelStatic);
            LoginForm.Controls.Add(PasswordTextBox);
            LoginForm.Controls.Add(UsernameTextBox);
            LoginForm.Controls.Add(PasswordLabel);
            LoginForm.Controls.Add(UsernameLabel);
            LoginForm.Controls.Add(LoginButton);
            LoginForm.Location = new Point(104, 82);
            LoginForm.Name = "LoginForm";
            LoginForm.Size = new Size(627, 608);
            LoginForm.TabIndex = 0;
            // 
            // LoginErrorLabelPassword
            // 
            LoginErrorLabelPassword.AutoSize = true;
            LoginErrorLabelPassword.Location = new Point(265, 331);
            LoginErrorLabelPassword.Name = "LoginErrorLabelPassword";
            LoginErrorLabelPassword.Size = new Size(0, 25);
            LoginErrorLabelPassword.TabIndex = 8;
            // 
            // LoginErrorLabelUsername
            // 
            LoginErrorLabelUsername.AutoSize = true;
            LoginErrorLabelUsername.Location = new Point(265, 157);
            LoginErrorLabelUsername.Name = "LoginErrorLabelUsername";
            LoginErrorLabelUsername.Size = new Size(0, 25);
            LoginErrorLabelUsername.TabIndex = 7;
            // 
            // LoginLabelStatic
            // 
            LoginLabelStatic.AutoSize = true;
            LoginLabelStatic.Font = new Font("Segoe UI", 28F);
            LoginLabelStatic.Location = new Point(225, 19);
            LoginLabelStatic.Name = "LoginLabelStatic";
            LoginLabelStatic.Size = new Size(170, 74);
            LoginLabelStatic.TabIndex = 6;
            LoginLabelStatic.Text = "Login";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 16F);
            PasswordTextBox.Location = new Point(66, 359);
            PasswordTextBox.MinimumSize = new Size(0, 65);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(488, 65);
            PasswordTextBox.TabIndex = 5;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Font = new Font("Segoe UI", 16F);
            UsernameTextBox.Location = new Point(66, 189);
            UsernameTextBox.MinimumSize = new Size(0, 65);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(488, 65);
            UsernameTextBox.TabIndex = 4;
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 18F);
            PasswordLabel.Location = new Point(57, 312);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(168, 48);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 18F);
            UsernameLabel.Location = new Point(57, 138);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(202, 48);
            UsernameLabel.TabIndex = 2;
            UsernameLabel.Text = "Brugernavn";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(45, 199, 92);
            LoginButton.Font = new Font("Segoe UI", 24F);
            LoginButton.Location = new Point(207, 467);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(211, 106);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(834, 772);
            Controls.Add(LoginForm);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            LoginForm.ResumeLayout(false);
            LoginForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel LoginForm;
        private Button LoginButton;
        private TextBox UsernameTextBox;
        private Label PasswordLabel;
        private Label UsernameLabel;
        protected TextBox PasswordTextBox;
        private Label LoginLabelStatic;
        private Label LoginErrorLabelPassword;
        private Label LoginErrorLabelUsername;
    }
}
