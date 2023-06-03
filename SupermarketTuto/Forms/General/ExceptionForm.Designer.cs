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
            this.SuspendLayout();
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(12, 63);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.messageTextBox.Size = new System.Drawing.Size(902, 50);
            this.messageTextBox.TabIndex = 0;
            // 
            // stachTraceTextBox
            // 
            this.stachTraceTextBox.Location = new System.Drawing.Point(12, 172);
            this.stachTraceTextBox.Multiline = true;
            this.stachTraceTextBox.Name = "stachTraceTextBox";
            this.stachTraceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.stachTraceTextBox.Size = new System.Drawing.Size(902, 396);
            this.stachTraceTextBox.TabIndex = 1;
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(12, 587);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(110, 57);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(165, 587);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(110, 57);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.Location = new System.Drawing.Point(318, 587);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(110, 57);
            this.sendEmailButton.TabIndex = 4;
            this.sendEmailButton.Text = "Send Email";
            this.sendEmailButton.UseVisualStyleBackColor = true;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(12, 27);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(74, 20);
            this.messageLabel.TabIndex = 5;
            this.messageLabel.Text = "Message";
            // 
            // stackTraceLabel
            // 
            this.stackTraceLabel.AutoSize = true;
            this.stackTraceLabel.Location = new System.Drawing.Point(12, 136);
            this.stackTraceLabel.Name = "stackTraceLabel";
            this.stackTraceLabel.Size = new System.Drawing.Size(90, 20);
            this.stackTraceLabel.TabIndex = 6;
            this.stackTraceLabel.Text = "StackTrace";
            // 
            // ExceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 656);
            this.Controls.Add(this.stackTraceLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.sendEmailButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.stachTraceTextBox);
            this.Controls.Add(this.messageTextBox);
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
    }
}