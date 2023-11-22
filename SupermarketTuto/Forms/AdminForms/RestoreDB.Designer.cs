namespace SupermarketTuto.Forms.AdminForms
{
    partial class RestoreDB
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
            this.backupFileTextBox = new System.Windows.Forms.TextBox();
            this.bakupLabel = new System.Windows.Forms.Label();
            this.restoreButton = new System.Windows.Forms.Button();
            this.backupFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backupFileTextBox
            // 
            this.backupFileTextBox.Location = new System.Drawing.Point(121, 22);
            this.backupFileTextBox.Name = "backupFileTextBox";
            this.backupFileTextBox.Size = new System.Drawing.Size(217, 20);
            this.backupFileTextBox.TabIndex = 0;
            // 
            // bakupLabel
            // 
            this.bakupLabel.AutoSize = true;
            this.bakupLabel.Location = new System.Drawing.Point(12, 25);
            this.bakupLabel.Name = "bakupLabel";
            this.bakupLabel.Size = new System.Drawing.Size(63, 13);
            this.bakupLabel.TabIndex = 3;
            this.bakupLabel.Text = "Backup File";
            // 
            // restoreButton
            // 
            this.restoreButton.BackColor = System.Drawing.Color.LightBlue;
            this.restoreButton.Location = new System.Drawing.Point(172, 66);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(75, 23);
            this.restoreButton.TabIndex = 6;
            this.restoreButton.Text = "Restore";
            this.restoreButton.UseVisualStyleBackColor = false;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // backupFileButton
            // 
            this.backupFileButton.Location = new System.Drawing.Point(358, 22);
            this.backupFileButton.Name = "backupFileButton";
            this.backupFileButton.Size = new System.Drawing.Size(28, 23);
            this.backupFileButton.TabIndex = 7;
            this.backupFileButton.UseVisualStyleBackColor = true;
            this.backupFileButton.Click += new System.EventHandler(this.backupFileButton_Click);
            // 
            // RestoreDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 114);
            this.Controls.Add(this.backupFileButton);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.bakupLabel);
            this.Controls.Add(this.backupFileTextBox);
            this.Name = "RestoreDB";
            this.Text = "RestoreDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox backupFileTextBox;
        private Label bakupLabel;
        private Button restoreButton;
        private Button backupFileButton;
    }
}