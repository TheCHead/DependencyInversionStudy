using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace DependencyInversionStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Person owner = new Person
            {
                FirstName = "Cloud",
                LastName = "Strife",
                EmailAddress = "cstrife@shinra.com",
                PhoneNumber = "666-5555"
            };

            Chore chore = new Chore
            {
                ChoreName = "Get ultima weapon",
                Owner = owner
            };

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
