using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XML;

namespace WindowsFormsApp1.MVP.Model
{
    public interface IDbRepository
    {
        void CreateCategory(string name, string description);
        Category GetCategoryByID(int id);
        void RemoveCategory(int id);
        IEnumerable<Category> GetCategoriesList();

        void Create(int categoryId, Product item);
        void Delete(int categoryId, int productId);
        Product GetByID(int categoryId, int productId);
        IEnumerable<Product> GetProductsList(int categoryId);
        void Save();
        void Update(int categoryId, int productId, Product item);
    }
}
