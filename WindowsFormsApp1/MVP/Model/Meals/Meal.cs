using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XML;

namespace WindowsFormsApp1.MVP.Model
{
    public class Meals
    {
        public List<Meal> MealsList { get; set; }
        public Meals() { }
    }
    public class Meal
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public Meal()
        {

        }
    }
}
