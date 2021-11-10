using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.MVP.Presenter;

namespace WindowsFormsApp1.MVP.View
{
    public interface IUDataView
    {
        IList<string> ActivityBox { get; set; }
        int Weight { get; set; }
        int UHeight { get; set; }
        int Age { get; set; }
        int SelectedActivity { get; set; }
        double CurrentDCR { get; set; }
        //DailyActivity Activity { set; }
        UserDataPresenter Presenter { set; }
    }
}
