using System;
namespace Learning_Git
{
    public class Animal :IAnimal
    {
        public Animal()
        {
            Console.WriteLine("Inside Animal constructor");
        }

        public bool CanBreath()
        {
            Console.WriteLine("Animal can breath");
            return true;
        }

        public bool IsAlive()
        {
            Console.WriteLine("Animal can be alive");
            return true;
        }
    }
}
