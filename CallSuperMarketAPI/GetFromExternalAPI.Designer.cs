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
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allButton
            // 
            this.allButton.Location = new System.Drawing.Point(49, 191);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(75, 23);
            this.allButton.TabIndex = 0;
            this.allButton.Text = "All";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.Location = new System.Drawing.Point(251, 191);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(75, 23);
            this.categoryButton.TabIndex = 1;
            this.categoryButton.Text = "Category";
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(251, 162);
            this.textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(76, 20);
            this.textBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(152, 191);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // GetFromExternalAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 243);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.allButton);
            this.Name = "GetFromExternalAPI";
            this.Text = "GetFromExternalAPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button saveButton;
    }
}