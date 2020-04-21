using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.IO;
using System.Reflection;

namespace ConsoleAppRoslyn
{
    public class Program
    {
        public static void Main(string[] args)
        
        {
            Person pp = new Person();
            // Create a class
            pp.CreateClass();
            // Wait to exit.
            Console.Read();

           

        }


    }
}
