using System;
using System.Collections.Generic;
using System.Text;

namespace lab7CS
{
    class Beaver
    {
        public Beaver() { }
        public void Set(string _name, double _weight, double _lenght)
        {
            Beaver beaver = this;
            this.name = _name;
            this.weight = _weight;
            this.length = _lenght;
            this.number = 4;
        }
        public void Get(Beaver beaver)
        {
            string _name;
            double _weight;
            double _lenght;
            int _number = 4;
            Console.WriteLine("Имя бобра: ");
            _name = Console.ReadLine();
            do
            {
                Console.WriteLine("Вес бобра в кг: ");
                _weight = Convert.ToDouble(Console.ReadLine());
            } while (_weight < 1);
            do
            {
                Console.WriteLine("Длина хвоста бобра в см: ");
                _lenght = Convert.ToDouble(Console.ReadLine());
            } while (_lenght < 0);
            beaver.name = _name;
            beaver.weight = _weight;
            beaver.length = _lenght;
            beaver.number = _number;
        }
        public void Print()
        {
            Console.WriteLine($"\nИмя бобра: {name}. Вес бобра в кг: {weight}. Длина хвоста бобра в см: {length}. Номер вольера: {number}.\n");
        }
        ~Beaver() { }
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
        private double length 
        { 
            set
            {
                length = value;
            }
            get
            {
                return length;
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
