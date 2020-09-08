using System;

namespace PeopleLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Vasya vasya = new Vasya();
            Petya petya = new Petya();
            Alex alex = new Alex();
            Maria maria = new Maria();

            Console.ForegroundColor = ConsoleColor.Green;
            vasya.ShowParameters();
            Console.WriteLine();
            vasya.Eat();
            vasya.Drink();
            vasya.Buy("Apple", 1);
            vasya.Buy("Water", 10, petya);
            vasya.Sell("Water", 1);
            vasya.Sell("Water", 3, petya);
            vasya.Drive();
            Console.WriteLine();
            vasya.ShowParameters();
            Console.WriteLine();
            Console.ResetColor();

            petya.ShowParameters();
            Console.WriteLine();
            petya.Eat();
            petya.Drink();
            petya.Buy("Apple", 3);
            petya.Buy("Water", 2, alex);
            petya.Sell("Water", 1);
            petya.Sell("Water", 3, alex);
            petya.PlayDota();
            Console.WriteLine();
            petya.ShowParameters();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            alex.ShowParameters();
            Console.WriteLine();
            alex.Eat();
            alex.Drink();
            alex.Buy("Apple", 4);
            alex.Buy("Water", 4, maria);
            alex.Sell("Water", 1);
            alex.Sell("Water", 3, maria);
            alex.MyDream(); //dream of Alex
            alex.ProgrammingSkill(); //skill of Alex
            Console.WriteLine();
            alex.ShowParameters();
            Console.WriteLine();
            Console.ResetColor();

            maria.ShowParameters();
            Console.WriteLine();
            maria.Eat();
            maria.Drink();
            maria.Buy("Apple", 10);
            maria.Buy("Water", 10, vasya);
            maria.Sell("Water", 1);
            maria.Sell("Water", 3, vasya);
            maria.MyDream(); //dream of Alex
            maria.ProgrammingSkill(); //skill of Alex + parametrs from class Person
            maria.ShowParameters();
            Console.WriteLine();
        }
    }
}
