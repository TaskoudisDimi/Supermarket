using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class CustomObjects
    {
        public Button CreateButton(string text, int left, int top, int width, int height)
        {
            Button button = new Button();
            button.Text = text;
            button.Left = left;
            button.Top = top;
            button.Width = width;
            button.Height = height;

            // Add event handlers here
            button.Click += Button_Click;

            return button;
        }

        public ComboBox CreateComboBox(string[] items, int left, int top, int width, int height)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Items.AddRange(items);
            comboBox.Left = left;
            comboBox.Top = top;
            comboBox.Width = width;
            comboBox.Height = height;

            // Add event handlers here
            comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

            return comboBox;
        }
        public CheckBox CreateCheckBox(string text, int left, int top, int width, int height)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Text = text;
            checkBox.Left = left;
            checkBox.Top = top;
            checkBox.Width = width;
            checkBox.Height = height;

            // Add event handlers here
            checkBox.CheckedChanged += CheckBox_CheckedChanged;

            return checkBox;
        }

        public DataGridView CreateDataGridView(int left, int top, int width, int height)
        {
            DataGridView dataGridView = new DataGridView();
            dataGridView.Left = left;
            dataGridView.Top = top;
            dataGridView.Width = width;
            dataGridView.Height = height;

            // Add event handlers here
            dataGridView.CellValueChanged += DataGridView_CellValueChanged;

            return dataGridView;
        }
        public Label CreateLabel(string text, int left, int top, int width, int height)
        {
            Label label = new Label();
            label.Text = text;
            label.Left = left;
            label.Top = top;
            label.Width = width;
            label.Height = height;

            // Add event handlers here
            label.Click += Label_Click;

            return label;
        }

        public TextBox CreateTextBox(string text, int left, int top, int width, int height)
        {
            TextBox textBox = new TextBox();
            textBox.Text = text;
            textBox.Left = left;
            textBox.Top = top;
            textBox.Width = width;
            textBox.Height = height;

            // Add event handlers here
            textBox.TextChanged += TextBox_TextChanged;

            return textBox;
        }
        // Event handlers for each control type
        private void Button_Click(object sender, EventArgs e)
        {
            // Add custom code here
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Add custom code here
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Add custom code here
        }

        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Add custom code here
        }

        private void Label_Click(object sender, EventArgs e)
        {
            // Add custom code here
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Add custom code here
        }

    }
}
