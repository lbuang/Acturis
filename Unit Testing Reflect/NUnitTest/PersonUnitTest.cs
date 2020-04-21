using NUnit.Framework;
using ReflectionProject;
using ConsoleAppRoslyn;
using System.Collections.Generic;

namespace NUnitTest
{
    [TestFixture]
    public class Tests

    {
        Reflection reflection;
        Person person;
        Dictionary<string, object> valueFromReflection;
        [SetUp]
        public void Setup()
        {

            reflection = new Reflection();
            person = new Person();
            person.SetNameSurnameAndAge();
            valueFromReflection = reflection.CheckErrors();

        }


        [Test]

        public void TestName()
        {
            valueFromReflection.TryGetValue("Name", out object Name);
            Assert.AreEqual(person.Name, Name);

        }

        [Test]
        public void TestSurname()
        {
            valueFromReflection.TryGetValue("Surname", out object Surname);
            Assert.AreEqual(person.Surname, Surname);
        }

        [Test]
        public void TestAge()
        {
            valueFromReflection.TryGetValue("Age", out object Age);
            Assert.AreEqual(person.Age, Age);
        }


        [Test]
        public void TestIdNumber()
        {
            valueFromReflection.TryGetValue("IdNumber", out object IdNumber);
            Assert.AreEqual(9407230000001, IdNumber);
        }

        [Test]
        public void TestContactNumber()
        {
            valueFromReflection.TryGetValue("ContactNumber", out object ContactNumber);
            Assert.AreEqual(0813926534, ContactNumber);
        }

    }
}