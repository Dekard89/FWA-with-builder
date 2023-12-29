using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DishBuilder
{
    public interface IDishBuider
    {
       

        public IDishBuider BuidOther();

        public IDishBuider BuidPrice();

        public IDishBuider AppendFirstToping();

        public IDishBuider AppenSecondToping();

        public Dish GetDish();

    }
}
