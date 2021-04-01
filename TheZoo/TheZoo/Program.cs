using System;
using System.Collections.Generic;
using TheZooClassLibrary;


namespace TheZoo
{
    class Program
    {
        static void Main(string[] args)
        {

            int totalAnimals = 3;
            string Animal = string.Empty;
            List<IAnimal> animals = new List<IAnimal>();
            
			for (int i = 0; i < totalAnimals; i++)
            {
				Console.WriteLine("\nCage " + (i + 1));
				Console.Write("What is the animal's species? ");
				Animal = Console.ReadLine();
                IAnimal newAnimal = null;

				switch (Animal.ToLower())
                {
                    case "lion":
                        newAnimal = new Lion();
                        break;
                    case "bear":
                        newAnimal = new Bear();
                        break;
                    case "wolf":
                        newAnimal = new Wolf();
                        break;
                }

                Console.Write("How old is it? ");
                newAnimal.Age = Convert.ToInt32(Console.ReadLine());
                newAnimal.RequestUniqueCharacteristic();
                animals.Add(newAnimal);
            }

            Console.WriteLine("\n===== \n");

            foreach (var animal in animals)
            {
                int ind = animals.IndexOf(animal);
                Console.Write($"Cage {ind + 1} contains a ");
                Console.WriteLine(animal.GetDescription());
            }    

            Console.WriteLine("\nHave a nice day!");
        }
    }
}
