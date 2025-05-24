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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            UsernameLabel = new Label();
            UsernameTextBox = new TextBox();
            LoginLabelStatic = new Label();
            LoginButton = new Button();
            LoginErrorLabelPassword = new Label();
            LoginErrorLabelUsername = new Label();
            LoginForm.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // LoginForm
            // 
            LoginForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoginForm.AutoSize = true;
            LoginForm.BackColor = Color.FromArgb(255, 246, 218);
            LoginForm.BorderStyle = BorderStyle.FixedSingle;
            LoginForm.Controls.Add(tableLayoutPanel1);
            LoginForm.Controls.Add(LoginErrorLabelPassword);
            LoginForm.Controls.Add(LoginErrorLabelUsername);
            LoginForm.Location = new Point(106, 63);
            LoginForm.Name = "LoginForm";
            LoginForm.Size = new Size(623, 640);
            LoginForm.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(LoginLabelStatic, 0, 0);
            tableLayoutPanel1.Controls.Add(LoginButton, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(621, 638);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.None;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(PasswordTextBox, 0, 1);
            tableLayoutPanel3.Controls.Add(PasswordLabel, 0, 0);
            tableLayoutPanel3.Location = new Point(54, 321);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(512, 153);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.None;
            PasswordTextBox.Font = new Font("Segoe UI", 16F);
            PasswordTextBox.Location = new Point(13, 82);
            PasswordTextBox.MinimumSize = new Size(4, 65);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(486, 65);
            PasswordTextBox.TabIndex = 1;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 18F);
            PasswordLabel.Location = new Point(3, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(506, 76);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password";
            PasswordLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(UsernameLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(UsernameTextBox, 0, 1);
            tableLayoutPanel2.Location = new Point(54, 163);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(513, 150);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // UsernameLabel
            // 
            UsernameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 18F);
            UsernameLabel.Location = new Point(3, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(507, 75);
            UsernameLabel.TabIndex = 3;
            UsernameLabel.Text = "Brugernavn";
            UsernameLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Anchor = AnchorStyles.None;
            UsernameTextBox.Font = new Font("Segoe UI", 16F);
            UsernameTextBox.Location = new Point(12, 80);
            UsernameTextBox.MinimumSize = new Size(4, 65);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(488, 65);
            UsernameTextBox.TabIndex = 0;
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // LoginLabelStatic
            // 
            LoginLabelStatic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoginLabelStatic.AutoSize = true;
            LoginLabelStatic.Font = new Font("Segoe UI", 28F);
            LoginLabelStatic.Location = new Point(3, 0);
            LoginLabelStatic.Name = "LoginLabelStatic";
            LoginLabelStatic.Size = new Size(615, 159);
            LoginLabelStatic.TabIndex = 5;
            LoginLabelStatic.Text = "Login";
            LoginLabelStatic.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.None;
            LoginButton.BackColor = Color.FromArgb(45, 199, 92);
            LoginButton.Font = new Font("Segoe UI", 24F);
            LoginButton.Location = new Point(205, 504);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(211, 107);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginErrorLabelPassword
            // 
            LoginErrorLabelPassword.AutoSize = true;
            LoginErrorLabelPassword.Location = new Point(266, 332);
            LoginErrorLabelPassword.Name = "LoginErrorLabelPassword";
            LoginErrorLabelPassword.Size = new Size(0, 25);
            LoginErrorLabelPassword.TabIndex = 8;
            // 
            // LoginErrorLabelUsername
            // 
            LoginErrorLabelUsername.AutoSize = true;
            LoginErrorLabelUsername.Location = new Point(266, 157);
            LoginErrorLabelUsername.Name = "LoginErrorLabelUsername";
            LoginErrorLabelUsername.Size = new Size(0, 25);
            LoginErrorLabelUsername.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(834, 772);
            Controls.Add(LoginForm);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            LoginForm.ResumeLayout(false);
            LoginForm.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
