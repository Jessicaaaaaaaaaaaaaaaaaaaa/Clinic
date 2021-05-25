using System;

namespace TheZooClassLibrary
{
    public interface IAnimal
    {
        int Age { set; get; }

        string Species { get; }

        void SetAge()
        {
            Console.Write("How old is it? ");
        }

        string GetDescription();

        void RequestUniqueCharacteristic();
        
    }
}
