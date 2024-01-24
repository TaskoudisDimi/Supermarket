namespace SupermarketTuto.Forms.General
{
    partial class ExceptionForm
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
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.stachTraceTextBox = new System.Windows.Forms.TextBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.exitButton = new System.Windows.Forms.Button();
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.stackTraceLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(8, 41);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.messageTextBox.Size = new System.Drawing.Size(603, 34);
            this.messageTextBox.TabIndex = 0;
            // 
            // stachTraceTextBox
            // 
            this.stachTraceTextBox.Location = new System.Drawing.Point(8, 112);
            this.stachTraceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.stachTraceTextBox.Multiline = true;
            this.stachTraceTextBox.Name = "stachTraceTextBox";
            this.stachTraceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.stachTraceTextBox.Size = new System.Drawing.Size(603, 259);
            this.stachTraceTextBox.TabIndex = 1;
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.LightBlue;
            this.continueButton.Location = new System.Drawing.Point(9, 440);
            this.continueButton.Margin = new System.Windows.Forms.Padding(2);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(73, 37);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Tomato;
            this.exitButton.Location = new System.Drawing.Point(111, 440);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(73, 37);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.BackColor = System.Drawing.Color.LightBlue;
            this.sendEmailButton.Location = new System.Drawing.Point(213, 440);
            this.sendEmailButton.Margin = new System.Windows.Forms.Padding(2);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(73, 37);
            this.sendEmailButton.TabIndex = 4;
            this.sendEmailButton.Text = "Send Email";
            this.sendEmailButton.UseVisualStyleBackColor = false;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(8, 18);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(50, 13);
            this.messageLabel.TabIndex = 5;
            this.messageLabel.Text = "Message";
            // 
            // stackTraceLabel
            // 
            this.stackTraceLabel.AutoSize = true;
            this.stackTraceLabel.Location = new System.Drawing.Point(8, 88);
            this.stackTraceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stackTraceLabel.Name = "stackTraceLabel";
            this.stackTraceLabel.Size = new System.Drawing.Size(63, 13);
            this.stackTraceLabel.TabIndex = 6;
            this.stackTraceLabel.Text = "StackTrace";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(8, 401);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(209, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(8, 385);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email";
            // 
            // ExceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 488);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.stackTraceLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.sendEmailButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.stachTraceTextBox);
            this.Controls.Add(this.messageTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExceptionForm";
            this.Text = "ExceptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox messageTextBox;
        private TextBox stachTraceTextBox;
        private Button continueButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button exitButton;
        private Button sendEmailButton;
        private Label messageLabel;
        private Label stackTraceLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
    }
}