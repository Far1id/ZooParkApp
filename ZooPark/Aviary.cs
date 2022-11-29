using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooPark.Aninals;
using ZooPark.Options;

namespace ZooPark
{
    internal class Aviary
    {
        public string Name { get; set; }
        public BiomType Biom { get; set; }
        public int TotalArea { get; set; }
        public List<AbstractAnimal> Animals { get; set; }
        public Dictionary<FoodType, int> Feeder { get; set; } = new Dictionary<FoodType, int>();

        public Aviary(string name, BiomType biom, int square)
        {
            Name = name;
            Biom = biom;
            TotalArea = square;
            Animals = new List<AbstractAnimal>();
        }

        public string AddFood(FoodType food, int count)
        {
            if (Animals[0].FoodTypes.Contains(food) )
            {
                int foodvalue = 0;
                int sum = 0;

                if (Feeder.Count() == 0)
                {
                    Feeder.Add(food, count);
                }
                else
                {
                    foreach (var item in Feeder)
                    {

                        if (item.Key == food)
                        {
                            foodvalue = item.Value;
                            Feeder.Remove(item.Key);
                            sum = foodvalue + count;

                            Feeder.Add(food, sum);
                            Console.WriteLine("added");
                        }
                    }

                }

                
                
                return "the animals were given food";
            }
            else
            {
                return $" {Animals[0].TypeOfAnimal} {food} don't eat ";
            }
        }

        public string EatFood()
        {
            int SumOfMealsForAnimals = 0;
            int EatenFoodForAnimals = 0;
            SumOfMealsForAnimals = Animals.Count * Animals[0].AmountOfFoodForDay;

            //Animals[0].EatenFood = RestMeal() / Animals.Count;


            EatenFoodForAnimals = Animals.Count * Animals[0].EatenFood;


            //Console.WriteLine(Animals[0].EatenFood);

            if (RestMeal() < SumOfMealsForAnimals)
            {
                //FoodType food;
                //List<FoodType> foods = new List<FoodType>();

                EatenFoodForAnimals = RestMeal();
                //Animals[0].EatenFood = RestMeal() / Animals.Count;

                //Console.WriteLine(Animals[0].EatenFood);

                foreach (var item in Feeder)
                {
                    //FoodType food = item.Key;
                    //foods.Add(food);
                    //int foodweight = item.Value;

                    Feeder.Remove(item.Key);

                }

                //foreach (var item in foods)
                //{
                //    Feeder.Add(item, 0);
                //}

                return $"{Animals[0].TypeOfAnimal}s are not full and {SumOfMealsForAnimals-EatenFoodForAnimals} kg need food";
            }
            else
            {
                return $" {Animals[0].TypeOfAnimal}s are full and {RestMeal()-SumOfMealsForAnimals} kf left food";
            }

            //EatenFoodForAnimals = RestMeal();
            //Console.WriteLine(Animals[0].EatenFood);

        }

        public string ShowRestMeal()
        {
            if (!(Feeder.Count==0))
            {
                foreach (var item in Feeder)
                {
                    return $"{item.Key} - {item.Value}";
                }
            }
            
                return "There is not any meal in Feeder";
        }

        public int RestMeal()
        {
            int restmeal = 0;

            if (Feeder.Count() == 0)
            {
                return 0;
            }
            else
            {
                foreach (var item in Feeder)
                {
                    restmeal += item.Value;
                }
                return restmeal;
            }
        }

        public string AddAnimal(AbstractAnimal animal)
        {

            if (Biom != animal.Biome)
            {
                return $" {Name} could not enter {animal.Name}, because their biomes are not the same";
               
            }
            else if (GetFreeSpace() < animal.Square)
            {
                return $" {Name} could not enter {animal.Name}, because there is no space";
                
            }
            else if (!CheckNeighbors(animal))
            {
                return $" {Name} could not enter {animal.Name}, because the neighbors are not suitable";
               
            }
            else
            {
                Animals.Add(animal);
                return $" {Name} was added {animal.Name}";
               
            }
        }

        public string RemoveAnimal(string name)
        {
            foreach (var item in Animals)
            {
                if (item.Name == name)
                {
                    Animals.Remove(item);
                    return $" {Name} was released from the this cage";
                }
            }
            return $"There is no animal by that name";

        }

        private int GetFreeSpace()
        {
            int freeSpace = TotalArea;
            foreach (var item in Animals)
            {
                freeSpace -= item.Square;
            }
            return freeSpace;

        }

        private bool CheckNeighbors(AbstractAnimal animal)
        {
            if (Animals.Count != 0)
            {
                foreach (var item in Animals)
                {
                    if ((item.IsPradator || animal.IsPradator) && item.TypeOfAnimal != animal.TypeOfAnimal)
                    {
                        return false;
                    }
                }
            }
            return true;

        }

        public List<string> MakeSoundAll()
        {
            List<string> messages = new List<string>();
            foreach (var item in Animals)
            {
                messages.Add(item.TypeOfAnimal +  " - " + item.MakeSound());
            }
            return messages;
        }

        
    }
}
