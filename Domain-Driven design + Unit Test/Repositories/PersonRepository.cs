using Data;
using Domain.DefenionObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Repositories
{
    public class PersonRepository
    {
        
        public Person ToDomain(person_data personData)
        {
            return new Person
            {
                Id = personData.Id,
                Name = personData.Name,
                Surname = personData.Surname,
                Gender = personData.Gender
            };
        }

        public List<person_data> personlist = new List<person_data>

        {

           new person_data { Id = 1, Name = "Lucky", Surname = "Buang", Gender = "Male" },

            new person_data { Id = 2, Name = "Koketso", Surname = "Chuene", Gender = "Female" },

            new person_data { Id = 3, Name = "Goisimang", Surname = "Buang", Gender = "Female" },

            new person_data { Id = 4, Name = "Ragnar", Surname = "Lothbrok", Gender = "Male" }

        };

        public void Serialize(List<person_data> people)

        {

            var Path = @"C:\Users\bbdnet2229\source\repos\ApiXml\Person.xml";

            TextWriter txtWriter = new StreamWriter(Path);



            XmlSerializer serializer = new XmlSerializer(typeof(List<person_data>));



            serializer.Serialize(txtWriter, people);



            txtWriter.Close();

        }

        public List<person_data> deserializer()

        {

            var Path = @"C:\Users\bbdnet2229\source\repos\ApiXml\Person.xml";

            List<person_data> persons;

            XmlSerializer serializer = new XmlSerializer(typeof(List<person_data>));

            using (Stream reader = new FileStream(Path, FileMode.Open))

            {

                persons = (List<person_data>)serializer.Deserialize(reader);



            }

            return persons;
        }

      
    public List<Person> GetAll()
        {
            var Path = @"C:\Users\bbdnet2229\source\repos\ApiXml\Person.xml";
            if (!(File.Exists(Path)))

                Serialize(personlist);

            var peopleData = deserializer();//get all the people stored in your xml file

            var people = peopleData.Select(person => ToDomain(person));
            return people.ToList();
        }

        public Person GetPerson(int Id)

        {
            
            var people = GetAll();

            var selectedpersonById = people.FirstOrDefault(person => person.Id == Id);

            Person perSon = null;

            if (selectedpersonById != null)

            {

                perSon = selectedpersonById;

            }

            return perSon;
        }

    public void CreatePerson(Person PersonData)
        {
            var peopleData = deserializer();
            var pdata = new person_data();
            peopleData.Add(pdata.FromDomain(PersonData));
            Serialize(peopleData);
            peopleData.Select(person => ToDomain(person));
        }

     public void UpdatePerson(int Id, Person PersonData)
        {
            var peopleData = deserializer();


            var selectedPerson = peopleData.FirstOrDefault(person => person.Id == Id);



            selectedPerson.Id = PersonData.Id;

            selectedPerson.Name = PersonData.Name;

            selectedPerson.Surname = PersonData.Surname;

            selectedPerson.Gender = PersonData.Gender;


            Serialize(peopleData);

            peopleData.Select(person => ToDomain(person));

        }

        public void DeletePerson(int Id)

        {

            var peopleData = deserializer();

            var selectedPerson = from selected in peopleData

                                 where selected.Id == Id

                                 select selected;

            person_data remove = null;

            foreach (var selected in selectedPerson)

            {

                remove = selected;

            }

            peopleData.Remove(remove);

            Serialize(peopleData);

            peopleData.Select(person => ToDomain(person));

        }

    }

      
}


