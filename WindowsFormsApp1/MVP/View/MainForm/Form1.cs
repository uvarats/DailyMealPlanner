using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1.MVP;
using WindowsFormsApp1.MVP.Model;
using WindowsFormsApp1.MVP.Presenter;
using WindowsFormsApp1.MVP.View;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form, IMainView, IMainViewMeals
    {

        private bool _isEditModeProduct = false;
        private bool _isEditModeCategory = false;

        public IList<string> CategoriesList
        {
            get => (IList<string>)categoriesCombo.DataSource;
            set
            {
                categoriesCombo.DataSource = value;
                categoriesBox.DataSource = value;
                categoryCombo2.DataSource = value;
            }
        }
        #region ProductView
        public IList<string> ProductsList 
        {
            get => (IList<string>)productsBox.DataSource;
            set
            {
                productsBox.DataSource = value;
                productsBox2.DataSource = value;
            }
        }
        public int SelectedCategory
        {
            get => categoriesCombo.SelectedIndex;
            set
            {
                if (value < CategoriesList.Count)
                {
                    categoriesCombo.SelectedIndex = value;
                }
                else categoriesCombo.SelectedIndex = 0;
            }
        }
        public int SelectedProduct
        {
            get => productsBox.SelectedIndex;
            set
            {
                if (ProductsList.Count > 0)
                {
                    if (value < ProductsList.Count)
                    {
                        productsBox.SelectedIndex = value;
                    }
                    else productsBox.SelectedIndex = 0;
                    
                }
            }
        }
        string IMainView.ProductName
        {
            get => productName.Text;
            set => productName.Text = value;
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
        #endregion
        public MainPresenter Presenter { private get; set; }

        #region CategoryView
        public int CategoriesBoxSelected { get => categoriesBox.SelectedIndex; set => categoriesBox.SelectedIndex = value; }
        public string CategoryName { get => categoryName.Text; set => categoryName.Text = value; }
        public string Description { get => descriptionField.Text; set => descriptionField.Text = value; }

        #endregion
        #region MealsView
        public double DCR { get => Convert.ToDouble(dcrLabel.Text); set => dcrLabel.Text = value.ToString(); }
        public MealsPresenter MealsPresenter { private get; set; }
        public int MealSelectedProduct 
        {
            get => addedProducts.SelectedIndex;
            set
            {
                if (value < MealProductsList.Count)
                {
                    addedProducts.SelectedIndex = value;
                }
                else addedProducts.SelectedIndex = 0;
            }
        }
        public int SelectedMeal 
        {
            get => mealsBox.SelectedIndex;
            set
            {
                if (value < MealsList.Count)
                {
                    mealsBox.SelectedIndex = value;
                } else mealsBox.SelectedIndex = 0;
            }
        }
        public string CurrentName { get => mealProductNameField.Text; set => mealProductNameField.Text = value; }
        public int CurrentGramms { get => int.Parse(mealGrammsField.Text); set => mealGrammsField.Text = value.ToString(); }
        public double CurrentProtein { get => Convert.ToDouble(mealProteinField.Text); set => mealProteinField.Text = value.ToString(); }
        public double CurrentFats { get => Convert.ToDouble(mealFatsField.Text); set => mealFatsField.Text = value.ToString(); }
        public double CurrentCarbs { get => Convert.ToDouble(mealsCarbsField.Text); set => mealsCarbsField.Text = value.ToString(); }
        public double CurrentCalories { get => Convert.ToDouble(mealCaloriesField.Text); set => mealCaloriesField.Text = value.ToString(); }
        public IList<string> MealsList { get => (IList<string>)mealsBox.DataSource; set => mealsBox.DataSource = value; }
        public IList<string> MealProductsList { get => (IList<string>)addedProducts.DataSource; set => addedProducts.DataSource = value; }
        #endregion

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.UpdateProductsListBox();
            //SelectedProduct = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this item?\n\nChanges cannot be undone.",
                                     "Delete confirmation.",
                                     MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Presenter.DeleteProduct();
            }
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < productsBox.Items.Count; i++)
            {
                if (((string)productsBox.Items[i]).Contains(textBox1.Text))
                {
                    productsBox.SelectedIndex = i;
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productName.ReadOnly = _isEditModeProduct;
            grammsField.ReadOnly = _isEditModeProduct;
            proteinField.ReadOnly = _isEditModeProduct;
            fatsField.ReadOnly = _isEditModeProduct;
            carbsField.ReadOnly = _isEditModeProduct;
            caloriesField.ReadOnly = _isEditModeProduct;

            _isEditModeProduct = !_isEditModeProduct;

            button2.Text = _isEditModeProduct ? "Save" : "Edit";

            if (!_isEditModeProduct)
            {
                Presenter.SaveProduct();
            }
        }

        private void productsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.UpdateProductView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var view = new ProductAdding(SelectedCategory);
            var presenter = new AddingPresenter(view, Presenter);
            view.StartPosition = FormStartPosition.CenterParent;
            view.ShowDialog();
        }

        private void categoriesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Presenter.UpdateCategoriesView();
        }

        private void categoryEditButton_Click(object sender, EventArgs e)
        {
            categoryName.ReadOnly = _isEditModeCategory;
            descriptionField.ReadOnly = _isEditModeCategory;

            _isEditModeCategory = !_isEditModeCategory;

            categoryEditButton.Text = _isEditModeCategory ? "Save" : "Edit";

            if (!_isEditModeCategory)
            {
                Presenter.SaveProduct();
            }
        }

        private void newCategoryButton_Click(object sender, EventArgs e)
        {
            var view = new CategoryAdding();
            var presenter = new CategoryAddingPresenter(view, Presenter);
            view.StartPosition = FormStartPosition.CenterParent;
            view.ShowDialog();
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            Presenter.DeleteCategory();
        }

        private void userDataButton_Click(object sender, EventArgs e)
        {
            var view = new UserDataForm();
            var presenter = new UserDataPresenter(view, Presenter);
            view.StartPosition = FormStartPosition.CenterParent;
            view.ShowDialog();
        }

        private void grammsField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void mealsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MealsPresenter.UpdateMealProducts();
        }

        private void addedProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            MealsPresenter.UpdateProductView();
        }
    }
}