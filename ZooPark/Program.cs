using ZooPark;
using ZooPark.Aninals;
using ZooPark.Options;

internal class Program
{
    private static void Main(string[] args)
    {
        bool check = true;
        List<Aviary> Aviaries = new List<Aviary>();

        Aviary aviary1 = new Aviary("Tropic Aviary",BiomType.Tropic, 300);
        Aviary aviary2 = new Aviary("Forest Aviary", BiomType.Forest, 350);

        BearAnimal bear1 = new BearAnimal("Bear1", 15);
        ZebraAnimal zebra1 = new ZebraAnimal("Zebra1", 12);

        //Console.WriteLine(aviary1.AddAnimal(bear1));

        Console.WriteLine(aviary2.AddAnimal(bear1));

        Console.WriteLine(aviary1.AddAnimal(zebra1));

        //Console.ReadLine(aviary2.AddFood(FoodType.Honey),100);

        Aviaries.Add(aviary1);
        Aviaries.Add(aviary2);

        //Console.WriteLine(Aviaries[0].RestMeal());


        do
        {
            Console.WriteLine("================ZOOPARK================\n");
            Console.WriteLine("         MENU \n\n " +
                "1.Show all Animals:\n " +
                "2.Show all Aviaries\n " +
                "3.Create Aviary\n " +
                "4.Add the animal to the cage\n " +
                "5.Remove Animal\n " +
                "6.Animal Feeding\n " +
                "7.Show the food left in the Feeder\n " +
                "8.Check if the animals are full or not\n " +
                "9.Listen to animal sounds\n " +
                "0.Exit ZooPark");

            int choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    foreach (var item in Aviaries)
                    {
                        Console.WriteLine(item.Name);
                        foreach (var animal in item.Animals)
                        {
                            Console.WriteLine(animal.TypeOfAnimal + " " + animal.Name);
                        }
                    }
                    break;
                case 2:
                    foreach (var item in Aviaries)
                    {
                        Console.WriteLine(item.Name + " " + item.Biom + " " + item.TotalArea + " " + "square meter");
                    }
                    break;
                case 3:
                    Console.WriteLine("Input the name of aviary\n");
                    string aviaryName = Console.ReadLine();

                    //Console.WriteLine(aviaryName);

                    Console.WriteLine("Input the biomtype of aviary\n");

                    foreach (var item in Enum.GetValues(typeof(BiomType)))
                    {
                        Console.WriteLine((int)item + " - " + item);
                    }

                    int typeInt = Convert.ToInt32(Console.ReadLine());
                    BiomType selectedBiom = (BiomType)typeInt;

                    //Console.WriteLine(selectedBiom);

                    Console.WriteLine("Input the square of aviary");
                    int aviarySquare = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine(aviarySquare);

                    Aviary aviary = new Aviary(aviaryName, selectedBiom, aviarySquare);

                    Aviaries.Add(aviary);
                    Console.WriteLine("Aviary Created");

                    //foreach (var item in Aviaries)
                    //{
                    //    if (!(item.Name == aviaryName))
                    //    {
                    //        Aviaries.Add(aviary);
                    //        Console.WriteLine("Aviary Created");
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("This Aviary already exists");
                    //    }
                    //}
                    break;
                case 4:
                    Console.WriteLine("What animal do you want to create?\n" +
                        "1.Bear\n " +
                        "2.Horse\n " +
                        "3.Monkey\n " +
                        "4.Tiger\n " +
                        "5.Zebra");
                    //string selectedAnimal = Console.ReadLine();
                    int selectedAnimal = Convert.ToInt32(Console.ReadLine());
                    switch (selectedAnimal)
                    {
                        case 1:
                            Console.WriteLine("Input the name of Bear");
                            string bearName = Console.ReadLine();
                            Console.WriteLine("Inpet the age of Bear");
                            int bearAge = Convert.ToInt32(Console.ReadLine());

                            BearAnimal bear = new BearAnimal(bearName, bearAge);

                            Console.WriteLine("Which cage do you want to add this animal to?");
                            int count1 = 0;
                            foreach (var item in Aviaries)
                            {
                                Console.WriteLine(count1 + ". " + item.Name);
                                count1++;
                            }
                            int selectedAviary1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Aviaries[selectedAviary1].AddAnimal(bear));

                            break;
                        case 2:
                            Console.WriteLine("Input the name of Horse");
                            string horseName = Console.ReadLine();
                            Console.WriteLine("Inpet the age of Horse");
                            int horseAge = Convert.ToInt32(Console.ReadLine());

                            HorseAnimal horse = new HorseAnimal(horseName, horseAge);

                            Console.WriteLine("Which cage do you want to add this animal to?");
                            int count2 = 0;
                            foreach (var item in Aviaries)
                            {
                                Console.WriteLine(count2 + ". " + item.Name);
                                count2++;
                            }
                            int selectedAviary2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Aviaries[selectedAviary2].AddAnimal(horse));

                            break;
                        case 3:
                            Console.WriteLine("Input the name of Monkey");
                            string monkeyName = Console.ReadLine();
                            Console.WriteLine("Inpet the age of Monkey");
                            int monkeyAge = Convert.ToInt32(Console.ReadLine());

                            MonkeyAnimal monkey = new MonkeyAnimal(monkeyName, monkeyAge);

                            Console.WriteLine("Which cage do you want to add this animal to?");
                            int count3 = 0;
                            foreach (var item in Aviaries)
                            {
                                Console.WriteLine(count3 + ". " + item.Name);
                                count3++;
                            }
                            int selectedAviary3 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Aviaries[selectedAviary3].AddAnimal(monkey));

