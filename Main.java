package com.company;

import java.util.Scanner;

public class Main {

    public static void main(String[] args)
    {
        System.out.println(" Зоопарк \\\"П О Л И Т Е Х Н И К \\\" \\n\\n");
        System.out.println(" 1  Волки");
        System.out.println(" 2  Бобры");
        System.out.println(" 3  Лисы");
        System.out.println(" 4  Еноты");
        System.out.println(" 5  Медведи");
        System.out.println(" Введите 6, чтобы узнать информацию о сотрудниках");
        System.out.println(" Введите 7, чтобы выйти из программы");
        Scanner in = new Scanner(System.in);
        int check;
        do {
            check = in.nextInt();
        } while (check < 1 || check > 7);
        if (check == 1)
        {
            Wolf wolf1 = new Wolf();
            wolf1.Get();
            String name;
            int age;
            int number;
            System.out.println("Имя волка: ");
            name = in.nextLine();
            do
            {
                System.out.println("Возраст волка: ");
                age = in.nextInt();
            } while (age < 0);
            do
            {
                System.out.println("Номер вольера: ");
                number = in.nextInt();
            } while (number < 1 || number > 3);
            Wolf wolf2 = new Wolf ();
            wolf2.Set(name, age, number);
            wolf1.Print();
            wolf2.Print();
        }
        if (check == 2)
        {
            Beaver beaver1 = new Beaver();
            beaver1.Get();
            String name;
            double weight;
            double lenght;
            Beaver beaver2 = new Beaver();
            System.out.println("Имя бобра: ");
            name = in.nextLine();
            do
            {
                System.out.println("Вес бобра в кг: ");
                weight = in.nextDouble();
            } while (weight < 1);
            do
            {
                System.out.println("Длина хвоста бобра в см: ");
                lenght = in.nextDouble();
            } while (lenght < 0);
            beaver2.Set(name, weight, lenght);
            beaver1.Print();
            beaver2.Print();
        }
        if (check == 3)
        {
            Fox fox1 = new Fox();
            fox1.Get();
            Fox fox2 = new Fox();
            String name;
            double weight;
            int age;
            int number;
            System.out.println("Имя лисы: ");
            name = in.nextLine();
            do
            {
                System.out.println("Вес лисы в кг: ");
                weight = in.nextDouble();
            } while (weight < 1);
            do
            {
                System.out.println("Возраст лисы: ");
                age = in.nextInt();
            } while (age < 0);
            do
            {
                System.out.println("Номер вольера: ");
                number = in.nextInt();
            } while (number < 5 || number > 6);
            fox2.Set(name, weight, age, number);
            fox1.Print();
            fox2.Print();
        }
        if (check == 4)
        {
            Raccon raccon1 = new Raccon();
            raccon1.Get();
            Raccon raccon2 = new Raccon();
            String name;
            double weight;
            int age;
            System.out.println ("Имя енота: ");
            name = in.nextLine();
            do
            {
                System.out.println ("Вес енота в кг: ");
                weight = in.nextDouble();
            } while (weight < 1);
            do
            {
                System.out.println ("Возраст енота: ");
                age = in.nextInt();
            } while (age < 0);
            raccon2.Set(name, weight, age);
            raccon1.Print();
            raccon2.Print();
        }
        if (check == 5)
        {
            Bear bear1 = new Bear();
            bear1.Get();
            Bear bear2 = new Bear();
            String name;
            double weight;
            double high;
            System.out.println("Имя медведя: ");
            name = in.nextLine();
            do
            {
                System.out.println("Вес медведя в кг: ");
                weight = in.nextDouble();
            } while (weight < 1);
            do
            {
                System.out.println("Рост медведя в см: ");
                high = in.nextDouble();
            } while (high < 10);
            bear2.Set(name, weight, high);
            bear1.Print();
            bear2.Print();
        }
        if (check == 6)
        {
            Workers.Name name = new Workers.Name();
            name.Get();
            Workers worker1 = new Workers();
            worker1.Get(name);
            String lastName;
            String _name;
            String patronymic;
            System.out.println("Фамилия: ");
            lastName = in.nextLine();
            System.out.println("Имя: ");
            _name = in.nextLine();
            System.out.println("Отчество: ");
            patronymic = in.nextLine();
            name.Set(lastName, _name, patronymic);
            Workers worker2 = new Workers();
            int code;
            int number;
            int payroll;
            do
            {
                System.out.println("Код сотрудника: ");
                code = in.nextInt();
            } while (code < 100000 || code > 999999);
            do
            {
                System.out.println("Номер вольера: ");
                number = in.nextInt();
            } while (number < 1 || number > 7);
            do
            {
                System.out.println("Заработная плата: ");
                payroll = in.nextInt();
            } while (payroll <= 8000);
            worker2.Set(name, code, number, payroll);
            worker1.Print();
            worker2.Print();
        }
        if (check == 7)
        {
            System.exit(0);
        }
    }
}
