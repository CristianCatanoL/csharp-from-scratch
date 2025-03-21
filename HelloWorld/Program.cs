﻿namespace Helloworld
{

    class Program
    {

        static void Main()
        {

            DateOnly dateConverted = new DateOnly();
            string birthdayInput;
            string nameInput;
            Console.WriteLine("Hola Bienvenido a el calculador de años!");
            Console.WriteLine("Escribe tu nombre: ");
            nameInput = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameInput}");
            Console.WriteLine("Escribe tu fecha de nacimiento en formato dd/mm/yy: ");
            birthdayInput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(birthdayInput, out dateConverted);
            if (isDateValid== false) Console.WriteLine($"La fecha de nacimiento es invalida usted nos envio este dato erroneo {birthdayInput} ");
            var person = new Person
            {
                Name = nameInput,
                Birthday = dateConverted,
                Age = DateTime.Now.Year - dateConverted.Year
            };
            Console.WriteLine($"Tu nombre: {person.Name}");
            Console.WriteLine($"Tu fecha de nacimiento: {person.Birthday}");
            Console.WriteLine($"Tu edad es {person.Age} años!");
            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
    }
}