                            break;
                        case 4:
                            Console.WriteLine("Input the name of Tiger");
                            string tigerName = Console.ReadLine();
                            Console.WriteLine("Inpet the age of Tiger");
                            int tigerAge = Convert.ToInt32(Console.ReadLine());

                            TigerAnimal tiger = new TigerAnimal(tigerName, tigerAge);

                            Console.WriteLine("Which cage do you want to add this animal to?");
                            int count4 = 0;
                            foreach (var item in Aviaries)
                            {
                                Console.WriteLine(count4 + ". " + item.Name);
                                count4++;
                            }
                            int selectedAviary4 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Aviaries[selectedAviary4].AddAnimal(tiger));

                            break;
                        case 5:
                            Console.WriteLine("Input the name of Zebra");
                            string zebraName = Console.ReadLine();
                            Console.WriteLine("Inpet the age of Zebra");
                            int zebraAge = Convert.ToInt32(Console.ReadLine());

                            ZebraAnimal zebra = new ZebraAnimal(zebraName, zebraAge);

                            Console.WriteLine("Which cage do you want to add this animal to?");
                            int count5 = 0;
                            foreach (var item in Aviaries)
                            {
                                Console.WriteLine(count5 + ". " + item.Name);
                                count5++;
                            }
                            int selectedAviary5 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Aviaries[selectedAviary5].AddAnimal(zebra));

                            break;
                        default:
                            Console.WriteLine("This animal cannot create");
                            break;
                    }

                    break;
                case 5:
                    Console.WriteLine("Which cage do you want to delete from?");

                    int count6 = 0;
                    foreach (var item in Aviaries)
                    {
                        Console.WriteLine(count6 + ". " + item.Name);
                        count6++;
                    }
                    int selectedAviary6 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Which animal do you want to delete?");

                    foreach (var item in Aviaries[selectedAviary6].Animals)
                    {
                        Console.WriteLine(item.Name);
                    }

                    string deletedAnimalName = Console.ReadLine();

                    Aviaries[selectedAviary6].RemoveAnimal(deletedAnimalName);

                    break;
                case 6:
                    Console.WriteLine("Which cage animals do you want to feed?");

                    int count7 = 0;
                    foreach (var item in Aviaries)
                    {
                        Console.WriteLine(count7 + ". " + item.Name);
                        count7++;
                    }
                    int selectedAviary7 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("What food do you want to feed?");

                    foreach (var item in Enum.GetValues(typeof(FoodType)))
                    {
                        Console.WriteLine((int)item + " - " + item);
                    }

                    int typeFood = Convert.ToInt32(Console.ReadLine());
                    FoodType selectedFood = (FoodType)typeFood;

                    Console.WriteLine("How much feed do you want to give?");

                    int givenFood = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine( Aviaries[selectedAviary7].AddFood(selectedFood, givenFood));
                    Console.WriteLine(Aviaries[selectedAviary7].EatFood());
                    break;
                case 7:
                    Console.WriteLine("Which cage do you want to see the rest of the food in?");

                    int count8 = 0;
                    foreach (var item in Aviaries)
                    {
                        Console.WriteLine(count8 + ". " + item.Name);
                        count8++;
                    }
                    int selectedAviary8 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Aviaries[selectedAviary8].ShowRestMeal());

                    break;
                case 8:
                    Console.WriteLine("Which cage animals?");

                    int count9 = 0;
                    foreach (var item in Aviaries)
                    {
                        Console.WriteLine(count9 + ". " + item.Name);
                        count9++;
                    }
                    int selectedAviary9 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Aviaries[selectedAviary9].EatFood());

                    break;
                case 9:
                    Console.WriteLine("Which cage animals do you want to listen to?");
                    int count = 0;
                    foreach (var item in Aviaries)
                    {
                        Console.WriteLine(count + ". " + item.Name);
                        count++;
                    }
                    int selectedAviary = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sounds : ");
                    ;

                    foreach (var item in Aviaries[selectedAviary].MakeSoundAll())
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("Listened to animal sounds");
                    break;
                case 0:
                    Console.WriteLine("Exited the ZooPark");
                    check = false;
                    break;
            }
        } while (check);
    }
}