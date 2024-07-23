using Business.Concrete;
using Entitites.Concrete;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.NationalIdentity = 56842447180;
            person.FirstName = "Fatma";
            person.LastName = "Birel";
            person.DateOfBirthYear = 2001;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person);
            Console.ReadLine();
        }
    }
}