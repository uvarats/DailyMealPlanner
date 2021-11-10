using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.MVP.Presenter;

namespace WindowsFormsApp1.MVP.View
{
    public interface IAddingView
    {
        int SelectedCategory { get; set; }
        string ProductName { get; set; }
        int Gramms { get; set; }
        double Protein { get; set; }
        double Fats { get; set; }
        double Carbs { get; set; }
        double Calories { get; set; }
        AddingPresenter Presenter { set; }
    }
}
