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
        public override string ToString()
        {
            double calories = 0.0;
            string result = $"Meal: {Name}\n\n";
            foreach (Product p in Products)
            {
                result += p.ToString();
                calories += p.Calories;
            }
            result += $"Total meal calories: {calories}.\n\n";
            return result;
        }
        //public double GetCalories()
        //{
        //    double result = 0;
        //    foreach (Product p in collection)
        //    {

        //    }
        //}
        public Meal()
        {

        }
    }
}
