namespace SupermarketTuto.Forms
{
    partial class AddBill
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
            this.components = new System.ComponentModel.Container();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.commentsTextBox = new System.Windows.Forms.RichTextBox();
            this.refreshBillsButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.BillsDGV = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.LabelDate = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.seller_Name_Label = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.commentsLabel.Location = new System.Drawing.Point(1126, 37);
            this.commentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(129, 29);
            this.commentsLabel.TabIndex = 66;
            this.commentsLabel.Text = "Comments";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(1132, 88);
            this.commentsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(308, 104);
            this.commentsTextBox.TabIndex = 64;
            this.commentsTextBox.Text = "";
            // 
            // refreshBillsButton
            // 
            this.refreshBillsButton.Location = new System.Drawing.Point(978, 234);
            this.refreshBillsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refreshBillsButton.Name = "refreshBillsButton";
            this.refreshBillsButton.Size = new System.Drawing.Size(96, 31);
            this.refreshBillsButton.TabIndex = 63;
            this.refreshBillsButton.Text = "Refresh";
            this.refreshBillsButton.UseVisualStyleBackColor = true;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(988, 562);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 20);
            this.totalLabel.TabIndex = 62;
            this.totalLabel.Text = "Total:";
            // 
            // BillsDGV
            // 
            this.BillsDGV.AllowUserToAddRows = false;
            this.BillsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BillsDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.BillsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillsDGV.Location = new System.Drawing.Point(304, 274);
            this.BillsDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BillsDGV.Name = "BillsDGV";
            this.BillsDGV.RowHeadersWidth = 62;
            this.BillsDGV.RowTemplate.Height = 30;
            this.BillsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillsDGV.Size = new System.Drawing.Size(770, 277);
            this.BillsDGV.TabIndex = 61;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(410, 560);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(96, 35);
            this.deleteButton.TabIndex = 60;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // billButton
            // 
            this.billButton.Location = new System.Drawing.Point(304, 562);
            this.billButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(96, 35);
            this.billButton.TabIndex = 67;
            this.billButton.Text = "Bill";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LabelDate.Location = new System.Drawing.Point(728, 31);
            this.LabelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(74, 32);
            this.LabelDate.TabIndex = 70;
            this.LabelDate.Text = "Date:";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AmountLabel.Location = new System.Drawing.Point(356, 34);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(170, 32);
            this.AmountLabel.TabIndex = 71;
            this.AmountLabel.Text = "Total Amount";
            // 
            // seller_Name_Label
            // 
            this.seller_Name_Label.AutoSize = true;
            this.seller_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.seller_Name_Label.Location = new System.Drawing.Point(3, 37);
            this.seller_Name_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seller_Name_Label.Name = "seller_Name_Label";
            this.seller_Name_Label.Size = new System.Drawing.Size(170, 32);
            this.seller_Name_Label.TabIndex = 72;
            this.seller_Name_Label.Text = "Seller Name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Location = new System.Drawing.Point(534, 37);
            this.totalAmountTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(148, 26);
            this.totalAmountTextBox.TabIndex = 115;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(810, 37);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(148, 26);
            this.dateTextBox.TabIndex = 116;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(181, 41);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(148, 26);
            this.nameTextBox.TabIndex = 117;
            // 
            // AddBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 669);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.totalAmountTextBox);
            this.Controls.Add(this.seller_Name_Label);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.refreshBillsButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.BillsDGV);
            this.Controls.Add(this.deleteButton);
            this.Name = "AddBill";
            this.Text = "Add Bill";
            this.Load += new System.EventHandler(this.addProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label commentsLabel;
        private RichTextBox commentsTextBox;
        private Button refreshBillsButton;
        private Label totalLabel;
        private DataGridView BillsDGV;
        private Button deleteButton;
        private Button billButton;
        private Label LabelDate;
        public Label AmountLabel;
        private Label seller_Name_Label;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox totalAmountTextBox;
        private TextBox dateTextBox;
        private TextBox nameTextBox;
    }
}