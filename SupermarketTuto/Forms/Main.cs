using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketTuto.Forms
{
    public partial class Main : Form
    {
        private System.Windows.Forms.TabControl tabs;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //tabControl
            this.tabs = new TabControl();
            this.SuspendLayout();
            this.tabs.Location = new System.Drawing.Point(50, 50);
            this.tabs.Name = "Test";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new Size(900, 500);
            this.tabs.TabIndex = 0;

            //Form
            this.Controls.Add(tabs);



            TabPage sellers = new TabPage("Sellers");
            tabs.Controls.Add(sellers);
            TabPage products = new TabPage("Products");
            tabs.Controls.Add(products);
            TabPage categories = new TabPage("Categories");
            tabs.Controls.Add(categories);



        }
    }
}
