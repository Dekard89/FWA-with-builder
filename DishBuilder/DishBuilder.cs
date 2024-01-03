using Bl.Model;
using DishBuilder;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BuiderForDish
{
    public class DishBuilder : IDishBuider
    {
        private readonly IRecipeService _repoModel;

        private readonly Dish _dish;



        public DishBuilder(IRecipeService repoModel)
        {
            _repoModel = repoModel;

            _dish = new Dish();

        }

        private Recipe GetRecipe()
        {
            return _repoModel.FindByName(_dish.Name);
        }

        public IDishBuider AppendFirstToping()
        {
            _dish.AppendName($"/n c добавлением {GetRecipe().Topings.ToArray()[0].Name}");

            _dish.AppendPrice(GetRecipe().Topings.ToArray()[0].Price);

            return this;
        }

        public IDishBuider AppenSecondToping()
        {

            _dish.AppendName($"/n c добавлением {GetRecipe().Topings.ToArray()[1].Name}");

            _dish.AppendPrice(GetRecipe().Topings.ToArray()[1].Price);

            return this;
        }


        public IDishBuider BuidOther()
        {
            _dish.Category = GetRecipe().Category;

            _dish.Image = GetRecipe().Image;

            return this;
        }

        public IDishBuider BuidPrice()
        {
            _dish.Price = GetRecipe().Ingredients.Sum(x => x.Price);

            return this;
        }

        public Dish GetDish()=> _dish;
        
       
    }
}
