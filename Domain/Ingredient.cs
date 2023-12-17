using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
     public class Ingredient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    }
}
