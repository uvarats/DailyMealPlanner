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
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly IDbRepository _repository;
        private readonly IDataRepository _userData;

        public MainPresenter(IMainView view, IDbRepository repository, IDataRepository userData)
        {
            _view = view;
            _view.Presenter = this;
            _repository = repository;
            _userData = userData;

            UpdateCategoriesBox();
            //UpdateProductsListBox();
            UpdateDCR();
        }

        public Product GetSelectedProduct()
        {
            return _repository.GetByID(_view.SelectedCategory, _view.SelectedProduct);
        }
        public IDataRepository GetDataRepository()
        {
            return _userData;
        }

        public IDbRepository GetRepository()
        {
            return _repository;
        }
        public void UpdateDCR()
        {
            _view.DCR = _userData.GetDCR();
        }
        public void UpdateCategoriesBox()
        {
            var categoriesList = from category in _repository.GetCategoriesList() select category.Name;
            int selectedCategory = _view.SelectedCategory >= 0 ? _view.SelectedCategory : 0;
            _view.CategoriesList = categoriesList.ToList();
            _view.SelectedProduct = 0;
            _view.SelectedCategory = selectedCategory;
        }
        public void UpdateCategoriesView()
        {
            Category c = _repository.GetCategoryByID(_view.CategoriesBoxSelected);
            _view.CategoryName = c.Name;
            _view.Description = c.Description;
        }
        public void UpdateProductsListBox()
        {
            var productsList = from product in _repository.GetProductsList(_view.SelectedCategory) select product.Name;
            _view.ProductsList = productsList.ToList();
            int selectedProduct = _view.SelectedProduct >= 0 ? _view.SelectedProduct : 0;
            _view.SelectedProduct = selectedProduct;
        }

        public void UpdateProductView()
        {
            Product product = _repository.GetByID(_view.SelectedCategory, _view.SelectedProduct);
            _view.ProductName = product.Name;
            _view.Gramms = product.Gramms;
            _view.Protein = product.Protein;
            _view.Fats = product.Fats;
            _view.Carbs = product.Carbs;
            _view.Calories = product.Calories;
        }
        public void SaveProduct()
        {
            Product p = new Product 
            { 
                Name = _view.ProductName,
                Gramms = _view.Gramms,
                Protein = _view.Protein,
                Fats = _view.Fats,
                Carbs = _view.Carbs,
                Calories = _view.Calories 
            };
            _repository.Update(_view.SelectedCategory, _view.SelectedProduct, p);
            UpdateProductsListBox();
        }
        public void DeleteProduct()
        {
            _repository.Delete(_view.SelectedCategory, _view.SelectedProduct);
            UpdateProductsListBox();
        }
        public void DeleteCategory()
        {
            _repository.RemoveCategory(_view.SelectedCategory);
            UpdateCategoriesBox();
        }
        public void SaveCategory()
        {
            Category c = _repository.GetCategoryByID(_view.SelectedCategory);
            c.Name = _view.CategoryName;
            c.Description = _view.Description;
            _repository.Save();
            UpdateCategoriesBox();
        }
    }
}
