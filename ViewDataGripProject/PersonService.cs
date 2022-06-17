using System.Collections.Generic;
using System.Linq;

namespace ViewDataGripProject
{
    public interface IPersonService
    {
        IEnumerable<Person> GetAllPersons();
        IEnumerable<Person> GetPersonsByCriteria(int ID, string name, int age);
    }

    public class PersonService: IPersonService
    {
        // this is only place where whole list is instantiated
        private List<Person> _persons = PersonManager.Create(count: 50);

        public IEnumerable<Person> GetAllPersons()
        {
            return _persons.Select(person => person);
        }

        public IEnumerable<Person> GetPersonsByCriteria(int ID, string name, int age)
        {
            var query = GetAllPersons();
            if (ID > 0)
                query = query.Where(person => person.ID == ID);
            if (age > 0)
                query = query.Where(person => person.Age <= age);
            if (!string.IsNullOrEmpty(name))
                query = query.Where(person => object.Equals(person.Name, name));
            return query;
        }
    }
}