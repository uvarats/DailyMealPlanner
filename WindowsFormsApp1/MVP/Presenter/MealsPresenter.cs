using System;
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
        }
    }
}
