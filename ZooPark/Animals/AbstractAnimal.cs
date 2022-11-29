using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooPark.Options;
using static System.Net.Mime.MediaTypeNames;

namespace ZooPark.Aninals
{
    internal abstract class AbstractAnimal
    {
        public string TypeOfAnimal { get; protected set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int AmountOfFoodForDay { get; protected set; }
        public int EatenFood { get; set; }
        public BiomType Biome { get; protected set; }
        public int Square { get; set; }
        public List<FoodType> FoodTypes { get; protected set; }
        public bool IsPradator { get; protected set; }

        protected string _sound;

        public AbstractAnimal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string MakeSound()
        {
            return $"{Name} make sound {_sound}";
        }

        public abstract string Play();
    }
}
