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
            LoginForm.Location = new Point(74, 38);
            LoginForm.Margin = new Padding(2, 2, 2, 2);
            LoginForm.Name = "LoginForm";
            LoginForm.Size = new Size(437, 385);

            LoginForm.TabIndex = 0;
            // 
            // LoginErrorLabelPassword
            // 
            LoginErrorLabelPassword.AutoSize = true;
            LoginErrorLabelPassword.Location = new Point(186, 199);
            LoginErrorLabelPassword.Margin = new Padding(2, 0, 2, 0);
            LoginErrorLabelPassword.Name = "LoginErrorLabelPassword";
            LoginErrorLabelPassword.Size = new Size(0, 15);

            LoginErrorLabelPassword.TabIndex = 8;
            // 
            // LoginErrorLabelUsername
            // 
            LoginErrorLabelUsername.AutoSize = true;
            LoginErrorLabelUsername.Location = new Point(186, 94);
            LoginErrorLabelUsername.Margin = new Padding(2, 0, 2, 0);
            LoginErrorLabelUsername.Name = "LoginErrorLabelUsername";
            LoginErrorLabelUsername.Size = new Size(0, 15);
            LoginErrorLabelUsername.TabIndex = 7;
            // 
            // LoginLabelStatic
            // 
            LoginLabelStatic.AutoSize = true;
            LoginLabelStatic.Font = new Font("Segoe UI", 28F);
            LoginLabelStatic.Location = new Point(158, 11);
            LoginLabelStatic.Margin = new Padding(2, 0, 2, 0);
            LoginLabelStatic.Name = "LoginLabelStatic";
            LoginLabelStatic.Size = new Size(115, 51);
            LoginLabelStatic.TabIndex = 6;
            LoginLabelStatic.Text = "Login";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 16F);
            PasswordTextBox.Location = new Point(46, 218);
            PasswordTextBox.Margin = new Padding(2, 2, 2, 2);
            PasswordTextBox.MinimumSize = new Size(4, 65);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(343, 36);
            PasswordTextBox.TabIndex = 5;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Font = new Font("Segoe UI", 16F);
            UsernameTextBox.Location = new Point(46, 113);
            UsernameTextBox.Margin = new Padding(2, 2, 2, 2);
            UsernameTextBox.MinimumSize = new Size(4, 65);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(343, 36);
            UsernameTextBox.TabIndex = 4;
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 18F);
            PasswordLabel.Location = new Point(40, 187);
            PasswordLabel.Margin = new Padding(2, 0, 2, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(111, 32);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 18F);
            UsernameLabel.Location = new Point(40, 83);
            UsernameLabel.Margin = new Padding(2, 0, 2, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(137, 32);
            UsernameLabel.TabIndex = 2;
            UsernameLabel.Text = "Brugernavn";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(45, 199, 92);
            LoginButton.Font = new Font("Segoe UI", 24F);
            LoginButton.Location = new Point(151, 298);
            LoginButton.Margin = new Padding(2, 2, 2, 2);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(148, 64);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(584, 463);
            Controls.Add(LoginForm);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 2, 2, 2);
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
