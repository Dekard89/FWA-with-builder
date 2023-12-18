using Domain;
using RecipeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Model
{
    public class RecipeRepoModel : IRecipeRepoModel
    {
        public IRepository
        public Recipe Create(string name, TimeSpan timeToCook, string discreption=null)
        {
            return new Recipe { Name = name, TimeToCook = timeToCook, Description = discreption };
        }

        public Recipe FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdaeDescription(string description)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTimeToCook(TimeSpan timeToCook)
        {
            throw new NotImplementedException();
        }
    }
}
