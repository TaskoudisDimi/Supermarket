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
            this.getButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.productsCheckBox = new System.Windows.Forms.CheckBox();
            this.categoriesCheckBox = new System.Windows.Forms.CheckBox();
            this.productsLabel = new System.Windows.Forms.Label();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(111, 12);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(75, 23);
            this.getButton.TabIndex = 0;
            this.getButton.Text = "Get";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(111, 41);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 84);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Status";
            // 
            // productsCheckBox
            // 
            this.productsCheckBox.AutoSize = true;
            this.productsCheckBox.Location = new System.Drawing.Point(12, 12);
            this.productsCheckBox.Name = "productsCheckBox";
            this.productsCheckBox.Size = new System.Drawing.Size(68, 17);
            this.productsCheckBox.TabIndex = 5;
            this.productsCheckBox.Text = "Products";
            this.productsCheckBox.UseVisualStyleBackColor = true;
            // 
            // categoriesCheckBox
            // 
            this.categoriesCheckBox.AutoSize = true;
            this.categoriesCheckBox.Location = new System.Drawing.Point(12, 33);
            this.categoriesCheckBox.Name = "categoriesCheckBox";
            this.categoriesCheckBox.Size = new System.Drawing.Size(76, 17);
            this.categoriesCheckBox.TabIndex = 6;
            this.categoriesCheckBox.Text = "Categories";
            this.categoriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Location = new System.Drawing.Point(12, 115);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(49, 13);
            this.productsLabel.TabIndex = 7;
            this.productsLabel.Text = "Products";
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.AutoSize = true;
            this.categoriesLabel.Location = new System.Drawing.Point(12, 146);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(57, 13);
            this.categoriesLabel.TabIndex = 8;
            this.categoriesLabel.Text = "Categories";
            // 
            // GetFromExternalAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 183);
            this.Controls.Add(this.categoriesLabel);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.categoriesCheckBox);
            this.Controls.Add(this.productsCheckBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.getButton);
            this.Name = "GetFromExternalAPI";
            this.Text = "GetFromExternalAPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.CheckBox productsCheckBox;
        private System.Windows.Forms.CheckBox categoriesCheckBox;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Label categoriesLabel;
    }
}