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
    public class AddingPresenter
    {
        private readonly IAddingView _view;
        private readonly IDbRepository _repository;
        private readonly MainPresenter _mainPresenter;

        public AddingPresenter(IAddingView view, MainPresenter mainPresenter)
        {
            _mainPresenter = mainPresenter;
            _view = view;
            _view.Presenter = this;
            _repository = _mainPresenter.GetRepository();
        }
        public void AddProduct()
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
            _repository.Create(_view.SelectedCategory, p);
            _mainPresenter.UpdateProductsListBox();
        }
    }
}
