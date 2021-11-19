using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XML;

namespace WindowsFormsApp1.MVP.Model
{
    public interface IMealsRepository
    {
        void Create(Meal meal);
        double GetMealsCalories();
        void CreateProduct(int mealId, Product p);
        void Delete(int id);
        void DeleteProduct(int mealId, int id);
        Meal GetByID(int id);
        Product GetProduct(int mealId, int id);
        IEnumerable<Meal> GetMealsList();
        IEnumerable<Product> GetMealProducts(int id);
        string ToString();
        void Update(int id, Meal meal);
        void Save();
    }
}
