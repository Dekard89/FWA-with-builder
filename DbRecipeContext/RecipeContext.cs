using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DbRecipeContext
{
    public class RecipeContext:DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<Ingredient> Ingredients { get; set;}

        public DbSet<Toping> Topings { get; set; }

        public RecipeContext(DbContextOptions<RecipeContext> options)
            : base(options)
        {

        }
    }
}
