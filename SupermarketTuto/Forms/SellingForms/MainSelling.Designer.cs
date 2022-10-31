namespace SupermarketTuto.Forms.SellingForms
{
    partial class MainSelling
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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.categoriesProductsButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.createBillButton = new System.Windows.Forms.Button();
            this.seller_Name_Label = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sidePanel.Controls.Add(this.categoriesProductsButton);
            this.sidePanel.Controls.Add(this.billButton);
            this.sidePanel.Controls.Add(this.createBillButton);
            this.sidePanel.Controls.Add(this.seller_Name_Label);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(245, 1305);
            this.sidePanel.TabIndex = 69;
            // 
            // categoriesProductsButton
            // 
            this.categoriesProductsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.categoriesProductsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoriesProductsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.categoriesProductsButton.Location = new System.Drawing.Point(28, 176);
            this.categoriesProductsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoriesProductsButton.Name = "categoriesProductsButton";
            this.categoriesProductsButton.Size = new System.Drawing.Size(188, 73);
            this.categoriesProductsButton.TabIndex = 5;
            this.categoriesProductsButton.Text = "Categories/Products";
            this.categoriesProductsButton.UseVisualStyleBackColor = false;
            this.categoriesProductsButton.Click += new System.EventHandler(this.categoriesProductsButton_Click);
            // 
            // billButton
            // 
            this.billButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.billButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.billButton.Location = new System.Drawing.Point(28, 396);
            this.billButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(188, 66);
            this.billButton.TabIndex = 4;
            this.billButton.Text = "Bill";
            this.billButton.UseVisualStyleBackColor = false;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // createBillButton
            // 
            this.createBillButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createBillButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createBillButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.createBillButton.Location = new System.Drawing.Point(28, 290);
            this.createBillButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createBillButton.Name = "createBillButton";
            this.createBillButton.Size = new System.Drawing.Size(188, 66);
            this.createBillButton.TabIndex = 3;
            this.createBillButton.Text = "Create Bill";
            this.createBillButton.UseVisualStyleBackColor = false;
            this.createBillButton.Click += new System.EventHandler(this.createBillButton_Click);
            // 
            // seller_Name_Label
            // 
            this.seller_Name_Label.AutoSize = true;
            this.seller_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.seller_Name_Label.Location = new System.Drawing.Point(34, 99);
            this.seller_Name_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seller_Name_Label.Name = "seller_Name_Label";
            this.seller_Name_Label.Size = new System.Drawing.Size(170, 32);
            this.seller_Name_Label.TabIndex = 0;
            this.seller_Name_Label.Text = "Seller Name";
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(245, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(2098, 1305);
            this.mainPanel.TabIndex = 70;
            // 
            // MainSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2343, 1305);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.Name = "MainSelling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel sidePanel;
        private Button billButton;
        private Button createBillButton;
        private Label seller_Name_Label;
        private Panel mainPanel;
        private Button categoriesProductsButton;
    }
}