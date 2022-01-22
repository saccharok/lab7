using System;
using System.Collections.Generic;
using System.Text;

namespace lab7CS
{
    class Workers
    {
        public Workers() { }
        public void Set(Workers.Name _name, int _code, int _number, int _payroll)
        {
            Workers worker = this;
            this.name = _name;
            this.code = _code;
            this.number = _number;
            this.payroll = _payroll;
        }
        public void Get(Workers.Name _name, Workers worker)
        {
            int _code;
            do
            {
                Console.WriteLine("Код сотрудника: ");
                _code = Convert.ToInt32(Console.ReadLine());
            } while (_code < 100000 || _code > 999999);
            int _number;
            do
            {
                Console.WriteLine("Номер вольера: ");
                _number = Convert.ToInt32(Console.ReadLine());
            } while (_number < 1 || _number > 7);
            int _payroll;
            do
            {
                Console.WriteLine("Заработная плата: ");
                _payroll = Convert.ToInt32(Console.ReadLine());
            } while (_payroll <= 8000);
            worker.name = _name;
            worker.code = _code;
            worker.number = _number;
            worker.payroll = _payroll;
        }
        public void Print()
        {
            name.Print();
            Console.WriteLine($"Код сотрудника: {code}. Номер вольера: {number}. Заработная плата: {payroll}\n");
        }
        ~Workers() { }
        public struct Name
        {
            string lastName;
            string name;
            string patronymic;
            public void Set(string _lastName, string _name, string _patronymic)
            {
                Name name = new Name();
                name.lastName = _lastName;
                name.name = _name;
                name.patronymic = _patronymic;
            }
            public void Get()
            {
                string _lastName;
                string _name;
                string _patronymic;
                Console.WriteLine("Фамилия: ");
                _lastName = Console.ReadLine();
                Console.WriteLine("Имя: ");
                _name = Console.ReadLine();
                Console.WriteLine("Отчество: ");
                _patronymic = Console.ReadLine();
                lastName = _lastName;
                name = _name;
                patronymic = _patronymic;
            }
            public void Print()
            {
                Console.WriteLine($"ФИО: {lastName} {name} {patronymic}.");
            }
            public void CodeByName(out int _code, Workers worker, Name _name)
            {
                _code = 0;
                if (worker.name.lastName == _name.lastName)
                    if (worker.name.name == _name.name)
                        if (worker.name.patronymic == _name.patronymic)
                            _code = worker.code;
            }
            public void NumberByName(ref int _number, Workers worker, Name _name)
            {
                if (worker.name.lastName == _name.lastName)
                {
                    if (worker.name.name == _name.name)
                        if (worker.name.patronymic == _name.patronymic)
                            _number = worker.number;
                }
                else _number = 0;
            }
        } 
        private Name name
        {
            set
            {
                _ = name;
            }
            get => name;
        }
        private int code 
        {
            set
            {
                code = value;
            } 
            get
            {
                return code;
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
        private int payroll 
        {
            set
            {
                payroll = value;
            }
            get
            {
                return payroll;
            }
        }
    }
}
