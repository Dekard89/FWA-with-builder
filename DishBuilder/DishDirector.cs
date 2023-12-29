using DishBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BuiderForDish
{
     public class DishDirector
    {
        private readonly IDishBuider _dishBuider;

        public DishDirector(IDishBuider dishBuider)
        {
            _dishBuider = dishBuider;
        }
        public Dish CookWihoutTopings()
        {
            _dishBuider.BuidPrice().BuidOther();

            return _dishBuider.GetDish();
        }
        public Dish CookWithFirstToping()
        {
            _dishBuider.BuidPrice().BuidOther().AppendFirstToping();

            return _dishBuider.GetDish();
        }
        public Dish CookWithSecondToping()
        {
            _dishBuider.BuidPrice().BuidOther().AppenSecondToping();

            return _dishBuider.GetDish();
        }
        public Dish CookWithTwoTopings()
        {
            _dishBuider.BuidPrice().BuidOther().AppendFirstToping().AppendFirstToping();

            return _dishBuider.GetDish();
        }

    }
}
