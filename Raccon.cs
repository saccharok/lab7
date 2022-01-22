using System;
using System.Collections.Generic;
using System.Text;

namespace lab7CS
{
    class Raccon
    {
        public Raccon() { }
        public void Set(string _name, double _weight, int _age)
        {
            Raccon raccon = this;
            this.name = _name;
            this.weight = _weight;
            this.age = _age;
            this.number = 7;
        }
        public void Get(Raccon raccon)
        {
            string _name;
            double _weight;
            int _age;
            Console.WriteLine("Имя лисы: ");
            _name = Console.ReadLine();
            do
            {
                Console.WriteLine("Вес лисы в кг: ");
                _weight = Convert.ToDouble(Console.ReadLine());
            } while (_weight < 1);
            do
            {
                Console.WriteLine("Возраст лисы: ");
                _age = Convert.ToInt32(Console.ReadLine());
            } while (_age < 0);
            raccon.name = _name;
            raccon.weight = _weight;
            raccon.age = _age;
            raccon.number = 7;
        }
        public void Print()
        {
            Console.WriteLine($"\nИмя лисы: {name}. Вес лисы в кг: {weight}. Возраст лисы: {age}. Номер вольера: {number}.\n");
        }
        private string name 
        { 
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        private double weight 
        { 
            set
            {
                weight = value;
            }
            get
            {
                return weight;
            }
        }
        private int age 
        { 
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }
        private int number 
        { 
            set
            {
                number = value;
            }
            get
            {
                return number;
            }
        }
    }
}
