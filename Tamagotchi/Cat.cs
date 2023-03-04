using System;
using System.Collections.Generic;
using System.Text;
using Tamagotchi;

namespace Tamagotchi

{
    struct Fruit
    {
        public string type;
        public int health;
    }


    class Cat
    {
        public void Meow()
        {
            Console.WriteLine("Meow!");
        }
        public void Eat(Fruit f)
        {
            Console.WriteLine($"Cat eats {f.type}. {f.health} hp.\n");
        }
    }
}

