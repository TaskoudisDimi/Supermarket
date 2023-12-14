using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketTuto.Forms.AdminForms
{
    public partial class RestoreDB : Form
    {
        public RestoreDB()
        {
            InitializeComponent();
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            DataModel.RestoreDB(backupFileTextBox.Text);
        }

        private void backupFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Title = "Browse Backup File",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "bak files (*.bak)|*.bak",
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                backupFileTextBox.Text = dialog.FileName;
            }
        }

    }
}
