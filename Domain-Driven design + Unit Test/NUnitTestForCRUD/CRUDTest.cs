using Domain.DefenionObjects;
using Domain.Services;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace NUnitTestForCRUD
{

    public class CRUDTest
    {
       public PersonCrudService personCrudService; 
       

        [SetUp]
        public void Setup()
        {
            personCrudService = new PersonCrudService();
            
        }

        [Test]
        public void TestGetAll()
        {

            var pErsOn = personCrudService.GetAll();
            Assert.IsNotNull(pErsOn);
        }

        [Test]

        public void Test_GetPersonBy()

        {

            var pErsOn = personCrudService.GetAll();

            var personToFind = pErsOn.Last();

            var person = personCrudService.GetPerson(personToFind.Id);

            Assert.AreEqual(personToFind.Id, person.Id);

        }

        [Test]
        public void TestCreatePerson()
        {
            var person = new Person { Id = 1, Name = "Lucky", Surname = "Buang",  Gender = "Male"};

            personCrudService.CreatePerson(person);

            var PersonCreated = personCrudService.GetPerson(person.Id);

            Assert.IsNotNull(PersonCreated);
        }

        [Test]
        public void TestUpdatePerson()
        {

            var person = new Person { Id = 1, Name = "Lucky", Surname = "Bua", Gender = "Male" };

            var updating_Person = personCrudService.GetPerson(1);

            personCrudService.UpdatePerson(updating_Person.Id, person);

            var updated_Person = personCrudService.GetPerson(1);

            Assert.AreEqual(person.Id, updated_Person.Id);
        }

        [Test]
        public void TestDeletePerson()
        {

            personCrudService.DeletePerson(2);
            Assert.IsNull(personCrudService.GetPerson(2));
        }
    }
}