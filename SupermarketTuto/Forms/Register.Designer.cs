namespace SupermarketTuto
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.GetStartedLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswardLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.AllHaveAccountLabel = new System.Windows.Forms.Label();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.chooseRoleLabel = new System.Windows.Forms.Label();
            this.chooseRoleCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameTextBox.Location = new System.Drawing.Point(350, 136);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(200, 29);
            this.UsernameTextBox.TabIndex = 0;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(350, 254);
            this.ConfirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '*';
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(200, 29);
            this.ConfirmPasswordTextBox.TabIndex = 1;
            this.ConfirmPasswordTextBox.TextChanged += new System.EventHandler(this.ConfirmPasswordTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTextBox.Location = new System.Drawing.Point(350, 196);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(200, 29);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterButton.Location = new System.Drawing.Point(350, 414);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(164, 49);
            this.RegisterButton.TabIndex = 3;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(350, 472);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(164, 49);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LogInButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.LogInButton.FlatAppearance.BorderSize = 0;
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInButton.Location = new System.Drawing.Point(382, 577);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(2);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(116, 34);
            this.LogInButton.TabIndex = 5;
            this.LogInButton.Text = "Back To Login";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // GetStartedLabel
            // 
            this.GetStartedLabel.AutoSize = true;
            this.GetStartedLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetStartedLabel.Location = new System.Drawing.Point(350, 16);
            this.GetStartedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GetStartedLabel.Name = "GetStartedLabel";
            this.GetStartedLabel.Size = new System.Drawing.Size(142, 32);
            this.GetStartedLabel.TabIndex = 6;
            this.GetStartedLabel.Text = "Get Started";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.Location = new System.Drawing.Point(350, 105);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(87, 21);
            this.UsernameLabel.TabIndex = 7;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswardLabel
            // 
            this.PasswardLabel.AutoSize = true;
            this.PasswardLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasswardLabel.Location = new System.Drawing.Point(350, 168);
            this.PasswardLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswardLabel.Name = "PasswardLabel";
            this.PasswardLabel.Size = new System.Drawing.Size(82, 21);
            this.PasswardLabel.TabIndex = 8;
            this.PasswardLabel.Text = "Password";
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(350, 225);
            this.ConfirmPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(148, 21);
            this.ConfirmPasswordLabel.TabIndex = 9;
            this.ConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // AllHaveAccountLabel
            // 
            this.AllHaveAccountLabel.AutoSize = true;
            this.AllHaveAccountLabel.Location = new System.Drawing.Point(364, 544);
            this.AllHaveAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AllHaveAccountLabel.Name = "AllHaveAccountLabel";
            this.AllHaveAccountLabel.Size = new System.Drawing.Size(144, 15);
            this.AllHaveAccountLabel.TabIndex = 10;
            this.AllHaveAccountLabel.Text = "Allready Have an Account";
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(435, 383);
            this.ShowPasswordCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(108, 19);
            this.ShowPasswordCheckBox.TabIndex = 11;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // chooseRoleLabel
            // 
            this.chooseRoleLabel.AutoSize = true;
            this.chooseRoleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chooseRoleLabel.Location = new System.Drawing.Point(350, 299);
            this.chooseRoleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseRoleLabel.Name = "chooseRoleLabel";
            this.chooseRoleLabel.Size = new System.Drawing.Size(104, 21);
            this.chooseRoleLabel.TabIndex = 13;
            this.chooseRoleLabel.Text = "Choose Role";
            // 
            // chooseRoleCombobox
            // 
            this.chooseRoleCombobox.FormattingEnabled = true;
            this.chooseRoleCombobox.Location = new System.Drawing.Point(350, 331);
            this.chooseRoleCombobox.Name = "chooseRoleCombobox";
            this.chooseRoleCombobox.Size = new System.Drawing.Size(200, 23);
            this.chooseRoleCombobox.TabIndex = 14;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 617);
            this.Controls.Add(this.chooseRoleCombobox);
            this.Controls.Add(this.chooseRoleLabel);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.AllHaveAccountLabel);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.PasswardLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.GetStartedLabel);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UsernameTextBox;
        private TextBox ConfirmPasswordTextBox;
        private TextBox PasswordTextBox;
        private Button RegisterButton;
        private Button ClearButton;
        private Button LogInButton;
        private Label GetStartedLabel;
        private Label UsernameLabel;
        private Label PasswardLabel;
        private Label ConfirmPasswordLabel;
        private Label AllHaveAccountLabel;
        private CheckBox ShowPasswordCheckBox;
        private Label chooseRoleLabel;
        private ComboBox chooseRoleCombobox;
    }
}