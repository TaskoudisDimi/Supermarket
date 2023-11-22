namespace SupermarketTuto.Forms
{
    partial class AddEditBill
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
            this.commentsTextBox = new System.Windows.Forms.RichTextBox();
            this.billButton = new System.Windows.Forms.Button();
            this.LabelDate = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.seller_Name_Label = new System.Windows.Forms.Label();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.catListBox = new System.Windows.Forms.ListBox();
            this.prodListBox = new System.Windows.Forms.ListBox();
            this.catLabel = new System.Windows.Forms.Label();
            this.prodLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.commentsLabel.Location = new System.Drawing.Point(18, 167);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(92, 21);
            this.commentsLabel.TabIndex = 66;
            this.commentsLabel.Text = "Comments";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(157, 167);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(207, 69);
            this.commentsTextBox.TabIndex = 64;
            this.commentsTextBox.Text = "";
            // 
            // billButton
            // 
            this.billButton.BackColor = System.Drawing.Color.LightBlue;
            this.billButton.Location = new System.Drawing.Point(40, 310);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(82, 33);
            this.billButton.TabIndex = 67;
            this.billButton.Text = "Bill";
            this.billButton.UseVisualStyleBackColor = false;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LabelDate.Location = new System.Drawing.Point(36, 121);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(46, 21);
            this.LabelDate.TabIndex = 70;
            this.LabelDate.Text = "Date";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AmountLabel.Location = new System.Drawing.Point(10, 75);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(114, 21);
            this.AmountLabel.TabIndex = 71;
            this.AmountLabel.Text = "Total Amount";
            // 
            // seller_Name_Label
            // 
            this.seller_Name_Label.AutoSize = true;
            this.seller_Name_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.seller_Name_Label.Location = new System.Drawing.Point(10, 26);
            this.seller_Name_Label.Name = "seller_Name_Label";
            this.seller_Name_Label.Size = new System.Drawing.Size(103, 21);
            this.seller_Name_Label.TabIndex = 72;
            this.seller_Name_Label.Text = "Seller Name";
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Enabled = false;
            this.totalAmountTextBox.Location = new System.Drawing.Point(157, 75);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalAmountTextBox.TabIndex = 115;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(157, 121);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateTextBox.TabIndex = 116;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(157, 29);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 117;
            // 
            // catListBox
            // 
            this.catListBox.FormattingEnabled = true;
            this.catListBox.Location = new System.Drawing.Point(446, 45);
            this.catListBox.Name = "catListBox";
            this.catListBox.Size = new System.Drawing.Size(304, 95);
            this.catListBox.TabIndex = 118;
            // 
            // prodListBox
            // 
            this.prodListBox.FormattingEnabled = true;
            this.prodListBox.Location = new System.Drawing.Point(446, 202);
            this.prodListBox.Name = "prodListBox";
            this.prodListBox.Size = new System.Drawing.Size(304, 95);
            this.prodListBox.TabIndex = 119;
            // 
            // catLabel
            // 
            this.catLabel.AutoSize = true;
            this.catLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.catLabel.Location = new System.Drawing.Point(446, 13);
            this.catLabel.Name = "catLabel";
            this.catLabel.Size = new System.Drawing.Size(91, 21);
            this.catLabel.TabIndex = 120;
            this.catLabel.Text = "Categories";
            // 
            // prodLabel
            // 
            this.prodLabel.AutoSize = true;
            this.prodLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.prodLabel.Location = new System.Drawing.Point(443, 165);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(77, 21);
            this.prodLabel.TabIndex = 121;
            this.prodLabel.Text = "Products";
            // 
            // AddEditBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 379);
            this.Controls.Add(this.prodLabel);
            this.Controls.Add(this.catLabel);
            this.Controls.Add(this.prodListBox);
            this.Controls.Add(this.catListBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.totalAmountTextBox);
            this.Controls.Add(this.seller_Name_Label);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.commentsTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddEditBill";
            this.Text = "Add Bill";
            this.Load += new System.EventHandler(this.addProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label commentsLabel;
        private RichTextBox commentsTextBox;
        private Button billButton;
        private Label LabelDate;
        public Label AmountLabel;
        private Label seller_Name_Label;
        private TextBox totalAmountTextBox;
        private TextBox dateTextBox;
        private TextBox nameTextBox;
        private ListBox catListBox;
        private ListBox prodListBox;
        private Label catLabel;
        private Label prodLabel;
    }
}