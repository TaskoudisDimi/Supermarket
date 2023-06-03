using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketTuto.Forms.General
{
    public partial class ExceptionForm : Form
    {
        public ExceptionForm(string message, string stackTrace)
        {
            InitializeComponent();

            messageTextBox.Text = message;
            stachTraceTextBox.Text = stackTrace;
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Are you sure to close the app?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                this.Close();
            }
        }

        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            //TO DO: send email
        }
    }
}
