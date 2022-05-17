namespace SupermarketTuto
{
    partial class CategoryForm
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
            this.manageCategoriesPanel = new System.Windows.Forms.Panel();
            this.logOutLabel = new System.Windows.Forms.Label();
            this.CatDGV = new System.Windows.Forms.DataGridView();
            this.delete3Button = new System.Windows.Forms.Button();
            this.edit3Button = new System.Windows.Forms.Button();
            this.add3Button = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.name3Label = new System.Windows.Forms.Label();
            this.id3label = new System.Windows.Forms.Label();
            this.CatDescTb = new System.Windows.Forms.TextBox();
            this.CatNameTb = new System.Windows.Forms.TextBox();
            this.CatIdTb = new System.Windows.Forms.TextBox();
            this.manageCategoriesLabel = new System.Windows.Forms.Label();
            this.exit2Button = new System.Windows.Forms.Button();
            this.selling2Button = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.sellersButton = new System.Windows.Forms.Button();
            this.manageCategoriesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // manageCategoriesPanel
            // 
            this.manageCategoriesPanel.BackColor = System.Drawing.Color.Silver;
            this.manageCategoriesPanel.Controls.Add(this.logOutLabel);
            this.manageCategoriesPanel.Controls.Add(this.CatDGV);
            this.manageCategoriesPanel.Controls.Add(this.delete3Button);
            this.manageCategoriesPanel.Controls.Add(this.edit3Button);
            this.manageCategoriesPanel.Controls.Add(this.add3Button);
            this.manageCategoriesPanel.Controls.Add(this.descriptionLabel);
            this.manageCategoriesPanel.Controls.Add(this.name3Label);
            this.manageCategoriesPanel.Controls.Add(this.id3label);
            this.manageCategoriesPanel.Controls.Add(this.CatDescTb);
            this.manageCategoriesPanel.Controls.Add(this.CatNameTb);
            this.manageCategoriesPanel.Controls.Add(this.CatIdTb);
            this.manageCategoriesPanel.Controls.Add(this.manageCategoriesLabel);
            this.manageCategoriesPanel.Location = new System.Drawing.Point(194, 67);
            this.manageCategoriesPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manageCategoriesPanel.Name = "manageCategoriesPanel";
            this.manageCategoriesPanel.Size = new System.Drawing.Size(941, 833);
            this.manageCategoriesPanel.TabIndex = 1;
            // 
            // logOutLabel
            // 
            this.logOutLabel.AutoSize = true;
            this.logOutLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logOutLabel.Location = new System.Drawing.Point(841, 0);
            this.logOutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logOutLabel.Name = "logOutLabel";
            this.logOutLabel.Size = new System.Drawing.Size(105, 32);
            this.logOutLabel.TabIndex = 40;
            this.logOutLabel.Text = "Log Out";
            this.logOutLabel.Click += new System.EventHandler(this.logOutLabel_Click);
            // 
            // CatDGV
            // 
            this.CatDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.CatDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatDGV.Location = new System.Drawing.Point(353, 153);
            this.CatDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatDGV.Name = "CatDGV";
            this.CatDGV.RowHeadersWidth = 62;
            this.CatDGV.RowTemplate.Height = 30;
            this.CatDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatDGV.Size = new System.Drawing.Size(573, 675);
            this.CatDGV.TabIndex = 15;
            this.CatDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatDGV_CellContentClick);
            // 
            // delete3Button
            // 
            this.delete3Button.Location = new System.Drawing.Point(237, 418);
            this.delete3Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delete3Button.Name = "delete3Button";
            this.delete3Button.Size = new System.Drawing.Size(107, 38);
            this.delete3Button.TabIndex = 12;
            this.delete3Button.Text = "Delete";
            this.delete3Button.UseVisualStyleBackColor = true;
            this.delete3Button.Click += new System.EventHandler(this.delete3Button_Click);
            // 
            // edit3Button
            // 
            this.edit3Button.Location = new System.Drawing.Point(121, 418);
            this.edit3Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edit3Button.Name = "edit3Button";
            this.edit3Button.Size = new System.Drawing.Size(107, 38);
            this.edit3Button.TabIndex = 11;
            this.edit3Button.Text = "Edit";
            this.edit3Button.UseVisualStyleBackColor = true;
            this.edit3Button.Click += new System.EventHandler(this.edit3Button_Click);
            // 
            // add3Button
            // 
            this.add3Button.Location = new System.Drawing.Point(6, 418);
            this.add3Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add3Button.Name = "add3Button";
            this.add3Button.Size = new System.Drawing.Size(107, 38);
            this.add3Button.TabIndex = 10;
            this.add3Button.Text = "Add";
            this.add3Button.UseVisualStyleBackColor = true;
            this.add3Button.Click += new System.EventHandler(this.add3Button_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(17, 305);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(102, 25);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "Description";
            // 
            // name3Label
            // 
            this.name3Label.AutoSize = true;
            this.name3Label.Location = new System.Drawing.Point(43, 235);
            this.name3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name3Label.Name = "name3Label";
            this.name3Label.Size = new System.Drawing.Size(59, 25);
            this.name3Label.TabIndex = 7;
            this.name3Label.Text = "Name";
            // 
            // id3label
            // 
            this.id3label.AutoSize = true;
            this.id3label.Location = new System.Drawing.Point(43, 162);
            this.id3label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id3label.Name = "id3label";
            this.id3label.Size = new System.Drawing.Size(30, 25);
            this.id3label.TabIndex = 6;
            this.id3label.Text = "ID";
            // 
            // CatDescTb
            // 
            this.CatDescTb.Location = new System.Drawing.Point(136, 292);
            this.CatDescTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatDescTb.Name = "CatDescTb";
            this.CatDescTb.Size = new System.Drawing.Size(141, 31);
            this.CatDescTb.TabIndex = 4;
            // 
            // CatNameTb
            // 
            this.CatNameTb.Location = new System.Drawing.Point(136, 222);
            this.CatNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatNameTb.Name = "CatNameTb";
            this.CatNameTb.Size = new System.Drawing.Size(141, 31);
            this.CatNameTb.TabIndex = 3;
            // 
            // CatIdTb
            // 
            this.CatIdTb.Location = new System.Drawing.Point(136, 157);
            this.CatIdTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatIdTb.Name = "CatIdTb";
            this.CatIdTb.Size = new System.Drawing.Size(141, 31);
            this.CatIdTb.TabIndex = 2;
            // 
            // manageCategoriesLabel
            // 
            this.manageCategoriesLabel.AutoSize = true;
            this.manageCategoriesLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manageCategoriesLabel.Location = new System.Drawing.Point(349, 15);
            this.manageCategoriesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.manageCategoriesLabel.Name = "manageCategoriesLabel";
            this.manageCategoriesLabel.Size = new System.Drawing.Size(342, 48);
            this.manageCategoriesLabel.TabIndex = 1;
            this.manageCategoriesLabel.Text = "Manage Categories";
            // 
            // exit2Button
            // 
            this.exit2Button.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.exit2Button.FlatAppearance.BorderSize = 0;
            this.exit2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit2Button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit2Button.Location = new System.Drawing.Point(1069, 2);
            this.exit2Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exit2Button.Name = "exit2Button";
            this.exit2Button.Size = new System.Drawing.Size(67, 55);
            this.exit2Button.TabIndex = 5;
            this.exit2Button.Text = "X";
            this.exit2Button.UseVisualStyleBackColor = true;
            this.exit2Button.Click += new System.EventHandler(this.exit2Button_Click);
            // 
            // selling2Button
            // 
            this.selling2Button.FlatAppearance.BorderSize = 0;
            this.selling2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selling2Button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selling2Button.Location = new System.Drawing.Point(20, 455);
            this.selling2Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selling2Button.Name = "selling2Button";
            this.selling2Button.Size = new System.Drawing.Size(167, 88);
            this.selling2Button.TabIndex = 8;
            this.selling2Button.Text = "Selling";
            this.selling2Button.UseVisualStyleBackColor = true;
            this.selling2Button.Click += new System.EventHandler(this.selling2Button_Click);
            // 
            // productsButton
            // 
            this.productsButton.FlatAppearance.BorderSize = 0;
            this.productsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productsButton.Location = new System.Drawing.Point(17, 335);
            this.productsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(167, 88);
            this.productsButton.TabIndex = 7;
            this.productsButton.Text = "Products";
            this.productsButton.UseVisualStyleBackColor = true;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // sellersButton
            // 
            this.sellersButton.FlatAppearance.BorderSize = 0;
            this.sellersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellersButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sellersButton.Location = new System.Drawing.Point(34, 220);
            this.sellersButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sellersButton.Name = "sellersButton";
            this.sellersButton.Size = new System.Drawing.Size(133, 88);
            this.sellersButton.TabIndex = 6;
            this.sellersButton.Text = "Sellers";
            this.sellersButton.UseVisualStyleBackColor = true;
            this.sellersButton.Click += new System.EventHandler(this.sellersButton_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 917);
            this.Controls.Add(this.selling2Button);
            this.Controls.Add(this.productsButton);
            this.Controls.Add(this.sellersButton);
            this.Controls.Add(this.exit2Button);
            this.Controls.Add(this.manageCategoriesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.manageCategoriesPanel.ResumeLayout(false);
            this.manageCategoriesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel manageCategoriesPanel;
        private DataGridView CatDGV;
        private Button delete3Button;
        private Button edit3Button;
        private Button add3Button;
        private Label descriptionLabel;
        private Label name3Label;
        private Label id3label;
        private TextBox CatDescTb;
        private TextBox CatNameTb;
        private TextBox CatIdTb;
        private Label manageCategoriesLabel;
        private Button exit2Button;
        private Button selling2Button;
        private Button productsButton;
        private Button sellersButton;
        private Label logOutLabel;
    }
}