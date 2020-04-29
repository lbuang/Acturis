using System.Collections.Generic;
using System.Linq;
using ApiXml.Model;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using Domain.Services;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using HttpPutAttribute = Microsoft.AspNetCore.Mvc.HttpPutAttribute;
using HttpDeleteAttribute = Microsoft.AspNetCore.Mvc.HttpDeleteAttribute;


namespace ApiXml.Controller
{

    [ApiController]
    [Route("[Controller]")]
    public class PersonController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<PersonModel>> GetPeople()
        {
            var personCrudService = new PersonCrudService();
            var people = personCrudService.GetAll();


            var peopleModels = people.Select(person => PersonModel.FromDomain(person));
            return peopleModels.ToList();
        }

        [Microsoft.AspNetCore.Mvc.HttpGet("{Id}")]



        public PersonModel GetPerson(int id)

        {

            var personCrudService = new PersonCrudService();

            var person = personCrudService.GetPerson(id);

            PersonModel PersonFromDomain = null;

            if (person != null)

                PersonFromDomain = PersonModel.FromDomain(person);

            return PersonFromDomain;



        }


        [HttpPost]

        public IActionResult CreatePeople(PersonModel persondata)

        {

            var personCrudService = new PersonCrudService();

            personCrudService.CreatePerson(persondata.ToDomain());

            return Ok(GetPeople());

        }
        [HttpPut("{Id}")]

        public IActionResult UpdatePerson(int Id, PersonModel PersonData)

        {

            var personCrudService = new PersonCrudService();

            personCrudService.UpdatePerson(Id, PersonData.ToDomain());

            return Ok(GetPeople());

        }

        [HttpDelete("{Id}")]

        public IActionResult DeletePerson(int Id)

        {

            var personCrudService = new PersonCrudService();

            personCrudService.DeletePerson(Id);

            return Ok(GetPeople());

        }

    }
}
