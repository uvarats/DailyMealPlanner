using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.MVP.Model;
using WindowsFormsApp1.MVP.View;
using XML;

namespace WindowsFormsApp1.MVP.Presenter
{
    public class MealsPresenter
    {
        private readonly IMainViewMeals _view;
        private readonly IMealsRepository _repository;
        private readonly MainPresenter _mainPresenter;

        public MealsPresenter(IMainViewMeals view, IMealsRepository repository, MainPresenter mainPresenter)
        {
            _view = view;
            _view.MealsPresenter = this;
            _repository = repository;
            _mainPresenter = mainPresenter;

            UpdateMealsBox();
        }
        public void GetMealsCalories()
        {
            _view.MealsCalories = _repository.GetMealsCalories();
        }
        public void UpdateMealsBox()
        {
            var mealsList = from meal in _repository.GetMealsList() select meal.Name;
            _view.MealsList = mealsList.ToList();
            int selectedMeal = _view.SelectedMeal >= 0 ? _view.SelectedMeal : 0;
            _view.MealSelectedProduct = 0;
            _view.SelectedMeal = selectedMeal;
            GetMealsCalories();
        }
        public void UpdateMealProducts()
        {
            var productsList = from product in _repository.GetMealProducts(_view.SelectedMeal) select product.Name;
            _view.MealProductsList = productsList.ToList();
            int mealSelectedProduct = _view.MealSelectedProduct >= 0 ? _view.MealSelectedProduct : 0;
            _view.MealSelectedProduct = mealSelectedProduct;
            GetMealsCalories();
        }
        public void UpdateProductView()
        {
            Product p = _repository.GetProduct(_view.SelectedMeal, _view.MealSelectedProduct);
            _view.CurrentName = p.Name;
            _view.CurrentGramms = p.Gramms;
            //_view.CurrentProtein = p.Protein;
            //_view.CurrentFats = p.Fats;
            //_view.CurrentCarbs = p.Carbs;
            _view.CurrentCalories = p.Calories;
            GetMealsCalories();
        }
        public void NewMeal()
        {
            if (!string.IsNullOrWhiteSpace(_view.NewMealName))
            {
                Meal m = new Meal { Name = _view.NewMealName, Products = new List<Product>() };
                _view.NewMealName = "";
                _repository.Create(m);
                UpdateMealsBox();
            }
            else System.Windows.Forms.MessageBox.Show("Input correct meal name!");
        }
        public void DeleteMeal()
        {
            _repository.Delete(_view.SelectedMeal);
            UpdateMealsBox();
        }
        public void AddProductToMeal()
        {
            if (_view.SelectedMeal != -1)
            {
                Product p = _mainPresenter.GetSelectedProduct();
                _repository.CreateProduct(_view.SelectedMeal, p);
                UpdateMealProducts();
            }
            else System.Windows.Forms.MessageBox.Show("Nothing to delete!");
        }
        public void DeleteFromMeal()
        {
            if (_view.MealSelectedProduct != -1)
            {
                _repository.DeleteProduct(_view.SelectedMeal, _view.MealSelectedProduct);
                UpdateMealProducts();
            }
            else System.Windows.Forms.MessageBox.Show("Nothing to delete!");
        }
        public void SaveToFile()
        {
            _view.SaveDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (_view.SaveDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;

            string fileName = _view.SaveDialog.FileName;
            System.IO.File.WriteAllText(fileName, _repository.ToString());
            System.Windows.Forms.MessageBox.Show("Meals saved to file!");
        }
        public void IncreaseWeight()
        {
            Product p = _repository.GetProduct(_view.SelectedMeal, _view.MealSelectedProduct);
            p.Gramms += 100;
            double increaseCoefficient = p.Gramms * 1.0 / (p.Gramms - 100) * 1.0;
            p.Protein *= increaseCoefficient;
            p.Fats *= increaseCoefficient;
            p.Carbs *= increaseCoefficient;
            p.Calories *= increaseCoefficient;
            _repository.Save();
            UpdateProductView();

        }
    }
}
