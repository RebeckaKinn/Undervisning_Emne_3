namespace Undervisning_Emne_3
{
    internal class Person
    {
        public string name;
        public int age;
        public string adress;

        public Person(string Name, int Age, string Adress)
        {
            name = Name;
            age = Age;
            adress = Adress;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Navn: {name}\nAlder: {age}\nAdresse: {adress}\n");
        }
    }
}
