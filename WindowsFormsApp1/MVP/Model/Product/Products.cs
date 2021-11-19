using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    public class Db
    {
        [System.Xml.Serialization.XmlElementAttribute("Category")]
        public List<Category> Category { get; set; }

        public Db()
        {
        }
    }
    public class Category
    {
        [System.Xml.Serialization.XmlElementAttribute("Product")]
        public List<Product> Product { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("description")]
        public string Description { get; set; }

        public Category()
        {
        }
    }
    
    public class Product
    {
        public string Name { get; set; }
        public int Gramms { get; set; }
        public double Protein { get; set; }
        public double Fats { get; set; }
        public double Carbs { get; set; }
        public double Calories { get; set; }

        public override bool Equals(object obj)
        {
            Product p = obj as Product;
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode()
                ^ Gramms.GetHashCode()
                ^ Protein.GetHashCode()
                ^ Fats.GetHashCode()
                ^ Carbs.GetHashCode()
                ^ Calories.GetHashCode();
        }
        public bool Equals(Product p)
        {
            if (p == null)
                return false;
            return p.Name == Name
                && p.Gramms == Gramms
                && p.Fats == Fats
                && p.Carbs == Carbs
                && p.Protein == Protein
                && p.Calories == Calories;

        }
        public override string ToString()
        {
            return $"Product: {Name}\n Gramms: {Gramms}\n Protein: {Protein}\n Fats: {Fats}\n Carbs: {Carbs}\n Calories: {Calories}\n\n";
        }

        public Product()
        {
        }
    }


}
