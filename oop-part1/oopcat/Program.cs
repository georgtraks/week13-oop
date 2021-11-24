using System;

namespace oopcat
{
    class Program
    {
        class cat
        {
            //class fields
            string name;
            string color;
            double hungriness;

            public cat(string _name, string _color) //constructor
            {
                name = _name;
                color = _color;
                hungriness = 0;
            }
            public string Name
            {
                get { return name; }
            }
            public string Color
            {
                get { return color; }
            }
            public double Hungriness
            {
                get { return hungriness; }
            }
            public void Sleeps()
            {
                Console.WriteLine("Zzzz");
                hungriness += 0.2;
            }

            public void meow()
            {
                Console.WriteLine($"{name} says \"meow!\"");
            }

            static void Main(string[]args)
            {
                cat mycat = new cat("garfield", "ginger");

                while(mycat.hungriness !=1)
                {
                    mycat.Sleeps();
                }
                mycat.meow();
            }

        }
    }
}

