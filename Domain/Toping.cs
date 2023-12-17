using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Toping
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantiyy { get; set; }
        public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
    }
}
