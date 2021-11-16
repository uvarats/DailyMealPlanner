using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XML;
using static WindowsFormsApp1.MVP.Model.Meals;

namespace WindowsFormsApp1.MVP.Model
{
    class MealsRepository : IMealsRepository
    {
        private readonly string _filePath;
        private readonly Meals _meals;
        public MealsRepository(string programPath)
        {
            _filePath = programPath + @"\Meals.xml";
            if (File.Exists(_filePath))
            {
                _meals = GenericSerializer<Meals>.Deserialize(_filePath);
            } else
            {
                _meals = new Meals { MealsList = new List<Meal>() };
                _meals.MealsList.Add(new Meal { Name = "Breakfast", Products = new List<XML.Product>() });
                _meals.MealsList[0].Products.Add(new XML.Product { Name = "Default product", Calories = 15, Carbs = 10, Fats = 11, Gramms = 100, Protein = 1 });
                Save(); 
            }
        }

        public void Create(Meal meal)
        {
            _meals.MealsList.Add(meal);
            Save();
        }

        public void CreateProduct(int mealId, Product p)
        {
            _meals.MealsList[mealId].Products.Add(p);
            Save();
        }

        public void Delete(int id)
        {
            _meals.MealsList.RemoveAt(id);
            Save();
        }

        public void DeleteProduct(int mealId, int id)
        {
            _meals.MealsList[mealId].Products.RemoveAt(id);
            Save();
        }

        public Meal GetByID(int id)
        {
            return _meals.MealsList[id];
        }

        public IEnumerable<Product> GetMealProducts(int id)
        {
            return _meals.MealsList[id].Products;
        }

        public IEnumerable<Meal> GetMealsList()
        {
            return _meals.MealsList;
        }

        public Product GetProduct(int mealId, int id)
        {
            return _meals.MealsList[mealId].Products[id];
        }

        public void Save()
        {
            GenericSerializer<Meals>.Serialize(_meals, _filePath);
        }

        public void Update(int id, Meal meal)
        {
            _meals.MealsList[id] = meal;
            Save();
        }
    }
}
