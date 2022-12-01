namespace SupermarketTuto.Forms
{
    partial class Seller
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
            this.totalLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SellDGV = new System.Windows.Forms.DataGridView();
            this.delete2Button = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SellDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.totalLabel.Location = new System.Drawing.Point(9, 660);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 20);
            this.totalLabel.TabIndex = 114;
            this.totalLabel.Text = "Total:";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchButton.Location = new System.Drawing.Point(199, 203);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(87, 28);
            this.searchButton.TabIndex = 113;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchTextBox.Location = new System.Drawing.Point(7, 205);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(179, 26);
            this.searchTextBox.TabIndex = 112;
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(529, 203);
            this.toDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(117, 26);
            this.toDateTimePicker.TabIndex = 110;
            this.toDateTimePicker.ValueChanged += new System.EventHandler(this.toDateTimePicker_ValueChanged);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(399, 203);
            this.fromDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(119, 26);
            this.fromDateTimePicker.TabIndex = 109;
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.fromDateTimePicker_ValueChanged_1);
            // 
            // SellDGV
            // 
            this.SellDGV.AllowUserToAddRows = false;
            this.SellDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SellDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.SellDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellDGV.Location = new System.Drawing.Point(9, 253);
            this.SellDGV.Name = "SellDGV";
            this.SellDGV.RowHeadersWidth = 62;
            this.SellDGV.RowTemplate.Height = 30;
            this.SellDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellDGV.Size = new System.Drawing.Size(873, 389);
            this.SellDGV.TabIndex = 105;
            this.SellDGV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SellDGV_MouseDown);
            // 
            // delete2Button
            // 
            this.delete2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.delete2Button.Location = new System.Drawing.Point(586, 655);
            this.delete2Button.Name = "delete2Button";
            this.delete2Button.Size = new System.Drawing.Size(74, 30);
            this.delete2Button.TabIndex = 102;
            this.delete2Button.Text = "Delete";
            this.delete2Button.UseVisualStyleBackColor = true;
            this.delete2Button.Click += new System.EventHandler(this.delete2Button_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.editButton.Location = new System.Drawing.Point(507, 655);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(73, 30);
            this.editButton.TabIndex = 101;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click_1);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addButton.Location = new System.Drawing.Point(441, 655);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(62, 30);
            this.addButton.TabIndex = 100;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.add2Button_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.refreshButton.Location = new System.Drawing.Point(784, 213);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(87, 34);
            this.refreshButton.TabIndex = 115;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // exportButton
            // 
            this.exportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.exportButton.Location = new System.Drawing.Point(666, 655);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(68, 30);
            this.exportButton.TabIndex = 124;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.saveButton.Location = new System.Drawing.Point(814, 655);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(68, 30);
            this.saveButton.TabIndex = 123;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // importButton
            // 
            this.importButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.importButton.Location = new System.Drawing.Point(740, 655);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(68, 30);
            this.importButton.TabIndex = 122;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 846);
            this.ControlBox = false;
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.SellDGV);
            this.Controls.Add(this.delete2Button);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Seller";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Seller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SellDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label totalLabel;
        private Button searchButton;
        private TextBox searchTextBox;
        private DateTimePicker toDateTimePicker;
        private DateTimePicker fromDateTimePicker;
        private DataGridView SellDGV;
        private Button delete2Button;
        private Button editButton;
        private Button addButton;
        private Button refreshButton;
        private ContextMenuStrip contextMenuStrip1;
        private Button exportButton;
        private Button saveButton;
        private Button importButton;
    }
}