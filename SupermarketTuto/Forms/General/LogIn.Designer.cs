namespace SupermarketTuto
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.DontHaveAccountLabel = new System.Windows.Forms.Label();
            this.selectRoleLabel = new System.Windows.Forms.Label();
            this.selectRoleCombobox = new System.Windows.Forms.ComboBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UserNameTextBox.Location = new System.Drawing.Point(54, 48);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(245, 29);
            this.UserNameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PasswordTextBox.Location = new System.Drawing.Point(54, 138);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(245, 29);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(125, 282);
            this.ShowPasswordCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(102, 17);
            this.ShowPasswordCheckBox.TabIndex = 3;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.CadetBlue;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ClearButton.Location = new System.Drawing.Point(47, 381);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(245, 44);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.CadetBlue;
            this.LogInButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LogInButton.Location = new System.Drawing.Point(47, 333);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(2);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(245, 44);
            this.LogInButton.TabIndex = 5;
            this.LogInButton.Text = "LogIn";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.BackColor = System.Drawing.Color.CadetBlue;
            this.CreateAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.CreateAccountButton.FlatAppearance.BorderSize = 0;
            this.CreateAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAccountButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CreateAccountButton.Location = new System.Drawing.Point(47, 508);
            this.CreateAccountButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(245, 44);
            this.CreateAccountButton.TabIndex = 6;
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.UseVisualStyleBackColor = false;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.UsernameLabel.Location = new System.Drawing.Point(133, 11);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(87, 21);
            this.UsernameLabel.TabIndex = 7;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.PasswordLabel.Location = new System.Drawing.Point(135, 97);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(82, 21);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Password";
            // 
            // DontHaveAccountLabel
            // 
            this.DontHaveAccountLabel.AutoSize = true;
            this.DontHaveAccountLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DontHaveAccountLabel.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.DontHaveAccountLabel.Location = new System.Drawing.Point(81, 477);
            this.DontHaveAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DontHaveAccountLabel.Name = "DontHaveAccountLabel";
            this.DontHaveAccountLabel.Size = new System.Drawing.Size(177, 19);
            this.DontHaveAccountLabel.TabIndex = 9;
            this.DontHaveAccountLabel.Text = "You do not have an account?";
            // 
            // selectRoleLabel
            // 
            this.selectRoleLabel.AutoSize = true;
            this.selectRoleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.selectRoleLabel.Location = new System.Drawing.Point(129, 197);
            this.selectRoleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectRoleLabel.Name = "selectRoleLabel";
            this.selectRoleLabel.Size = new System.Drawing.Size(94, 21);
            this.selectRoleLabel.TabIndex = 10;
            this.selectRoleLabel.Text = "Select Role";
            // 
            // selectRoleCombobox
            // 
            this.selectRoleCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.selectRoleCombobox.FormattingEnabled = true;
            this.selectRoleCombobox.Location = new System.Drawing.Point(54, 235);
            this.selectRoleCombobox.Name = "selectRoleCombobox";
            this.selectRoleCombobox.Size = new System.Drawing.Size(245, 28);
            this.selectRoleCombobox.TabIndex = 11;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(147, 583);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(42, 13);
            this.versionLabel.TabIndex = 12;
            this.versionLabel.Text = "Version";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.Info;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.updateButton.Location = new System.Drawing.Point(104, 608);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(123, 29);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(378, 648);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.selectRoleCombobox);
            this.Controls.Add(this.selectRoleLabel);
            this.Controls.Add(this.DontHaveAccountLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogIn_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox UserNameTextBox;
        private TextBox PasswordTextBox;
        private CheckBox ShowPasswordCheckBox;
        private Button ClearButton;
        private Button LogInButton;
        private Button CreateAccountButton;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private Label DontHaveAccountLabel;
        private Label selectRoleLabel;
        private ComboBox selectRoleCombobox;
        private Label versionLabel;
        private Button updateButton;
    }
}