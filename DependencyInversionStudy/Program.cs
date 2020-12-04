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
            IPerson owner = Factory.CreatePerson();

            owner.FirstName = "Cloud";
            owner.LastName = "Strife";
            owner.EmailAddress = "cstrife@shinra.com";
            owner.PhoneNumber = "666-5555";


            IChore chore = Factory.CreateChore();

            chore.ChoreName = "Get ultima weapon";
            chore.Owner = owner;
            

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
