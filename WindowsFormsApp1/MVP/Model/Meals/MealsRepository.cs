using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Meal GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Meal> GetMealsList()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            GenericSerializer<Meals>.Serialize(_meals, _filePath);
        }

        public void Update(int id, Meal meal)
        {
            throw new NotImplementedException();
        }
    }
}
