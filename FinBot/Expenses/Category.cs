using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinBot.Expenses
{
    public class Category
    {
        public Category(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public Category Parent { get; }
        public IEnumerable<Category> Children { get; }
    }
}