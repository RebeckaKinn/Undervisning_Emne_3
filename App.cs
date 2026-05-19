namespace Undervisning_Emne_3
{
    internal class App
    {
        public List<Person> people;

        public App()
        {
            people = new List<Person>
            {
                new Person("Mariann Olsen", 27, "Nyveien 32"),
                new Person("Ola Nordmann", 45, "Oslos Gater"),
            };
        }
        public void Start()
        {
            while (true)
            {
                Console.WriteLine("1 - Legg til ny kontakt\n2 - Se alle kontakter\n3 - Avslutt");
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        AddNewPerson();
                        break;
                    case ConsoleKey.D2:
                        ShowPeopeInfo();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("\n--- avslutter ---\n");
                        return;
                    default:
                        Console.WriteLine("Prøv igjen!\n");
                        break;
                }



            }



        }

        public void ShowPeopeInfo()
        {
            Console.Clear();
            foreach (Person person in people)
            {
                person.PrintInfo();
            }
        }

        public void AddNewPerson()
        {
            Console.Clear();
            Console.Write("Navn: ");
            string name = Console.ReadLine();
            Console.Write("Alder: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adresse: ");
            string adress = Console.ReadLine();

            var newPerson = new Person(name, age, adress);
            people.Add(newPerson);

            Console.WriteLine($"\n{name} er lagt til i listen.");
            Console.WriteLine("--- fortsett ---");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
