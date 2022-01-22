using System;
using System.Text;

namespace lab7CS
{
    class Program
    {
        static void Main(string[] args)
        {
        menu:
            Console.WriteLine(" Зоопарк \"П О Л И Т Е Х Н И К \" \n\n");
            Console.WriteLine(" 1  Волки");
            Console.WriteLine(" 2  Бобры");
            Console.WriteLine(" 3  Лисы");
            Console.WriteLine(" 4  Еноты");
            Console.WriteLine(" 5  Медведи");
            Console.WriteLine(" Введите 6, чтобы узнать информацию о сотрудниках");
            Console.WriteLine(" Введите 7, чтобы выйти из программы");
            int check;
            do
            {
                check = Convert.ToInt32(Console.ReadLine());
            } while (check < 1 || check > 7);
            if (check == 1)
            {
                Console.Clear();
                Console.WriteLine(" Зоопарк \"П О Л И Т Е Х Н И К \" \n\n");
                Console.WriteLine("    Сектор - Волки");
                string _name;
                int _age = 0;
                int _number = 0;
                Wolf wolf1 = new Wolf();
                Console.WriteLine("Имя волка: ");
                _name = Console.ReadLine();
                do
                {
                    Console.WriteLine("Возраст волка: ");
                    _age = Convert.ToInt32(Console.ReadLine());
                } while (_age < 1);
                do
                {
                    Console.WriteLine("Номер вольера: ");
                    _number = Convert.ToInt32(Console.ReadLine());
                } while (_number < 1 || _number > 3);
                wolf1.Set(_name, _age, _number);
                Wolf wolf2 = new Wolf();
                wolf2.Get(wolf2);
                wolf1.Print();
                wolf2.Print();
                char c;
                Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню");
                c = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                goto menu;
            }
            else if (check == 2)
            {
                Console.Clear();
                Console.WriteLine(" Зоопарк \"П О Л И Т Е Х Н И К \" \n\n");
                Console.WriteLine("    Сектор - Бобры");
                Beaver beaver1 = new Beaver();
                string _name;
                double _weight;
                double _lenght;
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
                beaver1.Set(_name, _weight, _lenght);
                Beaver beaver2 = new Beaver();
                beaver2.Get(beaver2);
                beaver1.Print();
                beaver2.Print();
                char c;
                Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню");
                c = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                goto menu;
            }
            else if (check == 3)
            {
                Console.Clear();
                Console.WriteLine(" Зоопарк \"П О Л И Т Е Х Н И К \" \n\n");
                Console.WriteLine("    Сектор - Лисы");
                Fox fox1 = new Fox();
                string _name;
                double _weight;
                int _age;
                int _number;
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
                do
                {
                    Console.WriteLine("Номер вольера: ");
                    _number = Convert.ToInt32(Console.ReadLine());
                } while (_number < 5 || _number > 6);
                fox1.Set(_name, _weight, _age, _number);
                Fox fox2 = new Fox();
                fox2.Get(fox2);
                fox1.Print();
                fox2.Print();
                char c;
                Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню");
                c = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                goto menu;
            }
            else if (check == 4)
            {
                Console.Clear();
                Console.WriteLine(" Зоопарк \"П О Л И Т Е Х Н И К \" \n\n");
                Console.WriteLine("    Сектор - Еноты");
                Raccon raccon1 = new Raccon();
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
                raccon1.Set(_name, _weight, _age);
                Raccon raccon2 = new Raccon();
                raccon2.Get(raccon2);
                raccon1.Print();
                raccon2.Print();
                char c;
                Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню");
                c = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                goto menu;
            }
            else if (check == 5)
            {
                Console.Clear();
                Console.WriteLine(" Зоопарк \"П О Л И Т Е Х Н И К \" \n\n");
                Console.WriteLine("    Сектор - Медведи");
                Bear bear1 = new Bear();
                string _name;
                double _weight;
                double _high;
                Console.WriteLine("Имя медведя: ");
                _name = Console.ReadLine();
                do
                {
                    Console.WriteLine("Вес медведя в кг: ");
                    _weight = Convert.ToDouble(Console.ReadLine());
                } while (_weight < 1);
                do
                {
                    Console.WriteLine("Рост медведя в см: ");
                    _high = Convert.ToDouble(Console.ReadLine());
                } while (_high < 10);
                bear1.Set(_name, _weight, _high);
                Bear bear2 = new Bear();
                bear2.Get(bear2);
                bear1.Print();
                bear2.Print();
                char c;
                Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню");
                c = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                goto menu;
            }
            else if (check == 6)
            {
                Console.Clear();
                Console.WriteLine(" Зоопарк \"П О Л И Т Е Х Н И К \" \n\n");
                Console.WriteLine("    Сотрудники");
                Workers.Name name1 = new Workers.Name();
                string _lastName;
                string _name;
                string _patronymic;
                Console.WriteLine("Фамилия: ");
                _lastName = Console.ReadLine();
                Console.WriteLine("Имя: ");
                _name = Console.ReadLine();
                Console.WriteLine("Отчество: ");
                _patronymic = Console.ReadLine();
                name1.Set(_lastName, _name, _patronymic);
                Workers worker1 = new Workers();
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
                worker1.Set(name1, _code, _number, _payroll);
                Workers worker2 = new Workers();
                Workers.Name name2 = new Workers.Name();
                name2.Get();
                worker2.Get(name2, worker2);
                int flag;
                Console.WriteLine("\nВыберете, как вывести информацию:\n 1. Кратко\n 2. Полностью\n");
                do
                {
                    flag = Convert.ToInt32(Console.ReadLine());
                } while (flag < 1 || flag > 2);
                if (flag == 1)
                {
                    name1.Print();
                    name2.Print();
                }
                if (flag == 2)
                {
                    worker1.Print();
                    worker2.Print();
                }
                char c;
                Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню");
                c = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                goto menu;
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
