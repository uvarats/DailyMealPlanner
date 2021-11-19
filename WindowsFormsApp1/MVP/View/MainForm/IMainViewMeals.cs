using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.MVP.Presenter;

namespace WindowsFormsApp1.MVP.View
{
    public interface IMainViewMeals
    {
        IList<string> MealsList { get; set; }
        IList<string> MealProductsList { get; set; } 
        int MealSelectedProduct { get; set; }
        int SelectedMeal { get; set; }

        string NewMealName { get; set; }

        string CurrentName { get; set; }
        int CurrentGramms { get; set; }
        double CurrentCalories { get; set; }
        double MealsCalories { get; set; }
        SaveFileDialog SaveDialog { get; set; }
        //double DCR { get; set; }
        
        MealsPresenter MealsPresenter { set; }
    }
}
