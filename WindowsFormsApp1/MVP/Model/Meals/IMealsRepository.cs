﻿using System;
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
        void Delete(int id);
        Meal GetByID(int id);
        IEnumerable<Meal> GetMealsList();
        IEnumerable<Product> GetMealProducts(int id);
        void Update(int id, Meal meal);
        void Save();
    }
}
