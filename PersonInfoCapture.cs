using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modified_Project
{
    public class PersonInfoCapture
    {
        public static Person Capture()
        {
            Person person = new();

            Console.Write("Please enter your first name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            person.LastName = Console.ReadLine();

            return person;
        }
    }
}
