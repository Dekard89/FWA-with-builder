using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Recipe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public string? Description { get; set; }

        public TimeSpan TimeToCook { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }= new List <Ingredient>();

        public ICollection<Toping> Topings { get; set; } = new List<Toping>();
    }
}
