using GraphQLDemo.Models;

namespace GraphQLDemo.Mutations
{
    public class PersonMutation
    {
        private readonly List<Person> _persons = new List<Person>();

        public Person AddPerson(string name, int age)
        {
            var person = new Person { 
                Id = _persons.Count + 1,
                Name = name,
                Age = age };
            _persons.Add(person);
            return person;
        }
    }
}
