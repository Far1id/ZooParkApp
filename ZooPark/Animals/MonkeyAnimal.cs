using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooPark.Options;

namespace ZooPark.Aninals
{
    internal class MonkeyAnimal : AbstractAnimal
    {
        public MonkeyAnimal(string name, int age) : base(name, age)
        {
            TypeOfAnimal = "Monkey";
            AmountOfFoodForDay = 5;
            Biome = BiomType.Forest;
            Square = 20;
            FoodTypes = new List<FoodType>()
            {
                FoodType.Banan,
                FoodType.Watermelon,
            };
            IsPradator = false;
            _sound = "ggraa-ggraa";
        }

        public override string Play()
        {
            return $"{Name} jumps from branch to branch";
        }
    }
}
