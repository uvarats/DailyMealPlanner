using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.MVP.Presenter;

namespace WindowsFormsApp1.MVP.View
{
    public interface ICategoryView
    {
        string NameField { get; set; }
        string Description { get; set; }
        CategoryAddingPresenter Presenter { set; }
    }
}
