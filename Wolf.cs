using System;
using System.Collections.Generic;
using System.Text;

namespace lab7CS
{
    public class Wolf
    {
        public Wolf() { }
        public void Set (string _name, int _age, int _number)
        {
            Wolf wolf1 = this; 
            this.name = _name;
            this.age = _age;
            this.number = _number;
        }
        public void Get (Wolf wolf) 
        {
            string _name;
            int _age;
            int _number;
            Console.WriteLine("Имя волка: ");
            _name = Console.ReadLine();
            do
            {
                Console.WriteLine("Возраст волка: ");
                _age = Convert.ToInt32(Console.ReadLine());
            } while (_age < 0);
            do
            {
                Console.WriteLine("Номер вольера: ");
                _number = Convert.ToInt32(Console.ReadLine());
            } while (_number < 1 || _number > 3);            
            wolf.name = _name;
            wolf.age = _age;
            wolf.number = _number;
        }
        public void Print ()
        {
            Console.WriteLine($"\nВолк. Имя: {name}. Возраст: {age}. Номер вольера: {number}.\n");
        }
        private void NumByWolf(Wolf wolf1, Wolf wolf2, Wolf wolf3)
        {
            int i = 0, j = 0, k = 0;
            if (wolf1.number == 1)
                i++;
            else if (wolf1.number == 2)
                j++;
            else k++;
            if (wolf2.number == 1)
                i++;
            else if (wolf2.number == 2)
                j++;
            else k++;
            if (wolf3.number == 1)
                i++;
            else if (wolf3.number == 2)
                j++;
            else k++;
            Console.WriteLine($"Вольер - 1: {i}.\n Вольер - 2: {j}.\n Вольер - 3: {k}.\n");
        }
        ~Wolf() { }
        private string name 
        {
            get
            {
                return name;    
            }
            set
            {
                name = value;
            }
        }
        private int age 
        { 
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        private int number 
        { 
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
    }
}
