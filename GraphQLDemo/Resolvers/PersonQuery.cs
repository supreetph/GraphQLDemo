using GraphQLDemo.Models;

namespace GraphQLDemo.Resolvers
{
    public class PersonQuery
    {
        private readonly List<Person> _persons = new List<Person>
    {
        new Person { Id = 1, Name = "John", Age = 25 },
        new Person { Id = 2, Name = "Jane", Age = 30 }
    };

        public List<Person> GetPersons() => _persons;
    }
}
