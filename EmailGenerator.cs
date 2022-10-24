using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modified_Project
{
    public class EmailGenerator
    {
        public static void Create(Person person)
        {
            string emailDraft = $"{person.FirstName[..1]}.{person.LastName}";

            person.EmailAdress = $"{emailDraft.ToLower()}@company.com";

            Messages.EmailGeneratorSuccess(person);
        }
    }
}
