namespace Undervisning_Emne_3
{
    internal class App2
    {
        public void Start()
        {

        }

        public void Print()
        {
            Console.WriteLine("Tom!");
        }
        public void Print(string txt)
        {
            Console.WriteLine(txt);
        }
        public void Print(int number)
        {
            Console.WriteLine(number);
        }
        public void Print(string txt, int number)
        {
            Console.WriteLine($"{txt} {number}");
        }
    }
}
