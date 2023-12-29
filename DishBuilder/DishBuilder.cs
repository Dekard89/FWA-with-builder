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
        private readonly IRecipeRepoModel _repoModel;

        private readonly Dish _dish;

        

        public DishBuilder(IRecipeRepoModel repoModel)
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
            throw new NotImplementedException();
        }

        public IDishBuider AppenSecondToping()
        {
            _dish.AppendName($"/n c добавлением {GetRecipe().Topings[1.Name}");

            _dish.AppendPrice(GetRecipe().Topings[1].Price);
        }


        public IDishBuider BuidOther()
        {
            _dish.Category=GetRecipe().Category;

            _dish.Image=GetRecipe().Image;

            return this;
        }

        public IDishBuider BuidPrice()
        {
            _dish.Price=GetRecipe().Ingredients.Sum(x => x.Price);

            return this;
        }

        public Dish GetDish()
        {
            throw new NotImplementedException();
        }
    }
