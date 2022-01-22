// lab7C++.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <Windows.h>
#include "Workers.h"
#include "Wolf.h"
#include "Beaver.h"
#include "Fox.h"
#include "Raccon.h"
#include "Bear.h"
using namespace std;

void NumbersWolfs(Wolf wolf1, Wolf wolf2, Wolf wolf3)
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
	cout << "Вольер - 1: ";
	cin >> i;
	cout << "Вольер - 2: ";
	cin >> j;
	cout << "Вольер - 3: ";
	cin >> k;
}

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
menu:
	system("cls");
	cout << " Зоопарк \"П О Л И Т Е Х Н И К \" " << endl << endl;
	cout << "1 " << "Волки" << endl;
	cout << "2 " << "Бобры" << endl;
	cout << "3 " << "Лисы" << endl;
	cout << "4 " << "Еноты" << endl;
	cout << "5 " << "Медведи" << endl << endl;
	cout << "Сотрудники - 6" << endl << endl;
	cout << "Выход из программы - 7" << endl;
	int check = 0;
	while (check < 1 || check > 7)
	{
		cin >> check;
		cout << endl;
	};
	if (check == 1)
	{
		system("cls");
		cout << " Зоопарк \"П О Л И Т Е Х Н И К \" " << endl << endl;
		cout << "   Волки" << endl << endl;
		Wolf wolf1;
		wolf1.GetWolf();
		Wolf wolf2;
		std::string _nameW;
		cout << "Имя волка: ";
		cin >> _nameW;
		int _ageW, _numW;
		while (_ageW <= 0)
		{
			cout << "Возраст волка: ";
			cin >> _ageW;
		}
		while (_numW < 1 || _numW > 2)
		{
			cout << "Номер вольера: ";
			cin >> _numW;
		}
		wolf2.SetWolf(_nameW, _ageW, _numW);
		wolf1.PrintWolf();
		wolf2.PrintWolf();
		char c;
		cout << endl << "Намжите любую клавишу для возвращения в меню." << endl;
		cin >> c;
		goto menu;
	}
	else if (check == 2)
	{
		system("cls");
		cout << " Зоопарк \"П О Л И Т Е Х Н И К \" " << endl << endl;
		cout << "   Бобры" << endl << endl;
		Beaver beaver1;
		beaver1.GetBeaver();
		Beaver beaver2;
		std::string _nameBeav;
		double _weightBeav, _lenghtBeav;
		cout << "Имя бобра: ";
		cin >> _nameBeav;
		while (_weightBeav <= 0)
		{
			cout << "Вес бобра: ";
			cin >> _weightBeav;
		}
		while (_lenghtBeav <= 0)
		{
			cout << "Длина хвоста бобра в сантиметрах: ";
			cin >> _lenghtBeav;
		}
		Beaver beaver2;
		beaver2.SetBeaver(_nameBeav, _weightBeav, _lenghtBeav);
		beaver1.PrintBeaver();
		beaver2.PrintBeaver();
		char c = ' ';
		char c;
		cout << endl << "Намжите любую клавишу для возвращения в меню." << endl;
		cin >> c;
		goto menu;
	}
	else if (check == 3)
	{
		system("cls");
		cout << " Зоопарк \"П О Л И Т Е Х Н И К \" " << endl << endl;
		cout << "   Лисы" << endl << endl;
		Fox fox1;
		fox1.GetFox();
		Fox fox2;
		std::string _nameF;
		double _weightF;
		int _ageF;
		int _numberF;
		cout << "Имя лисы: ";
		cin >> _nameF;
		while (_weightF <= 0)
		{
			cout << "Вес лисы: ";
			cin >> _weightF;
		}
		while (_ageF <= 0)
		{
			cout << "Возраст лисы: ";
			cin >> _ageF;
		}
		while (_numberF < 5 || _numberF > 6)
		{
			cout << "Номер вольера: ";
			cin >> _numberF;
		};
		fox2.SetFox(_nameF, _weightF, _ageF, _numberF);
		fox1.PrintFox();
		fox2.PrintFox();
		char c;
		cout << endl << "Намжите любую клавишу для возвращения в меню." << endl;
		cin >> c;
		goto menu;
	}
	else if (check == 4)
	{
		system("cls");
		cout << " Зоопарк \"П О Л И Т Е Х Н И К \" " << endl << endl;
		cout << "   Еноты" << endl << endl;
		Raccon rac1;
		rac1.GetRaccon();
		Raccon rac2;
		std::string _nameR;
		double _weightR;
		int _ageR;
		cout << "Имя енота: ";
		cin >> _nameR;
		while (_weightR <= 0)
		{
			cout << "Вес енота: ";
			cin >> _weightR;
		}
		while (_ageR <= 0)
		{
			cout << "Возраст енота: ";
			cin >> _ageR;
		}
		rac2.SetRaccon(_nameR, _weightR, _ageR);
		rac1.PrintRaccon();
		rac2.PrintRaccon();
		char c;
		cout << endl << "Намжите любую клавишу для возвращения в меню." << endl;
		cin >> c;
		goto menu;
	}
	else if (check == 5)
	{
		system("cls");
		cout << " Зоопарк \"П О Л И Т Е Х Н И К \" " << endl << endl;
		cout << "   Медведи" << endl << endl;
		Bear bear1;
		bear1.GetBear();
		Bear bear2;
		std::string _nameBear;
		double _weightBear;
		double _highBear;
		int _ageBear;
		cout << "Имя медведя: ";
		cin >> _nameBear;
		while (_weightBear <= 0)
		{
			cout << "Вес медведя в кг: ";
			cin >> _weightBear;
		}
		while (_highBear <= 0)
		{
			cout << "Рост медведя: ";
			cin >> _highBear;
		}
		while (_ageBear <= 0)
		{
			cout << "Возраст медведя: ";
			cin >> _ageBear;
		}
		bear2.SetBear(_nameBear, _weightBear, _highBear, _ageBear);
		bear1.PrintBear();
		bear2.PrintBear();
		char c;
		cout << endl << "Намжите любую клавишу для возвращения в меню." << endl;
		cin >> c;
		goto menu;
	}
	else if (check == 6)
	{
		system("cls");
		cout << " Зоопарк \"П О Л И Т Е Х Н И К \" " << endl << endl;
		cout << "   Сотрудники" << endl << endl;
		Workers worker1;
		worker1.GetWorker();
		Workers::Name name1;
		std::string _lastName, _name, _patronymic;
		cout << "Введите фамилию сотрудника: ";
		cin >> _lastName;
		cout << "Введите имя сотрудника";
		cin >> _name;
		cout << "Введите отчество сотрудника";
		cin >> _patronymic;
		Workers worker2;
		name1 = worker2.SetName(_lastName, _name, _patronymic);
		int _code;
		int _number;
		int _payroll;
		do {
			cout << "Код сотрудника: ";
			cin >> _code;
		} while (_code < 100000 || _code > 999999);
		do {
			cout << "Номер вольера: ";
			cin >> _number;
		} while (_number < 1 || _number > 7);
		do {
			cout << "Заработная плата: ";
			cin >> _payroll;
		} while (_payroll <= 8000);
		worker2.SetWorker(name1, _code, _number, _payroll);
		cout << "Получить информацию: \n 1.Кратко \n 2.Полностью";
		int flag;
		do {
			cin >> flag;
		} while (flag < 1 || flag > 2);
		if (flag == 1)
		{
			cout << "Кратко:" << endl;
			worker1.PrintName();
			worker2.PrintName();
		}
		else
		{
			cout << "Полностью: " << endl;
			worker1.PrintWorker();
			worker2.PrintWorker();
		}
		char c;
		cout << endl << "Намжите любую клавишу для возвращения в меню." << endl;
		cin >> c;
		goto menu;
	}
	else exit(1);
}

// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
