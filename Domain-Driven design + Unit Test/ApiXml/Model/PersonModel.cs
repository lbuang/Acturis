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

		//	private string name;

		//	public string Name
		//	{
		//		get { return name; }
		//		set 
		//		{
		//			if (name != value)
		//			{
		//				name = value;
		//			}
		//		}
		//	}

		//	private string surname;

		//	public string Surname
		//	{
		//		get { return surname; }
		//		set 
		//		{
		//			if (surname != value)
		//			{
		//				surname = value;
		//			}
		//		}
		//	}

		//	private string contactNo;

		//	public string ContactNo
		//	{
		//		get { return contactNo; }
		//		set 
		//		{
		//			if (contactNo != value)
		//			{
		//				contactNo = value;
		//			}
		//		}
		//	}

		//	private string province;

		//	public string Province
		//	{
		//		get { return province; }
		//		set 
		//		{
		//			if (province != value)
		//			{
		//				province = value;
		//			}
		//		}
		//	}
	}
}
