using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooPark.Options;

namespace ZooPark.Aninals
{
    internal class HorseAnimal : AbstractAnimal
    {
        public HorseAnimal(string name, int age) : base(name, age)
        {
            TypeOfAnimal = "Herbivore";
            AmountOfFoodForDay = 10;
            Biome = BiomType.Meadows;
            Square = 50;
            FoodTypes = new List<FoodType>()
            {
                FoodType.Pumpkin,
                FoodType.Grass
            };
            IsPradator = false;
            _sound = "hiiihaaaa";
        }

        public override string Play()
        {
            return $"{Name} runs and jumps";
        }
    }
}
