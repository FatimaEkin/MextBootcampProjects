

using MextFirstLesson;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Person> people = new()
    
{
    new Person()
    {
        Name = "Fatima",
        Surname = "Ekin",
        PhoneNumber = "123450000"
    },
    new Person()
    {
        Name = "Elif",
        Surname = "Demir",
        PhoneNumber = "789789789"
    }
};

        void PrintMenu()
        {
            Console.WriteLine("1 - List People");
            Console.WriteLine("2 - Add Person");
            Console.WriteLine("3 - Remove Person");
            Console.WriteLine("4 - Update Person");
        }

        string ReadConsoleWithMessage(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        void PrintPeople()
        {
            foreach (var person in people)
                Console.WriteLine($"{person.Name}-{person.Surname}-{person.PhoneNumber}"); //Name-Surname-PhoneNumber
        }

        void AddPerson()
        {
            string name = ReadConsoleWithMessage("Please enter a name: ");
            string surname = ReadConsoleWithMessage("Please enter a surname: ");
            string phoneNumber = ReadConsoleWithMessage("Please enter a phone number: ");

            Person person = new()
            {
                Name = name,
                Surname = surname,
                PhoneNumber = phoneNumber
            };

            people.Add(person);
            Console.WriteLine($"{name} is saved!");
        }

        void DeletePerson()
        {
            string phoneNumber = ReadConsoleWithMessage("Please enter a phone number to delete: ");
            string name = "";
            foreach (var person in people)
            {
                if (person.PhoneNumber == phoneNumber)
                {
                    name = person.Name;
                    people.Remove(person);
                    return;
                }
            }

            Console.WriteLine($"{name} is deleted!");
        }

        void UpdatePerson()
        {


            string phoneNumber = ReadConsoleWithMessage("Please enter a phone number to update: "); //234234
            int index = -1;

            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].PhoneNumber == phoneNumber)
                {
                    index = i;
                }
            }




            if (index == -1)
            {
                Console.WriteLine("Person not found!");
                return;
            }



            string nameUpdated = ReadConsoleWithMessage("Please enter name updated version: ");
            string surnameUpdated = ReadConsoleWithMessage("Please enter surname updated version: ");
            string phoneNumberUpdated = ReadConsoleWithMessage("Please enter phone number updated version: ");

            string oldName = people[index].Name;

            people[index].Name = nameUpdated;
            people[index].Surname = surnameUpdated;
            people[index].PhoneNumber = phoneNumberUpdated;

            Console.WriteLine($"{oldName} is updated to {nameUpdated}!");
            Console.WriteLine();
        }

        while (true)
        {
            PrintMenu();

            string selection = ReadConsoleWithMessage("Enter a selection:");

            if (selection == "1")
                PrintPeople();

            else if (selection == "2")
                AddPerson();

            else if (selection == "3")
                DeletePerson();

            else if (selection == "4")
                UpdatePerson();
        }
    }
}
