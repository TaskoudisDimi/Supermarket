using ClassLibrary1;
using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SupermarketTuto.Forms.General
{
    public partial class addEditAdmin : Form
    {
        DataTable adminTable = new DataTable();
        DataGridViewRow selected = new DataGridViewRow();
        public event EventHandler<DataGridViewCellChange> DataChanged;
        Admins admin = new Admins();
        public event EventHandler<AdminsEventArgs> ItemCreated;
        public event EventHandler<AdminsEventArgs> ItemEdited;


        public addEditAdmin(DataTable adminTable_, DataGridViewRow selected_, bool add)
        {
            InitializeComponent();
            adminTable = adminTable_;
            selected = selected_;

            if (add)
            {
                editButton.Enabled = false;
            }
            else
            {
                //AdminIdTb.Text = selected.Cells["CatId"].Value.ToString();
                //AdminNameTb.Text = selected.Cells["CatName"].Value.ToString();
                //AdminPassTb.Text = selected.Cells["CatDesc"].Value.ToString();
                //activeCheckBox.Checked = (bool)selected["Active"];
                //superAdminCheckBox.Checked = (bool)selected["Active"];
                //addButton.Visible = false;
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                admin.UserName = AdminNameTb.Text;
                admin.Password = AdminPassTb.Text;
                if (activeCheckBox.Checked)
                {
                    admin.Active = true;
                }
                else
                {
                    admin.Active = false;
                }
                admin.isSuperAdmin = null;

                DataModel.Create<Admins>(admin);
                OnItemCreated(new AdminsEventArgs(admin, admin.Id));

                MessageBox.Show($"Successfully inserted Admin {admin.UserName}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        protected virtual void OnItemCreated(AdminsEventArgs e)
        {
            ItemCreated?.Invoke(this, e);

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (AdminIdTb.Text == "" || AdminNameTb.Text == "" || AdminPassTb.Text == "")
            //    {
            //        MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        category.CatId = Convert.ToInt32(AdminIdTb.Text);
            //        category.CatDesc = AdminPassTb.Text;
            //        category.CatName = AdminNameTb.Text;
            //        category.Date = (DateTime)dateTimePicker.Value.Date;
            //        DataModel.Update<CategoryTbl>(category);
            //        OnItemEdited(new CategoryEventArgs(category, category.CatId));
            //        //GetChanges(table, row);
            //        MessageBox.Show($"Successfully inserted Category {category.CatName}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        protected virtual void OnItemEdited(AdminsEventArgs e)
        {
            ItemEdited?.Invoke(this, e);

        }


    }

    public class AdminsEventArgs : EventArgs
    {
        public Admins CreatedAdmin { get; private set; }
        public int PrimaryKeyValue { get; private set; }

        public AdminsEventArgs(Admins admin, int primaryKeyValue)
        {
            CreatedAdmin = admin;
            PrimaryKeyValue = primaryKeyValue;
        }
    }
}
