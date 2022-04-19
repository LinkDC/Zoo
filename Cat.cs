using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Cat
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public Cat()
        {
            Weight = 5;
            Name = "Мурзик";
        }
        public Cat(int _weight, string _name)
        {
            Weight = _weight;
            Name = _name;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Кота зовут {Name} и он весит {Weight}");
        }
        public void Meow()
        {
            Console.WriteLine($"{Name} сказал Мяу") ;
        }
    }
}
