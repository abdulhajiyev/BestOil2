using System.Collections.Generic;

namespace BestOil2
{
    class BestOil
    {
        public MiniCafe MiniCafe { get; set; }
        public PetrolStation PetrolStation { get; set; }
        public double PriceTotal()
        {
            double price = MiniCafe.GetPrice();
            price += PetrolStation.GetPrice();
            return price;
        }
    }

    internal class PetrolStation
    {
        public double Price { get; set; }
        public double Liter { get; set; }

        public double GetPrice()
        {
            return Price * Liter;
        }

        public List<Gasoline> Gasolines = new List<Gasoline>()
        {
            new Gasoline()
            {
                Type = "AI92",
                Price = 1
            },
            new Gasoline()
            {
                Type = "AI95",
                Price = 1.45
            },
            new Gasoline()
            {
                Type = "AI98",
                Price = 1.55
            }
        };
    }

    internal class MiniCafe
    {
        public double Price { get; set; }

        public double GetPrice()
        {
            Price = 0;
            foreach (var foods in Foods)
            {
                Price += foods.Price * foods.Count;
            }
            return Price;
        }

        public List<Food> Foods = new List<Food>()
        {
            new Food()
            {
                Name = "Hot-Dog",
                Price = 3.50,
                Count = 0
            },
            new Food()
            {
                Name = "Hamburger",
                Price = 5.30,
                Count = 0
            },

            new Food()
            {
                Name = "Potato Fries",
                Price = 4.10,
                Count = 0
            },

            new Food()
            {
                Name = "Coca-Cola",
                Price = 1,
                Count = 0
            }
        };
    }

    internal class Gasoline
    {
        public string Type { get; set; }
        public double Price { get; set; }
    }

    internal class Food
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
    }

}
