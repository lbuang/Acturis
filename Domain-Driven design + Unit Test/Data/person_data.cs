using Domain.DefenionObjects;
using System;

namespace Data
{
    public class person_data
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Gender { get; set; }

        public person_data FromDomain(Person person)
        {
            return new person_data
            {
                Id = person.Id,
            };
        }
    }
}
