using ConsoleAppRoslyn;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ReflectionProject
{
    public class Reflection
    {
        public Dictionary<string, object> CheckErrors()
        {
            var myTypeObjectOfPerson = typeof(Person);
            var InstanceOfPerson = Activator.CreateInstance(myTypeObjectOfPerson);

            // Get Method Information.
            var myMethodInfoOfPerson = myTypeObjectOfPerson.GetMethod("SetNameSurnameAndAge");
            myMethodInfoOfPerson.Invoke(InstanceOfPerson, null);


            var SetContactNumberAndIdNumber = myTypeObjectOfPerson.GetMethod("SetContactNumberAndIdNumber", BindingFlags.NonPublic | BindingFlags.Instance);
            SetContactNumberAndIdNumber.Invoke(InstanceOfPerson, null);


            PropertyInfo[] props = myTypeObjectOfPerson.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);



            var checker = new Dictionary<string, object>();
            foreach (var prop in props)
            {

                /*onsole.WriteLine(prop.GetValue(InstanceOfPerson));*/

                checker.Add(prop.Name, prop.GetValue(InstanceOfPerson));


            }
            return checker;
        }

     }
}
