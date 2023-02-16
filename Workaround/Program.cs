using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Ahmet";
            person1.LastName = "Demir";
            person1.DateOfBirthYear = 1995;
            person1.NationalIdentity = 12345678901;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }
    }
}
