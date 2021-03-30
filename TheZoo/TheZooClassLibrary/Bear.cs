using System;

namespace TheZooClassLibrary
{
    public class Bear : IAnimal
    {
        public Bear()
        {
        }

        private bool _breed;
        public int Age { get; set; }
        public string Species { get => "bear"; }

        public string GetDescription()
        {
            return Age + "-year-old" +
                (_breed ? " " : " non-") +
                "grizzly bear.";
        }

        public void RequestUniqueCharacteristic()
        {
            Console.Write("Is it a Grizzly bear (yes/no)? ");
            _breed = Console.ReadLine().ToLower() == "yes";   
        }
    }
}
