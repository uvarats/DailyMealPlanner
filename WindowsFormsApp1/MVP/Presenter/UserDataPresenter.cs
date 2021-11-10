using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.MVP.Model;
using WindowsFormsApp1.MVP.View;

namespace WindowsFormsApp1.MVP.Presenter
{
    public class UserDataPresenter
    {
        private readonly IUDataView _view;
        private readonly IDataRepository _repository;
        private readonly MainPresenter _mainPresenter;

        public UserDataPresenter(IUDataView view, MainPresenter mainPresenter)
        {
            _view = view;
            _view.Presenter = this;
            _mainPresenter = mainPresenter;
            _repository = _mainPresenter.GetDataRepository();

            _view.ActivityBox = Enum.GetNames(typeof(DailyActivity));
            UpdateUserDataView();
        }
        public void UpdateUserDataView()
        {
            _view.Weight = _repository.Weight;
            _view.UHeight = _repository.Height;
            _view.Age = _repository.Age;
            _view.SelectedActivity = (int) _repository.Activity;
            _view.CurrentDCR = _repository.GetDCR();
            _mainPresenter.UpdateDCR();
        }
        public void Save()
        {
            _repository.SetUserData(_view.Weight, _view.UHeight, _view.Age, (DailyActivity) _view.SelectedActivity);
        }
    }
}
