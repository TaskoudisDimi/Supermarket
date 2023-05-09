namespace SupermarketTuto.Forms.SellingForms
{
    partial class CreateBillForm
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
            this.SellingDGV = new System.Windows.Forms.DataGridView();
            this.SearchCb = new System.Windows.Forms.ComboBox();
            this.AddProductbutton = new System.Windows.Forms.Button();
            this.delete2Button = new System.Windows.Forms.Button();
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
            // SellingDGV
            // 
            this.SellingDGV.AllowUserToAddRows = false;
            this.SellingDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SellingDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SellingDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.SellingDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellingDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellingDGV.Location = new System.Drawing.Point(56, 145);
            this.SellingDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellingDGV.Name = "SellingDGV";
            this.SellingDGV.RowHeadersWidth = 62;
            this.SellingDGV.RowTemplate.Height = 30;
            this.SellingDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellingDGV.Size = new System.Drawing.Size(738, 332);
            this.SellingDGV.TabIndex = 59;
            this.SellingDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellingDGV_CellClick);
            // 
            // SearchCb
            // 
            this.SearchCb.FormattingEnabled = true;
            this.SearchCb.Location = new System.Drawing.Point(56, 95);
            this.SearchCb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchCb.Name = "SearchCb";
            this.SearchCb.Size = new System.Drawing.Size(136, 28);
            this.SearchCb.TabIndex = 57;
            this.SearchCb.Text = "Select Category";
            this.SearchCb.SelectionChangeCommitted += new System.EventHandler(this.SearchCb_SelectionChangeCommitted);
            // 
            // AddProductbutton
            // 
            this.AddProductbutton.Location = new System.Drawing.Point(312, 571);
            this.AddProductbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddProductbutton.Name = "AddProductbutton";
            this.AddProductbutton.Size = new System.Drawing.Size(177, 49);
            this.AddProductbutton.TabIndex = 61;
            this.AddProductbutton.Text = "Add to Pre Bills";
            this.AddProductbutton.UseVisualStyleBackColor = true;
            this.AddProductbutton.Click += new System.EventHandler(this.AddProductbutton_Click);
            // 
            // delete2Button
            // 
            this.delete2Button.Location = new System.Drawing.Point(260, 1063);
            this.delete2Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delete2Button.Name = "delete2Button";
            this.delete2Button.Size = new System.Drawing.Size(96, 31);
            this.delete2Button.TabIndex = 66;
            this.delete2Button.Text = "Delete";
            this.delete2Button.UseVisualStyleBackColor = true;
            this.delete2Button.Click += new System.EventHandler(this.delete2Button_Click);
            // 
            // total2Label
            // 
            this.total2Label.AutoSize = true;
            this.total2Label.Location = new System.Drawing.Point(51, 1074);
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
            this.OrderDGV.Location = new System.Drawing.Point(56, 658);
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
            this.AmountLabel.Location = new System.Drawing.Point(530, 1060);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(170, 32);
            this.AmountLabel.TabIndex = 62;
            this.AmountLabel.Text = "Total Amount";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(846, 831);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(96, 35);
            this.addButton.TabIndex = 67;
            this.addButton.Text = "Bill";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // CreateBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 1163);
            this.ControlBox = false;
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.delete2Button);
            this.Controls.Add(this.total2Label);
            this.Controls.Add(this.OrderDGV);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.AddProductbutton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.SellingDGV);
            this.Controls.Add(this.SearchCb);
            this.Name = "CreateBillForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SellingDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label totalLabel;
        private DataGridView SellingDGV;
        private ComboBox SearchCb;
        private Button AddProductbutton;
        private Button delete2Button;
        private Label total2Label;
        private DataGridView OrderDGV;
        private Label AmountLabel;
        private Button addButton;
    }
}