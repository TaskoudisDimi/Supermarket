namespace SupermarketTuto.Forms.AdminForms
{
    partial class SelectedProducts
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
            this.SelectedProdDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedProdDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedProdDGV
            // 
            this.SelectedProdDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SelectedProdDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.SelectedProdDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectedProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedProdDGV.Location = new System.Drawing.Point(33, 60);
            this.SelectedProdDGV.Name = "SelectedProdDGV";
            this.SelectedProdDGV.RowHeadersWidth = 62;
            this.SelectedProdDGV.RowTemplate.Height = 30;
            this.SelectedProdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelectedProdDGV.Size = new System.Drawing.Size(1089, 329);
            this.SelectedProdDGV.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 105;
            this.label1.Text = "Selected Products";
            // 
            // SelectedProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectedProdDGV);
            this.Name = "SelectedProducts";
            this.Text = "Selected Products";
            this.Load += new System.EventHandler(this.SelectedProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedProdDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView SelectedProdDGV;
        private Label label1;
    }
}