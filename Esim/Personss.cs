using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    /// <summary>
    /// This class holds person objective and give a few methods
    /// </summary>
    class Personss
    {
        /// <summary>
        /// Persons holds person objectives
        /// </summary>
        private List<Persons> persons;

        /// <summary>
        /// Default constructor initialize a collection
        /// </summary>
        public Personss()
        {
            persons = new List<Persons>();
        }
        /// <summary>
        /// param name ="person" added person 
        /// </summary>
        /// <param name="person"></param>
        public void AddPersons(Persons person)
        {
            persons.Add(person);
        }

        public Persons GetPerson(int index)
        {
            if (index < persons.Count)
            return persons.ElementAt(index);
            else return null;
        }
        public Persons FindPerson(string socialsecuritynumber)
        {
            foreach(Persons person in persons)
            {
                if(socialsecuritynumber.Equals(person.SocialSecurityNumber))
                {
                    // Person with sotu found...
                    return person;
                }
            }
            //Person with sotu not found...
            return null;
        }
        
        public void PrintCollection()
        {
            Console.WriteLine("Persons in collection");
            foreach(Persons person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
        

    }
}
