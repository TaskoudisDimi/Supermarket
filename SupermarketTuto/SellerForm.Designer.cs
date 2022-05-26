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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerForm));
            this.manageSellersPanel = new System.Windows.Forms.Panel();
            this.logOutLabel = new System.Windows.Forms.Label();
            this.SellDGV = new System.Windows.Forms.DataGridView();
            this.password2Label = new System.Windows.Forms.Label();
            this.SellPass = new System.Windows.Forms.TextBox();
            this.delete2Button = new System.Windows.Forms.Button();
            this.edit2Button = new System.Windows.Forms.Button();
            this.add2Button = new System.Windows.Forms.Button();
            this.phone2Label = new System.Windows.Forms.Label();
            this.age2Label = new System.Windows.Forms.Label();
            this.name2Label = new System.Windows.Forms.Label();
            this.id2label = new System.Windows.Forms.Label();
            this.SellPhone = new System.Windows.Forms.TextBox();
            this.SellAge = new System.Windows.Forms.TextBox();
            this.SellName = new System.Windows.Forms.TextBox();
            this.SellId = new System.Windows.Forms.TextBox();
            this.manageSellersLabel = new System.Windows.Forms.Label();
            this.products2Button = new System.Windows.Forms.Button();
            this.categories2Button = new System.Windows.Forms.Button();
            this.manageSellersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // manageSellersPanel
            // 
            this.manageSellersPanel.BackColor = System.Drawing.Color.Silver;
            this.manageSellersPanel.Controls.Add(this.SellDGV);
            this.manageSellersPanel.Controls.Add(this.password2Label);
            this.manageSellersPanel.Controls.Add(this.SellPass);
            this.manageSellersPanel.Controls.Add(this.delete2Button);
            this.manageSellersPanel.Controls.Add(this.edit2Button);
            this.manageSellersPanel.Controls.Add(this.add2Button);
            this.manageSellersPanel.Controls.Add(this.phone2Label);
            this.manageSellersPanel.Controls.Add(this.age2Label);
            this.manageSellersPanel.Controls.Add(this.name2Label);
            this.manageSellersPanel.Controls.Add(this.id2label);
            this.manageSellersPanel.Controls.Add(this.SellPhone);
            this.manageSellersPanel.Controls.Add(this.SellAge);
            this.manageSellersPanel.Controls.Add(this.SellName);
            this.manageSellersPanel.Controls.Add(this.SellId);
            this.manageSellersPanel.Controls.Add(this.manageSellersLabel);
            this.manageSellersPanel.Location = new System.Drawing.Point(191, 78);
            this.manageSellersPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manageSellersPanel.Name = "manageSellersPanel";
            this.manageSellersPanel.Size = new System.Drawing.Size(887, 833);
            this.manageSellersPanel.TabIndex = 0;
            // 
            // logOutLabel
            // 
            this.logOutLabel.AutoSize = true;
            this.logOutLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logOutLabel.Location = new System.Drawing.Point(973, 28);
            this.logOutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logOutLabel.Name = "logOutLabel";
            this.logOutLabel.Size = new System.Drawing.Size(105, 32);
            this.logOutLabel.TabIndex = 40;
            this.logOutLabel.Text = "Log Out";
            this.logOutLabel.Click += new System.EventHandler(this.logOutLabel_Click);
            // 
            // SellDGV
            // 
            this.SellDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.SellDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellDGV.Location = new System.Drawing.Point(389, 183);
            this.SellDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellDGV.Name = "SellDGV";
            this.SellDGV.RowHeadersWidth = 62;
            this.SellDGV.RowTemplate.Height = 30;
            this.SellDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellDGV.Size = new System.Drawing.Size(477, 645);
            this.SellDGV.TabIndex = 16;
            this.SellDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellDGV_CellContentClicks);
            // 
            // password2Label
            // 
            this.password2Label.AutoSize = true;
            this.password2Label.Location = new System.Drawing.Point(27, 452);
            this.password2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password2Label.Name = "password2Label";
            this.password2Label.Size = new System.Drawing.Size(87, 25);
            this.password2Label.TabIndex = 14;
            this.password2Label.Text = "Password";
            // 
            // SellPass
            // 
            this.SellPass.Location = new System.Drawing.Point(166, 447);
            this.SellPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellPass.Name = "SellPass";
            this.SellPass.Size = new System.Drawing.Size(141, 31);
            this.SellPass.TabIndex = 13;
            // 
            // delete2Button
            // 
            this.delete2Button.Location = new System.Drawing.Point(273, 510);
            this.delete2Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delete2Button.Name = "delete2Button";
            this.delete2Button.Size = new System.Drawing.Size(107, 38);
            this.delete2Button.TabIndex = 12;
            this.delete2Button.Text = "Delete";
            this.delete2Button.UseVisualStyleBackColor = true;
            this.delete2Button.Click += new System.EventHandler(this.delete2Button_Click);
            // 
            // edit2Button
            // 
            this.edit2Button.Location = new System.Drawing.Point(141, 510);
            this.edit2Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edit2Button.Name = "edit2Button";
            this.edit2Button.Size = new System.Drawing.Size(107, 38);
            this.edit2Button.TabIndex = 11;
            this.edit2Button.Text = "Edit";
            this.edit2Button.UseVisualStyleBackColor = true;
            this.edit2Button.Click += new System.EventHandler(this.edit2Button_Click);
            // 
            // add2Button
            // 
            this.add2Button.Location = new System.Drawing.Point(4, 510);
            this.add2Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add2Button.Name = "add2Button";
            this.add2Button.Size = new System.Drawing.Size(107, 38);
            this.add2Button.TabIndex = 10;
            this.add2Button.Text = "Add";
            this.add2Button.UseVisualStyleBackColor = true;
            this.add2Button.Click += new System.EventHandler(this.add2Button_Click);
            // 
            // phone2Label
            // 
            this.phone2Label.AutoSize = true;
            this.phone2Label.Location = new System.Drawing.Point(27, 390);
            this.phone2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phone2Label.Name = "phone2Label";
            this.phone2Label.Size = new System.Drawing.Size(62, 25);
            this.phone2Label.TabIndex = 9;
            this.phone2Label.Text = "Phone";
            // 
            // age2Label
            // 
            this.age2Label.AutoSize = true;
            this.age2Label.Location = new System.Drawing.Point(43, 320);
            this.age2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.age2Label.Name = "age2Label";
            this.age2Label.Size = new System.Drawing.Size(44, 25);
            this.age2Label.TabIndex = 8;
            this.age2Label.Text = "Age";
            // 
            // name2Label
            // 
            this.name2Label.AutoSize = true;
            this.name2Label.Location = new System.Drawing.Point(27, 260);
            this.name2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name2Label.Name = "name2Label";
            this.name2Label.Size = new System.Drawing.Size(59, 25);
            this.name2Label.TabIndex = 7;
            this.name2Label.Text = "Name";
            // 
            // id2label
            // 
            this.id2label.AutoSize = true;
            this.id2label.Location = new System.Drawing.Point(43, 183);
            this.id2label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id2label.Name = "id2label";
            this.id2label.Size = new System.Drawing.Size(30, 25);
            this.id2label.TabIndex = 6;
            this.id2label.Text = "ID";
            // 
            // SellPhone
            // 
            this.SellPhone.Location = new System.Drawing.Point(166, 385);
            this.SellPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellPhone.Name = "SellPhone";
            this.SellPhone.Size = new System.Drawing.Size(141, 31);
            this.SellPhone.TabIndex = 5;
            // 
            // SellAge
            // 
            this.SellAge.Location = new System.Drawing.Point(166, 320);
            this.SellAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellAge.Name = "SellAge";
            this.SellAge.Size = new System.Drawing.Size(141, 31);
            this.SellAge.TabIndex = 4;
            // 
            // SellName
            // 
            this.SellName.Location = new System.Drawing.Point(166, 255);
            this.SellName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellName.Name = "SellName";
            this.SellName.Size = new System.Drawing.Size(141, 31);
            this.SellName.TabIndex = 3;
            // 
            // SellId
            // 
            this.SellId.Location = new System.Drawing.Point(166, 183);
            this.SellId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellId.Name = "SellId";
            this.SellId.Size = new System.Drawing.Size(141, 31);
            this.SellId.TabIndex = 2;
            // 
            // manageSellersLabel
            // 
            this.manageSellersLabel.AutoSize = true;
            this.manageSellersLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manageSellersLabel.Location = new System.Drawing.Point(349, 15);
            this.manageSellersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.manageSellersLabel.Name = "manageSellersLabel";
            this.manageSellersLabel.Size = new System.Drawing.Size(273, 48);
            this.manageSellersLabel.TabIndex = 1;
            this.manageSellersLabel.Text = "Manage Sellers";
            // 
            // products2Button
            // 
            this.products2Button.FlatAppearance.BorderSize = 0;
            this.products2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.products2Button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.products2Button.Location = new System.Drawing.Point(4, 197);
            this.products2Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.products2Button.Name = "products2Button";
            this.products2Button.Size = new System.Drawing.Size(150, 68);
            this.products2Button.TabIndex = 13;
            this.products2Button.Text = "Products";
            this.products2Button.UseVisualStyleBackColor = true;
            this.products2Button.Click += new System.EventHandler(this.products2Button_Click);
            // 
            // categories2Button
            // 
            this.categories2Button.FlatAppearance.BorderSize = 0;
            this.categories2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categories2Button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categories2Button.Location = new System.Drawing.Point(4, 300);
            this.categories2Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categories2Button.Name = "categories2Button";
            this.categories2Button.Size = new System.Drawing.Size(179, 72);
            this.categories2Button.TabIndex = 14;
            this.categories2Button.Text = "Categories";
            this.categories2Button.UseVisualStyleBackColor = true;
            this.categories2Button.Click += new System.EventHandler(this.categories2Button_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 937);
            this.Controls.Add(this.logOutLabel);
            this.Controls.Add(this.categories2Button);
            this.Controls.Add(this.products2Button);
            this.Controls.Add(this.manageSellersPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.manageSellersPanel.ResumeLayout(false);
            this.manageSellersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel manageSellersPanel;
        private Label manageSellersLabel;
        private TextBox SellPhone;
        private TextBox SellAge;
        private TextBox SellName;
        private TextBox SellId;
        private Label phone2Label;
        private Label age2Label;
        private Label name2Label;
        private Label id2label;
        private Button delete2Button;
        private Button edit2Button;
        private Button add2Button;
        private Button products2Button;
        private Button categories2Button;
        private Label password2Label;
        private TextBox SellPass;
        private DataGridView SellDGV;
        private Label logOutLabel;
    }
}