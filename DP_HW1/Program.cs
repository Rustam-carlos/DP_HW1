using System;
//Реализовать консольное приложение для паттерна
//Factory Method
//•	Принтер
//•	Тип принтера: Canon, HP
//•	Тип бумаги: Perl, Offset 
//•	Принтер имеет метод print, который выводит сообщение на консоль о том что: Canon печатает бумагой Perl, HP печатает бумагой Offset

namespace DP_HW1
{
    abstract class Printer
    {
        public abstract IPaper GetMethod();
        public string SomeOperation()
        {
            IPaper paper = GetMethod();
            string result = "Printer "
                + paper.Operation();
            return result;
        }
    }
    class Canon : Printer
    {
        public override IPaper GetMethod()
        {
            return new Perl();
        }
    }
    class HP : Printer
    {
        public override IPaper GetMethod()
        {
            return new Offset();
        }
    }
    public interface IPaper
    {
        string Operation();
    }
    class Perl : IPaper
    {
        public string Operation()
        {
            return "{Распечатанно на бумаге Perl}";
        }
    }
    class Offset : IPaper
    {
        public string Operation()
        {
            return "{Распечатанно на бумаге Offset}";
        }
    }
    class Client
    {
        public void Main()
        {
            Console.WriteLine("Печать на принтере Canon");
            ClientCode(new Canon());

            Console.WriteLine("");

            Console.WriteLine("Печать на принтере HP");
            ClientCode(new HP());
        }
        //public void ClientCode(Printer printer)
        //{
        //    Console.WriteLine("Клиент: я не знаю класс создателя, " +
        //"но это все еще работает.\n" + printer.SomeOperation());
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
            Console.ReadKey();
        }
    }
}
