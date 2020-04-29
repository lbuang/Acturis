using Domain.DefenionObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiXml.Model
{
    public class PersonModel
    {

		public  int Id { get; set; }

		public string Name { get; set; }

		public string Surname { get; set; }

		public string Gender { get; set; }

		public static PersonModel FromDomain(Person person)
		{
			return new PersonModel
			{
				Id = person.Id,
				Name = person.Name,
				Surname = person.Surname,
				Gender = person.Gender
			};
		}

		public Person ToDomain()
		{
			return new Person
			{
				Id = this.Id,
				Name = this.Name,
				Surname = this.Surname,
				Gender = this.Gender
			};
		}

		
	}
}
