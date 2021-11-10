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
    public class CategoryAddingPresenter
    {
        private readonly ICategoryView _view;
        private readonly IDbRepository _repository;
        private readonly MainPresenter _mainPresenter;
        public CategoryAddingPresenter(ICategoryView view, MainPresenter mainPresenter)
        {
            _mainPresenter = mainPresenter;
            _view = view;
            _view.Presenter = this;
            _repository = _mainPresenter.GetRepository();
        }
        public void NewCategory()
        {
            _repository.CreateCategory(_view.NameField, _view.Description);
            _mainPresenter.UpdateCategoriesBox();
        }
    }
}
