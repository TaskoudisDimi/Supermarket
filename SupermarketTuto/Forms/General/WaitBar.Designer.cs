namespace SupermarketTuto.Forms.General
{
    partial class WaitBar
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
            this.waitProgressBar = new System.Windows.Forms.ProgressBar();
            this.waitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // waitProgressBar
            // 
            this.waitProgressBar.Location = new System.Drawing.Point(123, 142);
            this.waitProgressBar.Name = "waitProgressBar";
            this.waitProgressBar.Size = new System.Drawing.Size(635, 49);
            this.waitProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.waitProgressBar.TabIndex = 0;
            // 
            // waitLabel
            // 
            this.waitLabel.AutoSize = true;
            this.waitLabel.Location = new System.Drawing.Point(407, 83);
            this.waitLabel.Name = "waitLabel";
            this.waitLabel.Size = new System.Drawing.Size(74, 20);
            this.waitLabel.TabIndex = 1;
            this.waitLabel.Text = "Waiting...";
            // 
            // WaitBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 265);
            this.Controls.Add(this.waitLabel);
            this.Controls.Add(this.waitProgressBar);
            this.Name = "WaitBar";
            this.Text = "WaitBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar waitProgressBar;
        private Label waitLabel;
    }
}