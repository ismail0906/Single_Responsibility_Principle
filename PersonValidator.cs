using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modified_Project
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrEmpty(person.FirstName) || person.FirstName.StartsWith(" "))
            {
                Messages.ValidationError("First name");
                return false;
            }
            if (string.IsNullOrEmpty(person.LastName) || person.LastName.StartsWith(" "))
            {
                Messages.ValidationError("Last name");
                return false;
            }
            return true;
        }
    }
}
