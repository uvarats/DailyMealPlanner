using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.MVP.Presenter;

namespace WindowsFormsApp1.MVP.View
{
    public partial class ProductAdding : Form, IAddingView
    {
        public ProductAdding(int selectedCategory)
        {
            InitializeComponent();
            SelectedCategory = selectedCategory;
        }

        public int Gramms
        {
            get
            {
                int result;
                if (!int.TryParse(grammsField.Text, out result))
                {
                    return 0;
                }
                return result;
            }
            set => grammsField.Text = value.ToString();
        }
        public double Protein
        {
            get => decimal.ToDouble(proteinField.Value);
            set => proteinField.Value = Convert.ToDecimal(value);
        }
        public double Fats
        {
            get => decimal.ToDouble(fatsField.Value);
            set => fatsField.Value = Convert.ToDecimal(value);
        }
        public double Carbs
        {
            get => decimal.ToDouble(carbsField.Value);
            set => carbsField.Value = Convert.ToDecimal(value);
        }
        public double Calories
        {
            get => decimal.ToDouble(caloriesField.Value);
            set => caloriesField.Value = Convert.ToDecimal(value);
        }
        public AddingPresenter Presenter { private get; set; }
        string IAddingView.ProductName 
        {
            get => nameField.Text;
            set => nameField.Text = value;
        }
        public int SelectedCategory { get; set; }

        private void ProductAdding_Load(object sender, EventArgs e)
        {
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool added = false;
            if(!string.IsNullOrWhiteSpace(nameField.Text) && !string.IsNullOrEmpty(grammsField.Text))
            {
                Presenter.AddProduct();
                added = true;
            }

            if (added)
            {
                MessageBox.Show("Product added to current category.");
                Close();
            }
            
        }

        private void grammsField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}
