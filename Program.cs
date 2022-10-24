namespace Modified_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Messages.WelcomeMessage();

                Person person = PersonInfoCapture.Capture();

                bool isPersonValid = PersonValidator.Validate(person);

                if (!isPersonValid)
                {
                    Messages.EndApplication();
                    return;
                }

                EmailGenerator.Create(person);

                Messages.EndApplication();
            
        }
    }
}