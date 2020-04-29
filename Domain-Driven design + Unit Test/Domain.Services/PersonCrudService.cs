using Data;
using Domain.DefenionObjects;
using Repositories;
using System;
using System.Collections.Generic;

namespace Domain.Services
{
    public class PersonCrudService
    {
        public List<Person> GetAll()
        {
            var personRepository = new PersonRepository();
            var person = personRepository.GetAll();
            return person;
        }

        public Person GetPerson(int id)

        {

            var personRepository = new PersonRepository();



            var person = personRepository.GetPerson(id);

            return person;

        }

        public void CreatePerson(Person person)

        {

            var personRepository = new PersonRepository();



            personRepository.CreatePerson( person);

        }

        public void UpdatePerson(int Id, Person person)

        {

            var personRepository = new PersonRepository();



            personRepository.UpdatePerson(Id, person);

        }

        public void DeletePerson(int Id)

        {

            var personRepository = new PersonRepository();



            personRepository.DeletePerson(Id);

        
        }

    }
}
