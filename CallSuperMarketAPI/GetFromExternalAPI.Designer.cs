namespace CallSuperMarketAPI
{
    partial class GetFromExternalAPI
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
            this.allButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // allButton
            // 
            this.allButton.Location = new System.Drawing.Point(73, 294);
            this.allButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(112, 35);
            this.allButton.TabIndex = 0;
            this.allButton.Text = "All";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.Location = new System.Drawing.Point(220, 294);
            this.categoryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(112, 35);
            this.categoryButton.TabIndex = 1;
            this.categoryButton.Text = "Category";
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(220, 249);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(112, 26);
            this.textBox.TabIndex = 2;
            // 
            // GetFromExternalAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 374);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.allButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GetFromExternalAPI";
            this.Text = "GetFromExternalAPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.TextBox textBox;
    }
}