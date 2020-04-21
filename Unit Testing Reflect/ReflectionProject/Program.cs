using System;

namespace ReflectionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var reflection = new Reflection();
            var valueFromReflection = reflection.CheckErrors();
            Console.WriteLine(valueFromReflection);

           
            valueFromReflection.TryGetValue("Name", out object Name);
            Console.WriteLine("Name :" + Name);

            valueFromReflection.TryGetValue("Surname", out object Surname);
            Console.WriteLine("Surname : " + Surname);
            valueFromReflection.TryGetValue("Age", out object Age);
            Console.WriteLine("Age : " + Age);

            valueFromReflection.TryGetValue("ContactNumber", out object ContactNumber);
            Console.WriteLine("Contact Number:" + ContactNumber);

            valueFromReflection.TryGetValue("IdNumber", out object IdNumber);
            Console.WriteLine("ID Number : " + IdNumber);
        }
    }
}