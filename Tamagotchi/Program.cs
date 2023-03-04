using System;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Meow();
           Fruit FruitBanana = new Fruit {type = "banana", health = 228 };
            cat.Eat(FruitBanana);
            Fruit FruitMango = new Fruit { type = "mango", health = 400 };
            cat.Eat(FruitMango);
        }
    }
}
