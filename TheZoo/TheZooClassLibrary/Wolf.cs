using System;

namespace TheZooClassLibrary
{
    public class Wolf : IAnimal
    {
        public Wolf()
        {
        }

        private int _speed;
        public int Age { get; set; }
        public string Species { get => "wolf"; }

        public string GetDescription()
        {
            return Age + "-year-old " + Species + " that runs " 
                + _speed + " km/h.";
        }

        public void RequestUniqueCharacteristic()
        {
            Console.Write("How fast can it run (in km/h)? ");
            _speed = Convert.ToInt32(Console.ReadLine());
        }
    }
}
