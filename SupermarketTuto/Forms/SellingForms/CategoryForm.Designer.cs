namespace SupermarketTuto.Forms.SellingForms
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
            this.totalLabel = new System.Windows.Forms.Label();
            this.SellingProdName = new System.Windows.Forms.TextBox();
            this.SellingDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SearchCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BillId = new System.Windows.Forms.TextBox();
            this.SellingPriceTextBox = new System.Windows.Forms.TextBox();
            this.SellingQuantityTextBox = new System.Windows.Forms.TextBox();
            this.AddProductbutton = new System.Windows.Forms.Button();
            this.delete2Button = new System.Windows.Forms.Button();
            this.refreshOrderButton = new System.Windows.Forms.Button();
            this.total2Label = new System.Windows.Forms.Label();
            this.OrderDGV = new System.Windows.Forms.DataGridView();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SellingDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(68, 514);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 20);
            this.totalLabel.TabIndex = 60;
            this.totalLabel.Text = "Total:";
            // 
            // SellingProdName
            // 
            this.SellingProdName.BackColor = System.Drawing.Color.White;
            this.SellingProdName.Enabled = false;
            this.SellingProdName.Location = new System.Drawing.Point(1240, 253);
            this.SellingProdName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellingProdName.Name = "SellingProdName";
            this.SellingProdName.Size = new System.Drawing.Size(127, 26);
            this.SellingProdName.TabIndex = 54;
            // 
            // SellingDGV
            // 
            this.SellingDGV.AllowUserToAddRows = false;
            this.SellingDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SellingDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SellingDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.SellingDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellingDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellingDGV.Location = new System.Drawing.Point(55, 144);
            this.SellingDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellingDGV.Name = "SellingDGV";
            this.SellingDGV.RowHeadersWidth = 62;
            this.SellingDGV.RowTemplate.Height = 30;
            this.SellingDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellingDGV.Size = new System.Drawing.Size(738, 332);
            this.SellingDGV.TabIndex = 59;
            this.SellingDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellingDGV_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1019, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 32);
            this.label1.TabIndex = 49;
            this.label1.Text = "Bill Id";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(697, 94);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(96, 31);
            this.refreshButton.TabIndex = 58;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // SearchCb
            // 
            this.SearchCb.FormattingEnabled = true;
            this.SearchCb.Location = new System.Drawing.Point(55, 96);
            this.SearchCb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchCb.Name = "SearchCb";
            this.SearchCb.Size = new System.Drawing.Size(136, 28);
            this.SearchCb.TabIndex = 57;
            this.SearchCb.Text = "Select Category";
            this.SearchCb.SelectionChangeCommitted += new System.EventHandler(this.SearchCb_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1019, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 32);
            this.label2.TabIndex = 50;
            this.label2.Text = "ProdName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1019, 333);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 32);
            this.label3.TabIndex = 51;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1019, 432);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 32);
            this.label4.TabIndex = 52;
            this.label4.Text = "Quantity";
            // 
            // BillId
            // 
            this.BillId.Location = new System.Drawing.Point(1240, 158);
            this.BillId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BillId.Name = "BillId";
            this.BillId.Size = new System.Drawing.Size(127, 26);
            this.BillId.TabIndex = 53;
            // 
            // SellingPriceTextBox
            // 
            this.SellingPriceTextBox.Enabled = false;
            this.SellingPriceTextBox.Location = new System.Drawing.Point(1240, 346);
            this.SellingPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellingPriceTextBox.Name = "SellingPriceTextBox";
            this.SellingPriceTextBox.Size = new System.Drawing.Size(127, 26);
            this.SellingPriceTextBox.TabIndex = 55;
            // 
            // SellingQuantityTextBox
            // 
            this.SellingQuantityTextBox.Location = new System.Drawing.Point(1240, 450);
            this.SellingQuantityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellingQuantityTextBox.Name = "SellingQuantityTextBox";
            this.SellingQuantityTextBox.Size = new System.Drawing.Size(127, 26);
            this.SellingQuantityTextBox.TabIndex = 56;
            // 
            // AddProductbutton
            // 
            this.AddProductbutton.Location = new System.Drawing.Point(312, 571);
            this.AddProductbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddProductbutton.Name = "AddProductbutton";
            this.AddProductbutton.Size = new System.Drawing.Size(156, 31);
            this.AddProductbutton.TabIndex = 61;
            this.AddProductbutton.Text = "Add Product";
            this.AddProductbutton.UseVisualStyleBackColor = true;
            this.AddProductbutton.Click += new System.EventHandler(this.AddProductbutton_Click);
            // 
            // delete2Button
            // 
            this.delete2Button.Location = new System.Drawing.Point(217, 1075);
            this.delete2Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delete2Button.Name = "delete2Button";
            this.delete2Button.Size = new System.Drawing.Size(96, 31);
            this.delete2Button.TabIndex = 66;
            this.delete2Button.Text = "Delete";
            this.delete2Button.UseVisualStyleBackColor = true;
            // 
            // refreshOrderButton
            // 
            this.refreshOrderButton.Location = new System.Drawing.Point(697, 605);
            this.refreshOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refreshOrderButton.Name = "refreshOrderButton";
            this.refreshOrderButton.Size = new System.Drawing.Size(96, 31);
            this.refreshOrderButton.TabIndex = 65;
            this.refreshOrderButton.Text = "Refresh";
            this.refreshOrderButton.UseVisualStyleBackColor = true;
            this.refreshOrderButton.Click += new System.EventHandler(this.refreshOrderButton_Click);
            // 
            // total2Label
            // 
            this.total2Label.AutoSize = true;
            this.total2Label.Location = new System.Drawing.Point(68, 1076);
            this.total2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total2Label.Name = "total2Label";
            this.total2Label.Size = new System.Drawing.Size(48, 20);
            this.total2Label.TabIndex = 64;
            this.total2Label.Text = "Total:";
            // 
            // OrderDGV
            // 
            this.OrderDGV.AllowUserToAddRows = false;
            this.OrderDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OrderDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.OrderDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDGV.Location = new System.Drawing.Point(55, 659);
            this.OrderDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderDGV.Name = "OrderDGV";
            this.OrderDGV.RowHeadersWidth = 62;
            this.OrderDGV.RowTemplate.Height = 30;
            this.OrderDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDGV.Size = new System.Drawing.Size(738, 386);
            this.OrderDGV.TabIndex = 63;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AmountLabel.Location = new System.Drawing.Point(510, 1074);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(170, 32);
            this.AmountLabel.TabIndex = 62;
            this.AmountLabel.Text = "Total Amount";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(880, 1010);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(96, 35);
            this.addButton.TabIndex = 67;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 1217);
            this.ControlBox = false;
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.delete2Button);
            this.Controls.Add(this.refreshOrderButton);
            this.Controls.Add(this.total2Label);
            this.Controls.Add(this.OrderDGV);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.AddProductbutton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.SellingProdName);
            this.Controls.Add(this.SellingDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.SearchCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BillId);
            this.Controls.Add(this.SellingPriceTextBox);
            this.Controls.Add(this.SellingQuantityTextBox);
            this.Name = "CategoryForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SellingDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label totalLabel;
        private TextBox SellingProdName;
        private DataGridView SellingDGV;
        private Label label1;
        private Button refreshButton;
        private ComboBox SearchCb;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox BillId;
        private TextBox SellingPriceTextBox;
        private TextBox SellingQuantityTextBox;
        private Button AddProductbutton;
        private Button delete2Button;
        private Button refreshOrderButton;
        private Label total2Label;
        private DataGridView OrderDGV;
        private Label AmountLabel;
        private Button addButton;
    }
}