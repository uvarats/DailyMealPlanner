﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.MVP.Model;
using WindowsFormsApp1.MVP.View;

namespace WindowsFormsApp1.MVP.Presenter
{
    public class MealsPresenter
    {
        private readonly IMainView _view;
        private readonly IMealsRepository _repository;

        public MealsPresenter(IMainView view, IMealsRepository repository)
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
    }
}
