namespace Guided_project___Plan_a_petting_zoo_visit;

class Program
{
    static void Main(string[] args)
    {
        // using System;

        string[] pettingZoo =
        {
        "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
        "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
        "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
        };

        RandomizeAnimals();
        void RandomizeAnimals()
        {
            Random random = new();
            for (int i = 0; i < pettingZoo.Length; i++)
            {

                int r = random.Next(i, pettingZoo.Length);

                string temp = pettingZoo[i];
                pettingZoo[i] = pettingZoo[r];
                pettingZoo[r] = temp;
            }
        }

        // string[,] group = AssignGroup();
        Console.WriteLine("School A");

        //PrintGroup(group);
    }
}
