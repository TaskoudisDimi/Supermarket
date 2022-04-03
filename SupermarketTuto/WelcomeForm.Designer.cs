namespace SupermarketTuto
{
    partial class WelcomeForm
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.RoleCb = new System.Windows.Forms.ComboBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.tittleLabel = new System.Windows.Forms.Label();
            this.clearLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.exitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.White;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.Location = new System.Drawing.Point(673, 285);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(104, 45);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Login";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.White;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(440, 445);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(145, 32);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "USERNAME";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.White;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(440, 508);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(147, 32);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "PASSWORD";
            // 
            // RoleCb
            // 
            this.RoleCb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoleCb.FormattingEnabled = true;
            this.RoleCb.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.RoleCb.Location = new System.Drawing.Point(631, 375);
            this.RoleCb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RoleCb.Name = "RoleCb";
            this.RoleCb.Size = new System.Drawing.Size(171, 40);
            this.RoleCb.TabIndex = 4;
            this.RoleCb.Text = "Select Role";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(696, 665);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(107, 38);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // tittleLabel
            // 
            this.tittleLabel.AutoSize = true;
            this.tittleLabel.BackColor = System.Drawing.Color.White;
            this.tittleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tittleLabel.Location = new System.Drawing.Point(47, 48);
            this.tittleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tittleLabel.Name = "tittleLabel";
            this.tittleLabel.Size = new System.Drawing.Size(215, 45);
            this.tittleLabel.TabIndex = 6;
            this.tittleLabel.Text = "SuperMarket";
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.BackColor = System.Drawing.Color.White;
            this.clearLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearLabel.Location = new System.Drawing.Point(696, 708);
            this.clearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(96, 45);
            this.clearLabel.TabIndex = 7;
            this.clearLabel.Text = "Clear";
            this.clearLabel.Click += new System.EventHandler(this.clearLabel_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(641, 445);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(150, 31);
            this.usernameTextBox.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(641, 508);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(150, 31);
            this.passwordTextBox.TabIndex = 9;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.White;
            this.exitLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitLabel.Location = new System.Drawing.Point(1149, 8);
            this.exitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(41, 45);
            this.exitLabel.TabIndex = 10;
            this.exitLabel.Text = "Χ";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 930);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.tittleLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.RoleCb);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.loginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Form";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label loginLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private ComboBox RoleCb;
        private Button loginButton;
        private Label tittleLabel;
        private Label clearLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label exitLabel;
    }
}