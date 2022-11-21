using RestWithASPNETUdemy.Model;
using System.Collections.Generic;
using System.Threading;


namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;
        public Person Create( Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List <Person> Findall()
        {
            List<Person> persons = new List<Person>();

            for(int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

      

        public Person FindByID(long id)
        {
            return new Person
            {
                Id = IncrementAnGet(),
                FirstName = "Renato",
                LastName = "Costa",
                Address = "Contagem - Minas Gerais - Brasil",
                Gender = "Male",
            };
        }

        public Person Update( Person person)
        {
            return person;
        }

          private Person MockPerson(int i)
        {
            return new Person
            { 
                Id = IncrementAnGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName" + i,
                Address = "Some Address" +i,
                Gender = "Male"
            };
        }

        private long IncrementAnGet()
        {
            return  Interlocked.Increment(ref count);
        }
        
    }
}