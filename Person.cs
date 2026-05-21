namespace Undervisning_Emne_3
{
    internal class Person
    {
        public string name { get; private set; }
        public int age;
        public string adress;

        public Person(string Name, int Age, string Adress)
        {
            name = Name;
            age = Age;
            adress = Adress;
        }
        public Person(string Name = "ukjent", int Age = 0)
        {
            name = Name;
            age = Age;
            adress = "Ukjent";
        }
        public Person(int Age)
        {
            name = "Ukjent";
            age = Age;
            adress = "Ukjent";
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Navn: {name}\nAlder: {age}\nAdresse: {adress}\n");
        }
    }
}
