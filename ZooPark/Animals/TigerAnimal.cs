using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooPark.Options;

namespace ZooPark.Aninals
{
    internal class TigerAnimal : AbstractAnimal
    {
        public TigerAnimal(string name, int age) : base(name, age)
        {
            TypeOfAnimal = "Tiger";
            AmountOfFoodForDay = 20;
            Biome = BiomType.Junle;
            Square = 50;
            FoodTypes = new List<FoodType>()
            {
                FoodType.Meat,
            };
            IsPradator = true;
            _sound = "hhggrrr";
        }

        public override string Play()
        {
            return $"{Name} plays with rope";
        }
    }
}
