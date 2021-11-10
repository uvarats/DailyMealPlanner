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
        int MealSelectedProduct { get; set; }
        int SelectedMeal { get; set; }

        string CurrentName { get; set; }
        int CurrentGramms { get; set; }
        double CurrentProtein { get; set; }
        double CurrentFats { get; set; }
        double CurrentCarbs { get; set; }
        double CurrentCalories { get; set; }
        double DCR { get; set; }
        
        MealsPresenter MealsPresenter { set; }
    }
}
