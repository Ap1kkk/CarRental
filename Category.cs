using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
   public class Category
    {
        public List<string> categories { get; set; }
        
        public Category()
        {
            categories = new List<string> {"Легковой автомобиль", "Седан", "Хэтчбэк", "Кроссовер", "Грузовик", "Внедорожник" };
        }

        public IReadOnlyCollection<string> GetCategories()
        {
            return categories.AsReadOnly();
        }
    }
}
