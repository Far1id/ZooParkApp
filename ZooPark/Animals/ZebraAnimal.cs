using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooPark.Options;

namespace ZooPark.Aninals
{
    internal class ZebraAnimal : AbstractAnimal
    {
        public ZebraAnimal(string name, int age) : base(name, age)
        {
            TypeOfAnimal = "Herbivore";
            AmountOfFoodForDay = 10;
            Biome = BiomType.Tropic;
            Square = 50;
            FoodTypes = new List<FoodType>()
            {
                FoodType.Leaves,
                FoodType.Watermelon,
                FoodType.Grass
            };
            IsPradator = false;
            _sound = "viyt-viyt-viyt";
        }

        public override string Play()
        {
            return $"{Name} runs";
        }
    }
}
