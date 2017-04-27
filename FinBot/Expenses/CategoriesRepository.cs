using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinBot.Expenses
{
    public class CategoriesRepository : IRepository<Category>
    {
        private Lazy<IEnumerable<Category>> _categories = new Lazy<IEnumerable<Category>>(() => new DefaultCategoriesLoader().Load());
        public CategoriesRepository(ICategoriesLoader defaultCategoriesLoader)
        {
            _categories = new Lazy<IEnumerable<Category>>(() => (defaultCategoriesLoader ?? new DefaultCategoriesLoader()).Load());
        }

        public IEnumerable<Category> Select() => _categories.Value;
    }
}