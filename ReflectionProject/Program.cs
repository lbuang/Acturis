using ConsoleAppRoslyn;
using System;
using System.Reflection;

namespace ReflectionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var myTypeObjectOfPerson = typeof(classPerson);
            var InstanceOfPerson = Activator.CreateInstance(myTypeObjectOfPerson);

            // Get Method Information.
            var myMethodInfoOfPerson = myTypeObjectOfPerson.GetMethod("SetNameSurnameAndAge");
            myMethodInfoOfPerson.Invoke(InstanceOfPerson, null);

            PropertyInfo[] props = myTypeObjectOfPerson.GetProperties();
            foreach (var prop in props)
            {
                Console.WriteLine(prop.GetValue(InstanceOfPerson));
            }
        }
    }
}