using System;

namespace WosHungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Buffet something = new Buffet();
            something.Serve();
            // ninja
            Ninja bob = new Ninja();
            System.Console.WriteLine(bob.IsFull);
            // bob.Eat();   


        }
    }
}
