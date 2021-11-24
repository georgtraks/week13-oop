using System;

namespace oop_part1
{
    class Program
    {
        class dog
        {
            //class fields
            string name;
            int spots;
            double happiness;

            public dog(string _name, int _spots) //constructor
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The dog {name} has been created.");

            }
            public string Name
            {
                get { return name; }
            }
            public int Spots
            {
                get { return spots; }
            }
            public double Happiness
            {
                get { return happiness; }
            }
            public void Barks()
            {
                Console.WriteLine("Auh-Auh!");
                happiness += 0.2;
            }
            public void Wags()
            {
                Console.WriteLine($"{Name}: Wag-Wag");
            }
            public void Rename(string NewName)
            {
                name = NewName;
            }
            public void ShowDogData()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Spots: {Spots}");
                Console.WriteLine($"Level of appiness: {Happiness}");
            }

        }

        static void Main(string[] args)
        {
            dog MyDog = new dog("Blackie", 3);
            MyDog.Barks();
            Console.WriteLine($"{MyDog.Name}'s level of happiness: {MyDog.Happiness}");


            dog newDog = new dog("Kaspar", 2);
            Console.WriteLine($"{newDog.Name}'s level of happiness: {newDog.Happiness}");



            while (MyDog.Happiness != 1)
            {
                MyDog.Barks();
            }
            MyDog.Wags();

            Console.WriteLine($"Enter a new name for the dog {MyDog.Name}:");
            string userInput = Console.ReadLine();
            MyDog.Rename(userInput);
            MyDog.ShowDogData();


        }
    }
}

