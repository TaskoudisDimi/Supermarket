﻿
using DataClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SupermarketTuto.Forms.General
{
    public partial class addEditCategory : Form
    {
        public addEditCategory()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata3 = new SqlConnect();

            try
            {
                loaddata3.execCom("Insert Into CategoryTbl values('" + CatNameTb.Text + "','" + CatDescTb.Text + "','" + dateTimePicker.Value.ToString("MM-dd-yyyy") + "')");
                MessageBox.Show("Success!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            SqlConnect loaddata6 = new SqlConnect();

            try
            {
                if (CatIdTb.Text == "" || CatNameTb.Text == "" || CatDescTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {

                    loaddata6.execCom("Update CategoryTbl set CatName='" + CatNameTb.Text + "',CatDesc='" + CatDescTb.Text + "', Date = '" + dateTimePicker.Value.ToString("MM-dd-yyyy") + "' where CatId=" + CatIdTb.Text);
                    MessageBox.Show("Product Successfully Updated");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
