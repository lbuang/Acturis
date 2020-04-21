using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SF = Microsoft.CodeAnalysis.CSharp.SyntaxFactory;


namespace ConsoleAppRoslyn
{
    public class Person
    {

        /// <summary>
        /// Create a class from scratch.
        /// </summary>
        public void CreateClass()
        {
            // Create a namespace: (namespace CodeGenerationSample)
            var @namespace = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName("ConsoleAppRoslyn")).NormalizeWhitespace();

            @namespace.AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System")));

            //  Create a class: (class Person)
            var classDeclaration = SyntaxFactory.ClassDeclaration("Person")
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword));



            // Create a Property: (public string Name { get; set; })
            var propertyDeclaration = SyntaxFactory.PropertyDeclaration(SyntaxFactory.ParseTypeName("string"), "Name")
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                .AddAccessorListAccessors(
                    SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                    SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)));

            // Create a Property: (public string Surname { get; set; })
            var propertyDeclaration1 = SyntaxFactory.PropertyDeclaration(SyntaxFactory.ParseTypeName("string"), "Surname")
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                .AddAccessorListAccessors(
                    SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                    SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)));

            // Create a Property: (public int Age { get; set; })
            var propertyDeclaration2 = SyntaxFactory.PropertyDeclaration(SyntaxFactory.ParseTypeName("int"), "Age")
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                .AddAccessorListAccessors(
                    SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                    SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)));

            
            //
            // Creating a Public method {Name, Surname, Age}
            var syntax1= SyntaxFactory.ParseStatement($"this.Name = {SyntaxFactory.Literal("Lucky")};");
            var syntax2 = SyntaxFactory.ParseStatement($"this.Surname = {SyntaxFactory.Literal("Buang")};");
            var syntax3 = SyntaxFactory.ParseStatement($"this.Age = 25;");
            
            var method1 = SyntaxFactory.MethodDeclaration(SyntaxFactory.ParseTypeName("void"), "SetNameSurnameAndAge")
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                .WithBody(SyntaxFactory.Block(syntax1, syntax2, syntax3));


            //// PRIVATE FIELD 
            //// private ContactNumber
            //var variableDeclaration = SyntaxFactory.VariableDeclaration(SyntaxFactory.ParseTypeName("int"))
            //     .AddVariables(SyntaxFactory.VariableDeclarator("ContactNumber"));

            //var ContactProperty = SyntaxFactory.FieldDeclaration(variableDeclaration)
            //               .AddModifiers(SyntaxFactory.Token(SyntaxKind.PrivateKeyword));

            ////private  IdNmber

            //var variableDeclaration1 = SyntaxFactory.VariableDeclaration(SyntaxFactory.ParseTypeName("long"))
            //     .AddVariables(SyntaxFactory.VariableDeclarator("IdNumber"));

            //var IdProperty = SyntaxFactory.FieldDeclaration(variableDeclaration1)
            //               .AddModifiers(SyntaxFactory.Token(SyntaxKind.PrivateKeyword));

            // Create a Property: (private IdNumber {get; set;}
            var propertyDeclaration3= SyntaxFactory.PropertyDeclaration(SyntaxFactory.ParseTypeName("long"), "IdNumber")
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PrivateKeyword))
                .AddAccessorListAccessors(
                    SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                    SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)));

            // Create a Property: (public int Age { get; set; })
            var propertyDeclaration4= SyntaxFactory.PropertyDeclaration(SyntaxFactory.ParseTypeName("int"), "ContactNumber")
                .AddModifiers(SyntaxFactory.Token(SyntaxKind.PrivateKeyword))
                .AddAccessorListAccessors(
                    SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                    SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)));



            // Craeting a private metthod {ID anf Contact}
            
            var syntax4= SyntaxFactory.ParseStatement($"this.IdNumber = 9407230000001;");
            var syntax5= SyntaxFactory.ParseStatement($"this.ContactNumber = 0813926534;");
            var method2 = SyntaxFactory.MethodDeclaration(SyntaxFactory.ParseTypeName("void"), "SetContactNumberAndIdNumber")
               .AddModifiers(SyntaxFactory.Token(SyntaxKind.PrivateKeyword))
               .WithBody(SyntaxFactory.Block(syntax4, syntax5));


            // Add the field, the property and method to the class.
            classDeclaration = classDeclaration.AddMembers(propertyDeclaration, propertyDeclaration1, propertyDeclaration2, method1, propertyDeclaration3, propertyDeclaration4, method2);


            // Add the class to the namespace
            @namespace = @namespace.AddMembers(classDeclaration);

            // Normalize and get code as string.
            var output = @namespace
                .NormalizeWhitespace()
                .ToFullString();




            // Output new code to the console and save to a file/destination.
            File.WriteAllText(@"C:\Users\bbdnet2229\source\repos\ReflectionProject\Person.cs", output);
            Console.WriteLine(output);
        }
    }
}

