using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Kristaps");
            Person person2 = person;
            

            person.Name = "Kristaps";
            person.Age = 15;
            person.IsMale = true;
            person.Money = 154.58;
            person.Initial = 'A';

            person2.Age = 26;


            string greeting = person.GetGreeting();

            Console.WriteLine(greeting);


        }
    }
}
