using System;

namespace CatsAndDogsOp
{
    class Program
    {
        
        class Pet
        {
            public string name;
            public string color;
            public int _lvlOfhappines;
            public void PrintPetInfo()
            {
                Console.WriteLine($"name: {name}");
                Console.WriteLine($"color: {color}");
                Console.WriteLine($"level of happiness: {_lvlOfhappines}");
            }
        }
        class Dog : Pet
        {
            public Dog(string _name, string _color)
            {
                name = _name;
                color = _color;
                _lvlOfhappines += 1;

            }
            public void WaveTail()
            {
                Console.WriteLine("dog waves tail");
                _lvlOfhappines += 1;
            }
            public bool bark()
            {
                Console.WriteLine("woof wooh");
                return true;
            }
        }
        class Cat : Pet
        {
            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                _lvlOfhappines += 10;

            }
            public void HearDog()
            {
                _lvlOfhappines = 0;
            }
            public void hiss()
            {
                Console.WriteLine("hiss");
            }
        }
        static void Main(string[] args)
        {
            Dog doger = new Dog("väino", "green");
            Cat kitty = new Cat("donkey", "blue");
            doger.PrintPetInfo();
            kitty.PrintPetInfo();
            doger.WaveTail();
            kitty.HearDog();
            doger.bark();
            doger.PrintPetInfo();
            kitty.PrintPetInfo();
          
            for(int i = 0; i<10; i++)
            {
                doger.WaveTail();
            }
            doger.bark();
            if (doger.bark())
            {
                kitty.HearDog();
            }
            if(kitty._lvlOfhappines == 0)
            {
                kitty.hiss();
            }
            doger.PrintPetInfo();
            kitty.PrintPetInfo();
            
        }
    }
}
