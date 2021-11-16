using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XML;

namespace WindowsFormsApp1.MVP.Model
{
    class DbRepository : IDbRepository
    {
        private readonly string _filePath;
        private readonly Db _db;

        public DbRepository(string programPath)
        {
            _filePath = programPath + @"\FoodProducts.xml";
            if (File.Exists(_filePath))
            {
                _db = GenericSerializer<Db>.Deserialize(_filePath);
            } else
            {
                _db = new Db();
                _db.Category = new List<Category>();
                _db.Category.Add(new Category { Name = "Алкоголь" });
                _db.Category[0].Product = new List<Product>();
                _db.Category[0].Product.Add(new Product { Name = "Вадим", Calories = 0, Carbs = 1.5, Fats = 1.488, Gramms = 1338, Protein = 2.28 });
                Save();
            }
            
        }

        public void CreateCategory(string name, string description)
        {
            Category category = new Category() { Name = name, Description = description, Product = new List<Product>() };
            _db.Category.Add(category);
            Save();
        }
        public void RemoveCategory(int id)
        {
            _db.Category.RemoveAt(id);
            Save();
        }
        public Category GetCategoryByID(int id)
        {
            return _db.Category[id];
        }
        public IEnumerable<Category> GetCategoriesList()
        {
            return _db.Category;
        }

        public void Create(int categoryId, Product item)
        {
            _db.Category[categoryId].Product.Add(item);
            Save();
        }

        public void Delete(int categoryId, int productId)
        {
            _db.Category[categoryId].Product.RemoveAt(productId);
            Save();
        }

        public Product GetByID(int categoryId, int productId)
        {
            return _db.Category[categoryId].Product[productId];
        }

        public IEnumerable<Product> GetProductsList(int categoryId)
        {
            return _db.Category[categoryId].Product;
        }

        public void Save()
        {
            GenericSerializer<Db>.Serialize(_db, _filePath);
        }

        public void Update(int categoryId, int productId, Product item)
        {
            _db.Category[categoryId].Product[productId] = item;
            Save();
        }
    }
}
