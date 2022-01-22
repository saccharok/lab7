package com.company;

import java.util.Scanner;

public class Workers
{
    public static class Name
    {
        String lastName;
        String name;
        String patronymic;
        public Name () { };
        public void Set (String _lastName, String _name, String _patronymic)
        {
            Name name = new Name();
            this.lastName = _lastName;
            this.name = _name;
            this.patronymic = _patronymic;
        };
        public void Get ()
        {
            String _lastName;
            String _name;
            String _patronymic;
            Scanner in = new Scanner (System.in);
            System.out.println("Фамилия: ");
            _lastName = in.nextLine();
            System.out.println("Имя: ");
            _name = in.nextLine();
            System.out.println("Отчество: ");
            _patronymic = in.nextLine();
            lastName = _lastName;
            name = _name;
            patronymic = _patronymic;
        };
        public void Print ()
        {
            System.out.printf("ФИО: %s %s %s.\n", lastName, name, patronymic);
        };
    };
    Name name;
    int code;
    int number;
    int payroll;
    public Workers () { };
    public void Set (Name _name, int _code, int _number, int _payroll)
    {
        Workers worker = new Workers();
        worker.name = _name;
        worker.code = _code;
        worker.number = _number;
        worker.payroll = _payroll;
    }
    public static class HelperClass
    {
        public int _code;
        public int _number;
        public int _payroll;
        public int CheckCode (int code)
        {
            if (code < 100000 || code > 999999)
                return code;
            else return 0;
        }
        public int CheckNumber (int number)
        {
            if (number < 100000 || number > 999999)
                return number;
            else return 0;
        }
        public int CheckPayroll (int payroll)
        {
            if (payroll <= 8000)
                return payroll;
            else return 0;
        }
    }
    public void Get (Name _name)
    {
        int _code;
        int _number;
        int _payroll;
        Scanner in = new Scanner(System.in);
        HelperClass help = new HelperClass();
        do
        {
            System.out.println("Код сотрудника: ");
            _code = in.nextInt();
            help._code = help.CheckCode(_code);
        } while (help._code == 0);
        do
        {
            System.out.println("Номер вольера: ");
            _number = in.nextInt();
            help._number = help.CheckNumber(_number);
        } while (help._number == 0);
        do
        {
            System.out.println("Заработная плата: ");
            _payroll = in.nextInt();
            help._payroll = help.CheckPayroll(_payroll);
        } while (help._payroll == 0);
        name = _name;
        code = _code;
        number = _number;
        payroll = _payroll;
    }
    public void Print ()
    {
        name.Print();
        System.out.printf("Код сотрудника: %d. Номер вольера: %d. Заработная плата:  %d.\n", code, number, payroll);
    }
}
