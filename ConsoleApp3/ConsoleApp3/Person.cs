using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Person

    {
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }


        private int _age;
        public int Age
        {
            get
            {
                return _age;

            }
            set
            {

                _age = Math.Abs(value);
            }

        }

        



        
       


        

        public double Money { get; set; }


        public bool IsMale { get; set; }


        public char Initial { get; set; }

        public string GetGreeting()
        {
            string greeting = "Hello my name is " + Name + "and I am" + Age + " years old";

            return greeting;

        }



       
    }
}
