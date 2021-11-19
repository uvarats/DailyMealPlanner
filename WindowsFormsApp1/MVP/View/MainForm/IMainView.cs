using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.MVP.Presenter;

namespace WindowsFormsApp1.MVP.View
{
    public partial interface IMainView
    {
        IList<string> CategoriesList { get; set; }
        IList<string> ProductsList { get; set; }
        int SelectedCategory { get; set; }
        int SelectedProduct { get; set; }
        string ProductName { get; set; }
        int Gramms { get; set; }
        double Protein { get; set; }
        double Fats { get; set; }
        double Carbs { get; set; }
        double Calories { get; set; }
        double DCR { get; set; }
        string FindField { get; set; }
        MainPresenter Presenter { set; }
    }
}
