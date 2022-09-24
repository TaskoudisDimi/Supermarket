namespace SupermarketTuto.Forms
{
    partial class ProgressBar
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
            this.BGWprogressBar = new System.Windows.Forms.ProgressBar();
            this.bgwLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BGWprogressBar
            // 
            this.BGWprogressBar.Location = new System.Drawing.Point(39, 88);
            this.BGWprogressBar.Name = "BGWprogressBar";
            this.BGWprogressBar.Size = new System.Drawing.Size(367, 35);
            this.BGWprogressBar.TabIndex = 0;
            // 
            // bgwLabel
            // 
            this.bgwLabel.AutoSize = true;
            this.bgwLabel.Location = new System.Drawing.Point(36, 54);
            this.bgwLabel.Name = "bgwLabel";
            this.bgwLabel.Size = new System.Drawing.Size(35, 13);
            this.bgwLabel.TabIndex = 1;
            this.bgwLabel.Text = "label1";
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 180);
            this.Controls.Add(this.bgwLabel);
            this.Controls.Add(this.BGWprogressBar);
            this.Name = "ProgressBar";
            this.Text = "ProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar BGWprogressBar;
        private Label bgwLabel;
    }
}