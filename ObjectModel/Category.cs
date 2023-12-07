using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
   public class Category
    {
        public List<string> Categories { get; set; }

        public Category()
        {
            Categories = new List<string> {"Легковой автомобиль", "Седан", "Хэтчбэк", "Кроссовер", "Грузовик", "Внедорожник" };
        }

        public IReadOnlyCollection<string> GetCategories()
        {
            return Categories.AsReadOnly();
        }
    }
}
