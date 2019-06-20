using System;

namespace lesson5HandsOn
{
    public class Person
    {
        // Part 1
        string firstName;
        string lastName;
        int age;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                // Part 3
                if (value < 0)
                {
                    Console.WriteLine("Attempted to set age to an invalid value. Set age to 0 instead.");
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }

        // Part 2
        public Person()
        {
            firstName = "";
            lastName = "";
            age = 0;
        }

        public Person(string personFirstName, string personLastName, int personAge)
        {
            firstName = personFirstName;
            lastName = personLastName;
            age = personAge;

            // Part 3
            if (age < 0)
            {
                Console.WriteLine("Attempted to set age to an invalid value. Set age to 0 instead.");
                age = 0;
            }
            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Linus";
            person1.LastName = "Tomwaldi";
            person1.Age = 33;

            person2.FirstName = "Connie";
            person2.LastName = "Rohand";
            person2.Age = 31;

            Console.WriteLine(person1.FirstName + " " + person1.LastName + " is " + person1.Age + " years old.");
            Console.WriteLine(person2.FirstName + " " + person2.LastName + " is " + person2.Age + " years old.");

            // Part 2
            Person person3 = new Person("Jennifer", "Conrad", -42);
            Person person4 = new Person("Patrick", "Charmise", 45);
        }
    }

}