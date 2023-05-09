namespace SupermarketTuto.Forms.SellingForms
{
    partial class Bills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bills));
            this.BillsDGV = new System.Windows.Forms.DataGridView();
            this.total3Label = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.importCombobox = new System.Windows.Forms.ComboBox();
            this.exportCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // BillsDGV
            // 
            this.BillsDGV.AllowUserToAddRows = false;
            this.BillsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BillsDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.BillsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillsDGV.Location = new System.Drawing.Point(12, 38);
            this.BillsDGV.Name = "BillsDGV";
            this.BillsDGV.RowHeadersWidth = 62;
            this.BillsDGV.RowTemplate.Height = 30;
            this.BillsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillsDGV.Size = new System.Drawing.Size(492, 208);
            this.BillsDGV.TabIndex = 64;
            // 
            // total3Label
            // 
            this.total3Label.AutoSize = true;
            this.total3Label.Location = new System.Drawing.Point(420, 262);
            this.total3Label.Name = "total3Label";
            this.total3Label.Size = new System.Drawing.Size(34, 13);
            this.total3Label.TabIndex = 69;
            this.total3Label.Text = "Total:";
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(12, 252);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(64, 23);
            this.PrintButton.TabIndex = 68;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // importCombobox
            // 
            this.importCombobox.FormattingEnabled = true;
            this.importCombobox.Location = new System.Drawing.Point(98, 254);
            this.importCombobox.Name = "importCombobox";
            this.importCombobox.Size = new System.Drawing.Size(98, 21);
            this.importCombobox.TabIndex = 144;
            this.importCombobox.Text = "Import";
            this.importCombobox.SelectedValueChanged += new System.EventHandler(this.importCombobox_SelectedValueChanged);
            // 
            // exportCombobox
            // 
            this.exportCombobox.FormattingEnabled = true;
            this.exportCombobox.Location = new System.Drawing.Point(202, 254);
            this.exportCombobox.Name = "exportCombobox";
            this.exportCombobox.Size = new System.Drawing.Size(98, 21);
            this.exportCombobox.TabIndex = 143;
            this.exportCombobox.Text = "Export";
            this.exportCombobox.SelectedValueChanged += new System.EventHandler(this.exportCombobox_SelectedValueChanged);
            // 
            // Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 371);
            this.ControlBox = false;
            this.Controls.Add(this.importCombobox);
            this.Controls.Add(this.exportCombobox);
            this.Controls.Add(this.total3Label);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.BillsDGV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bills";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Bills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView BillsDGV;
        private Label total3Label;
        private Button PrintButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private ComboBox importCombobox;
        private ComboBox exportCombobox;
    }
}