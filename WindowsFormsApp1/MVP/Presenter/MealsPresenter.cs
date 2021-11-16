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

        public MealsPresenter(IMainViewMeals view, IMealsRepository repository)
        {
            _view = view;
            _view.MealsPresenter = this;
            _repository = repository;

            UpdateMealsBox();
        }
        public void UpdateMealsBox()
        {
            var mealsList = from meal in _repository.GetMealsList() select meal.Name;
            int selectedMeal = _view.SelectedMeal >= 0 ? _view.SelectedMeal : 0;
            _view.MealsList = mealsList.ToList();
            _view.MealSelectedProduct = 0;
            _view.SelectedMeal = selectedMeal;
        }
        public void UpdateMealProducts()
        {
            var productsList = from product in _repository.GetMealProducts(_view.SelectedMeal) select product.Name;
            int mealSelectedProduct = _view.MealSelectedProduct >= 0 ? _view.MealSelectedProduct : 0;
            _view.MealProductsList = productsList.ToList();
            _view.MealSelectedProduct = mealSelectedProduct;
        }
        public void UpdateProductView()
        {
            Product p = _repository.GetProduct(_view.SelectedMeal, _view.MealSelectedProduct);
            _view.CurrentName = p.Name;
            _view.CurrentGramms = p.Gramms;
            _view.CurrentProtein = p.Protein;
            _view.CurrentFats = p.Fats;
            _view.CurrentCarbs = p.Carbs;
            _view.CurrentCalories = p.Calories;
        }
    }
}
