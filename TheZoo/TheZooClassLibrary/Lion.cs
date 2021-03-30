using System;

namespace TheZooClassLibrary
{
    public class Lion : IAnimal
    {
        public Lion()
        {
        }

        private string _maneColour;
        public int Age { get; set; }
        public string Species { get => "lion"; }

        public string GetDescription()
        {
            return Age + "-year-old " + Species + " with a " 
                + _maneColour + " mane.";
        }

        public void RequestUniqueCharacteristic()
        {
            Console.Write("What colour is its mane? ");
            _maneColour = Console.ReadLine();
        }
    }
}
