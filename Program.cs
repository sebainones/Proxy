using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Person : IPerson
    {
        public int Age { get; set; }

        public string Drink()
        {
            return "drinking";
        }

        public string Drive()
        {
            return "driving";
        }

        public string DrinkAndDrive()
        {
            return "driving while drunk";
        }
    }

    public interface IPerson
    {
        int Age { get; set; }
        string Drink();
        string Drive();
        string DrinkAndDrive();
    }

    public class ResponsiblePerson : IPerson
    {
        private IPerson _person;

        public int Age
        {
            get
            {
                return _person.Age;
            }
            set
            {

                _person.Age = value;
            }
        }

        public ResponsiblePerson(Person person)
        {
            // todo
            this._person = person;
        }

        public string Drink()
        {
            if (_person.Age >= 18)
                return "drinking";
            else
                return "too young";
        }

        public string Drive()
        {
            if (_person.Age >= 16)
                return "driving";
            else
                return "too young";
        }

        public string DrinkAndDrive()
        {
            return "dead";
        }
    }
}

