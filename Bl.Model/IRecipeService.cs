using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Model
{
    public interface IRecipeRepoModel
    {
        public  Recipe Create(string name, string image);

        public  Recipe FindByName(string name);

        public Task UpdateName(Recipe recipe, string name);

        public Task UpdateImage(Recipe recipe, string image);

       

        
    }
}
