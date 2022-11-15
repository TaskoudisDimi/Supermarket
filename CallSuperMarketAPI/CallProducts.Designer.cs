namespace CallSuperMarketAPI
{
    partial class CallProducts
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
            this.putButton = new System.Windows.Forms.Button();
            this.DeleteApiButton = new System.Windows.Forms.Button();
            this.PostButton = new System.Windows.Forms.Button();
            this.GetButton = new System.Windows.Forms.Button();
            this.ProdDGV = new System.Windows.Forms.DataGridView();
            this.dateLabel = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.catCombobox = new System.Windows.Forms.ComboBox();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.ProdQty = new System.Windows.Forms.TextBox();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.ProdId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // putButton
            // 
            this.putButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.putButton.Location = new System.Drawing.Point(968, 948);
            this.putButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.putButton.Name = "putButton";
            this.putButton.Size = new System.Drawing.Size(102, 45);
            this.putButton.TabIndex = 130;
            this.putButton.Text = "Put";
            this.putButton.UseVisualStyleBackColor = true;
            this.putButton.Click += new System.EventHandler(this.putButton_Click);
            // 
            // DeleteApiButton
            // 
            this.DeleteApiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DeleteApiButton.Location = new System.Drawing.Point(728, 945);
            this.DeleteApiButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteApiButton.Name = "DeleteApiButton";
            this.DeleteApiButton.Size = new System.Drawing.Size(102, 45);
            this.DeleteApiButton.TabIndex = 129;
            this.DeleteApiButton.Text = "Delete";
            this.DeleteApiButton.UseVisualStyleBackColor = true;
            this.DeleteApiButton.Click += new System.EventHandler(this.DeleteApiButton_Click);
            // 
            // PostButton
            // 
            this.PostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PostButton.Location = new System.Drawing.Point(492, 946);
            this.PostButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(100, 46);
            this.PostButton.TabIndex = 128;
            this.PostButton.Text = "Post";
            this.PostButton.UseVisualStyleBackColor = true;
            this.PostButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // GetButton
            // 
            this.GetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.GetButton.Location = new System.Drawing.Point(286, 945);
            this.GetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(96, 48);
            this.GetButton.TabIndex = 127;
            this.GetButton.Text = "Get";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // ProdDGV
            // 
            this.ProdDGV.AllowUserToAddRows = false;
            this.ProdDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ProdDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDGV.Location = new System.Drawing.Point(60, 128);
            this.ProdDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdDGV.Name = "ProdDGV";
            this.ProdDGV.RowHeadersWidth = 62;
            this.ProdDGV.RowTemplate.Height = 30;
            this.ProdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdDGV.Size = new System.Drawing.Size(1352, 752);
            this.ProdDGV.TabIndex = 131;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dateLabel.Location = new System.Drawing.Point(1567, 598);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(67, 32);
            this.dateLabel.TabIndex = 143;
            this.dateLabel.Text = "Date";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(1848, 590);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(212, 35);
            this.DateTimePicker.TabIndex = 142;
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.AutoSize = true;
            this.categoriesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.categoriesLabel.Location = new System.Drawing.Point(1567, 707);
            this.categoriesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(135, 32);
            this.categoriesLabel.TabIndex = 141;
            this.categoriesLabel.Text = "Categories";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.priceLabel.Location = new System.Drawing.Point(1585, 490);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(71, 32);
            this.priceLabel.TabIndex = 140;
            this.priceLabel.Text = "Price";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.quantityLabel.Location = new System.Drawing.Point(1574, 384);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(113, 32);
            this.quantityLabel.TabIndex = 139;
            this.quantityLabel.Text = "Quantity";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(1574, 279);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(81, 32);
            this.nameLabel.TabIndex = 138;
            this.nameLabel.Text = "Name";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.idLabel.Location = new System.Drawing.Point(1585, 182);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(40, 32);
            this.idLabel.TabIndex = 137;
            this.idLabel.Text = "ID";
            // 
            // catCombobox
            // 
            this.catCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.catCombobox.FormattingEnabled = true;
            this.catCombobox.Location = new System.Drawing.Point(1848, 701);
            this.catCombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.catCombobox.Name = "catCombobox";
            this.catCombobox.Size = new System.Drawing.Size(212, 37);
            this.catCombobox.TabIndex = 136;
            this.catCombobox.Text = "Select Category";
            // 
            // ProdPrice
            // 
            this.ProdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ProdPrice.Location = new System.Drawing.Point(1848, 487);
            this.ProdPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(212, 35);
            this.ProdPrice.TabIndex = 135;
            // 
            // ProdQty
            // 
            this.ProdQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ProdQty.Location = new System.Drawing.Point(1848, 381);
            this.ProdQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Size = new System.Drawing.Size(212, 35);
            this.ProdQty.TabIndex = 134;
            // 
            // ProdName
            // 
            this.ProdName.BackColor = System.Drawing.Color.White;
            this.ProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ProdName.Location = new System.Drawing.Point(1848, 276);
            this.ProdName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(212, 35);
            this.ProdName.TabIndex = 133;
            // 
            // ProdId
            // 
            this.ProdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ProdId.Location = new System.Drawing.Point(1848, 182);
            this.ProdId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdId.Name = "ProdId";
            this.ProdId.Size = new System.Drawing.Size(212, 35);
            this.ProdId.TabIndex = 132;
            // 
            // CallProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2211, 1130);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.categoriesLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.catCombobox);
            this.Controls.Add(this.ProdPrice);
            this.Controls.Add(this.ProdQty);
            this.Controls.Add(this.ProdName);
            this.Controls.Add(this.ProdId);
            this.Controls.Add(this.ProdDGV);
            this.Controls.Add(this.putButton);
            this.Controls.Add(this.DeleteApiButton);
            this.Controls.Add(this.PostButton);
            this.Controls.Add(this.GetButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CallProducts";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CallProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button putButton;
        private System.Windows.Forms.Button DeleteApiButton;
        private System.Windows.Forms.Button PostButton;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.DataGridView ProdDGV;
        private System.Windows.Forms.Label dateLabel;
        public System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label categoriesLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.Label idLabel;
        public System.Windows.Forms.ComboBox catCombobox;
        public System.Windows.Forms.TextBox ProdPrice;
        public System.Windows.Forms.TextBox ProdQty;
        public System.Windows.Forms.TextBox ProdName;
        public System.Windows.Forms.TextBox ProdId;
    }
}

