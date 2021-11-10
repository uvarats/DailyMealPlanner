using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.MVP.View
{
    public partial interface IMainView
    {
        int CategoriesBoxSelected { get; set; }
        string CategoryName { get; set; }
        string Description { get; set; }
    }
}
