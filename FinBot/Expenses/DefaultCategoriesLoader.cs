using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;

using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace FinBot.Expenses
{
    public class DefaultCategoriesLoader : ICategoriesLoader
    {
        public IEnumerable<Category> Load()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "FinBot.Content.ExpenseCategories.json";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                var categroiesText = reader.ReadToEnd();

                var categories = JsonConvert.DeserializeObject<IEnumerable<Category>>(categroiesText);

                return categories;
            }
        }
    }
}