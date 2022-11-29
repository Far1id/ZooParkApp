using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooPark.Options;

namespace ZooPark.Aninals
{
    internal class BearAnimal : AbstractAnimal
    {
        public BearAnimal(string name, int age) : base(name, age)
        {
            TypeOfAnimal = "Bear";
            AmountOfFoodForDay = 30;
            Biome = BiomType.Forest;
            Square = 70;
            FoodTypes = new List<FoodType>()
            {
                FoodType.Honey,
                FoodType.Fish
            };
            IsPradator = true;
            _sound = "hhaagrr";
        }

        public override string Play()
        {
            return $"{Name} went to the tree";
        }
    }
}
