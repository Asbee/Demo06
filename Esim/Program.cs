using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an object from Personss
            Personss myfriends = new Personss();


            //Create a few Friends
            Persons person1 = new Persons { Firstname = "jussi", Lastname = "Joku", SocialSecurityNumber = "020202-123" };
            Persons person2 = new Persons { Firstname = "jkski", Lastname = "pepe", SocialSecurityNumber = "02355-123" };
            Persons person3 = new Persons { Firstname = "dssd", Lastname = "123", SocialSecurityNumber = "1232323123" };
            Persons person4 = new Persons { Firstname = "jussi", Lastname = "Joku", SocialSecurityNumber = "020202-123" };

            myfriends.AddPersons(person1);
            myfriends.AddPersons(person2);
            myfriends.AddPersons(person3);
            myfriends.AddPersons(person4);

            //Print Collection
            myfriends.PrintCollection();

            //get one person
            Console.WriteLine("Get one person from collection");
            Persons person = myfriends.GetPerson(1);
            if (person != null)
            {
                Console.WriteLine(person.ToString());
            }
            else
            {
                Console.WriteLine("Cannot find person");
            }
            //Find person with sotu
            Console.WriteLine("Get one person with right sotu");
            string socialsecuritynumber = "1232323123";
           Persons person5 = myfriends.FindPerson(socialsecuritynumber);
            if (person5 != null)
            {
                Console.WriteLine(person.ToString());
            }
            else
            {
                Console.WriteLine("Cannot find person");
            }
        }
    }
}
