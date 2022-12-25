namespace SupermarketTuto.Forms
{
    partial class CreateBill
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
            this.commentsLabel = new System.Windows.Forms.Label();
            this.commentsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.refreshBillsButton = new System.Windows.Forms.Button();
            this.total3Label = new System.Windows.Forms.Label();
            this.BillsDGV = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.LabelDate = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.seller_Name_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.commentsLabel.Location = new System.Drawing.Point(464, 183);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(129, 29);
            this.commentsLabel.TabIndex = 66;
            this.commentsLabel.Text = "Comments";
            // 
            // commentsRichTextBox
            // 
            this.commentsRichTextBox.Location = new System.Drawing.Point(467, 223);
            this.commentsRichTextBox.Name = "commentsRichTextBox";
            this.commentsRichTextBox.Size = new System.Drawing.Size(292, 99);
            this.commentsRichTextBox.TabIndex = 64;
            this.commentsRichTextBox.Text = "";
            // 
            // refreshBillsButton
            // 
            this.refreshBillsButton.Location = new System.Drawing.Point(371, 155);
            this.refreshBillsButton.Name = "refreshBillsButton";
            this.refreshBillsButton.Size = new System.Drawing.Size(64, 20);
            this.refreshBillsButton.TabIndex = 63;
            this.refreshBillsButton.Text = "Refresh";
            this.refreshBillsButton.UseVisualStyleBackColor = true;
            this.refreshBillsButton.Click += new System.EventHandler(this.refreshBillsButton_Click);
            // 
            // total3Label
            // 
            this.total3Label.AutoSize = true;
            this.total3Label.Location = new System.Drawing.Point(342, 378);
            this.total3Label.Name = "total3Label";
            this.total3Label.Size = new System.Drawing.Size(34, 13);
            this.total3Label.TabIndex = 62;
            this.total3Label.Text = "Total:";
            // 
            // BillsDGV
            // 
            this.BillsDGV.AllowUserToAddRows = false;
            this.BillsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BillsDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.BillsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillsDGV.Location = new System.Drawing.Point(18, 181);
            this.BillsDGV.Name = "BillsDGV";
            this.BillsDGV.RowHeadersWidth = 62;
            this.BillsDGV.RowTemplate.Height = 30;
            this.BillsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillsDGV.Size = new System.Drawing.Size(417, 180);
            this.BillsDGV.TabIndex = 61;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(90, 367);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(64, 23);
            this.deleteButton.TabIndex = 60;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // billButton
            // 
            this.billButton.Location = new System.Drawing.Point(20, 368);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(64, 23);
            this.billButton.TabIndex = 67;
            this.billButton.Text = "Bill";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LabelDate.Location = new System.Drawing.Point(840, 20);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(74, 32);
            this.LabelDate.TabIndex = 70;
            this.LabelDate.Text = "Date:";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AmountLabel.Location = new System.Drawing.Point(387, 65);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(170, 32);
            this.AmountLabel.TabIndex = 71;
            this.AmountLabel.Text = "Total Amount";
            // 
            // seller_Name_Label
            // 
            this.seller_Name_Label.AutoSize = true;
            this.seller_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.seller_Name_Label.Location = new System.Drawing.Point(12, 20);
            this.seller_Name_Label.Name = "seller_Name_Label";
            this.seller_Name_Label.Size = new System.Drawing.Size(170, 32);
            this.seller_Name_Label.TabIndex = 72;
            this.seller_Name_Label.Text = "Seller Name";
            // 
            // CreateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 501);
            this.Controls.Add(this.seller_Name_Label);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.commentsRichTextBox);
            this.Controls.Add(this.refreshBillsButton);
            this.Controls.Add(this.total3Label);
            this.Controls.Add(this.BillsDGV);
            this.Controls.Add(this.deleteButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateBill";
            this.Text = "addProduct";
            this.Load += new System.EventHandler(this.addProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label commentsLabel;
        private RichTextBox commentsRichTextBox;
        private Button refreshBillsButton;
        private Label total3Label;
        private DataGridView BillsDGV;
        private Button deleteButton;
        private Button billButton;
        private Label LabelDate;
        public Label AmountLabel;
        private Label seller_Name_Label;
    }
}