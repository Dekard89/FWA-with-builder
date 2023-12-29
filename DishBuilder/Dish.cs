using Domain.Enum;

namespace DishBuilder
{
    public class Dish
    {
        public string Name { get; set; }

        public string Image { get; set; }

        public double Price { get; set; }

        public Category Category { get; set; }

        public double TotalPrice 
        {
            get =>  TotalPrice;

            set => TotalPrice= Price * 1.7; 
        }

       
        public string ShowDish() => $"{Name}\n {TotalPrice}";

        public string AppendName(string str) => Name + str;

        public double AppendPrice(double numb) => Price + numb;
    }
}
