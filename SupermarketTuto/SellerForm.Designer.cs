namespace SupermarketTuto
{
    partial class SellerForm
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
            this.manageSellersPanel = new System.Windows.Forms.Panel();
            this.manageSellersLabel = new System.Windows.Forms.Label();
            this.id2TextBox = new System.Windows.Forms.TextBox();
            this.name2TextBox = new System.Windows.Forms.TextBox();
            this.age2TextBox = new System.Windows.Forms.TextBox();
            this.phone2TextBox = new System.Windows.Forms.TextBox();
            this.id2label = new System.Windows.Forms.Label();
            this.name2Label = new System.Windows.Forms.Label();
            this.age2Label = new System.Windows.Forms.Label();
            this.phone2Label = new System.Windows.Forms.Label();
            this.add2Button = new System.Windows.Forms.Button();
            this.edit2Button = new System.Windows.Forms.Button();
            this.delete2Button = new System.Windows.Forms.Button();
            this.products2Button = new System.Windows.Forms.Button();
            this.categories2Button = new System.Windows.Forms.Button();
            this.selling2Button = new System.Windows.Forms.Button();
            this.password2TextBox = new System.Windows.Forms.TextBox();
            this.password2Label = new System.Windows.Forms.Label();
            this.manageSellersdataGridView = new System.Windows.Forms.DataGridView();
            this.manageSellersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageSellersdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // manageSellersPanel
            // 
            this.manageSellersPanel.BackColor = System.Drawing.Color.Silver;
            this.manageSellersPanel.Controls.Add(this.manageSellersdataGridView);
            this.manageSellersPanel.Controls.Add(this.password2Label);
            this.manageSellersPanel.Controls.Add(this.password2TextBox);
            this.manageSellersPanel.Controls.Add(this.delete2Button);
            this.manageSellersPanel.Controls.Add(this.edit2Button);
            this.manageSellersPanel.Controls.Add(this.add2Button);
            this.manageSellersPanel.Controls.Add(this.phone2Label);
            this.manageSellersPanel.Controls.Add(this.age2Label);
            this.manageSellersPanel.Controls.Add(this.name2Label);
            this.manageSellersPanel.Controls.Add(this.id2label);
            this.manageSellersPanel.Controls.Add(this.phone2TextBox);
            this.manageSellersPanel.Controls.Add(this.age2TextBox);
            this.manageSellersPanel.Controls.Add(this.name2TextBox);
            this.manageSellersPanel.Controls.Add(this.id2TextBox);
            this.manageSellersPanel.Controls.Add(this.manageSellersLabel);
            this.manageSellersPanel.Location = new System.Drawing.Point(84, 47);
            this.manageSellersPanel.Name = "manageSellersPanel";
            this.manageSellersPanel.Size = new System.Drawing.Size(659, 500);
            this.manageSellersPanel.TabIndex = 0;
            // 
            // manageSellersLabel
            // 
            this.manageSellersLabel.AutoSize = true;
            this.manageSellersLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manageSellersLabel.Location = new System.Drawing.Point(244, 9);
            this.manageSellersLabel.Name = "manageSellersLabel";
            this.manageSellersLabel.Size = new System.Drawing.Size(187, 32);
            this.manageSellersLabel.TabIndex = 1;
            this.manageSellersLabel.Text = "Manage Sellers";
            // 
            // id2TextBox
            // 
            this.id2TextBox.Location = new System.Drawing.Point(191, 98);
            this.id2TextBox.Name = "id2TextBox";
            this.id2TextBox.Size = new System.Drawing.Size(100, 23);
            this.id2TextBox.TabIndex = 2;
            // 
            // name2TextBox
            // 
            this.name2TextBox.Location = new System.Drawing.Point(191, 141);
            this.name2TextBox.Name = "name2TextBox";
            this.name2TextBox.Size = new System.Drawing.Size(100, 23);
            this.name2TextBox.TabIndex = 3;
            // 
            // age2TextBox
            // 
            this.age2TextBox.Location = new System.Drawing.Point(191, 180);
            this.age2TextBox.Name = "age2TextBox";
            this.age2TextBox.Size = new System.Drawing.Size(100, 23);
            this.age2TextBox.TabIndex = 4;
            // 
            // phone2TextBox
            // 
            this.phone2TextBox.Location = new System.Drawing.Point(191, 219);
            this.phone2TextBox.Name = "phone2TextBox";
            this.phone2TextBox.Size = new System.Drawing.Size(100, 23);
            this.phone2TextBox.TabIndex = 5;
            // 
            // id2label
            // 
            this.id2label.AutoSize = true;
            this.id2label.Location = new System.Drawing.Point(30, 97);
            this.id2label.Name = "id2label";
            this.id2label.Size = new System.Drawing.Size(18, 15);
            this.id2label.TabIndex = 6;
            this.id2label.Text = "ID";
            // 
            // name2Label
            // 
            this.name2Label.AutoSize = true;
            this.name2Label.Location = new System.Drawing.Point(30, 141);
            this.name2Label.Name = "name2Label";
            this.name2Label.Size = new System.Drawing.Size(39, 15);
            this.name2Label.TabIndex = 7;
            this.name2Label.Text = "Name";
            // 
            // age2Label
            // 
            this.age2Label.AutoSize = true;
            this.age2Label.Location = new System.Drawing.Point(30, 188);
            this.age2Label.Name = "age2Label";
            this.age2Label.Size = new System.Drawing.Size(28, 15);
            this.age2Label.TabIndex = 8;
            this.age2Label.Text = "Age";
            // 
            // phone2Label
            // 
            this.phone2Label.AutoSize = true;
            this.phone2Label.Location = new System.Drawing.Point(30, 227);
            this.phone2Label.Name = "phone2Label";
            this.phone2Label.Size = new System.Drawing.Size(41, 15);
            this.phone2Label.TabIndex = 9;
            this.phone2Label.Text = "Phone";
            // 
            // add2Button
            // 
            this.add2Button.Location = new System.Drawing.Point(43, 296);
            this.add2Button.Name = "add2Button";
            this.add2Button.Size = new System.Drawing.Size(75, 23);
            this.add2Button.TabIndex = 10;
            this.add2Button.Text = "Add";
            this.add2Button.UseVisualStyleBackColor = true;
            // 
            // edit2Button
            // 
            this.edit2Button.Location = new System.Drawing.Point(141, 296);
            this.edit2Button.Name = "edit2Button";
            this.edit2Button.Size = new System.Drawing.Size(75, 23);
            this.edit2Button.TabIndex = 11;
            this.edit2Button.Text = "Edit";
            this.edit2Button.UseVisualStyleBackColor = true;
            // 
            // delete2Button
            // 
            this.delete2Button.Location = new System.Drawing.Point(244, 296);
            this.delete2Button.Name = "delete2Button";
            this.delete2Button.Size = new System.Drawing.Size(75, 23);
            this.delete2Button.TabIndex = 12;
            this.delete2Button.Text = "Delete";
            this.delete2Button.UseVisualStyleBackColor = true;
            // 
            // products2Button
            // 
            this.products2Button.Location = new System.Drawing.Point(3, 118);
            this.products2Button.Name = "products2Button";
            this.products2Button.Size = new System.Drawing.Size(75, 23);
            this.products2Button.TabIndex = 13;
            this.products2Button.Text = "Products";
            this.products2Button.UseVisualStyleBackColor = true;
            // 
            // categories2Button
            // 
            this.categories2Button.Location = new System.Drawing.Point(3, 165);
            this.categories2Button.Name = "categories2Button";
            this.categories2Button.Size = new System.Drawing.Size(75, 23);
            this.categories2Button.TabIndex = 14;
            this.categories2Button.Text = "Categories";
            this.categories2Button.UseVisualStyleBackColor = true;
            // 
            // selling2Button
            // 
            this.selling2Button.Location = new System.Drawing.Point(3, 212);
            this.selling2Button.Name = "selling2Button";
            this.selling2Button.Size = new System.Drawing.Size(75, 23);
            this.selling2Button.TabIndex = 15;
            this.selling2Button.Text = "Selling";
            this.selling2Button.UseVisualStyleBackColor = true;
            // 
            // password2TextBox
            // 
            this.password2TextBox.Location = new System.Drawing.Point(191, 248);
            this.password2TextBox.Name = "password2TextBox";
            this.password2TextBox.Size = new System.Drawing.Size(100, 23);
            this.password2TextBox.TabIndex = 13;
            // 
            // password2Label
            // 
            this.password2Label.AutoSize = true;
            this.password2Label.Location = new System.Drawing.Point(30, 265);
            this.password2Label.Name = "password2Label";
            this.password2Label.Size = new System.Drawing.Size(57, 15);
            this.password2Label.TabIndex = 14;
            this.password2Label.Text = "Password";
            // 
            // manageSellersdataGridView
            // 
            this.manageSellersdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manageSellersdataGridView.Location = new System.Drawing.Point(343, 92);
            this.manageSellersdataGridView.Name = "manageSellersdataGridView";
            this.manageSellersdataGridView.RowTemplate.Height = 25;
            this.manageSellersdataGridView.Size = new System.Drawing.Size(313, 405);
            this.manageSellersdataGridView.TabIndex = 15;
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 562);
            this.Controls.Add(this.selling2Button);
            this.Controls.Add(this.categories2Button);
            this.Controls.Add(this.products2Button);
            this.Controls.Add(this.manageSellersPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerForm";
            this.Text = "SellerForm";
            this.manageSellersPanel.ResumeLayout(false);
            this.manageSellersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageSellersdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel manageSellersPanel;
        private Label manageSellersLabel;
        private TextBox phone2TextBox;
        private TextBox age2TextBox;
        private TextBox name2TextBox;
        private TextBox id2TextBox;
        private Label phone2Label;
        private Label age2Label;
        private Label name2Label;
        private Label id2label;
        private Button delete2Button;
        private Button edit2Button;
        private Button add2Button;
        private Button products2Button;
        private Button categories2Button;
        private Button selling2Button;
        private Label password2Label;
        private TextBox password2TextBox;
        private DataGridView manageSellersdataGridView;
    }
}