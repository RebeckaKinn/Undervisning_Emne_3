

/*
string newName = "Rebecka";
int number = 1;
bool isTrue = true;
float decimalNumber = 1.5F;
double exstraNumber = 2.2;
char symbol = '$';

var newSymbol = 'K';
*/
//Console.Write(newName);
//Console.WriteLine($"Hei {newName}");


//var inputKey = Console.ReadKey();
//Console.WriteLine($"inputKey: {inputKey.Key}");

//var input = Console.Read();
//Console.WriteLine($"input: {input}");




//Console.WriteLine("Skriv inn navnet ditt:");
//string input = ReadString();
//PrintString(input);

//void PrintString(string newInput)
//{
//    Console.WriteLine($"Hei {newInput}!");
//}

//string ReadString()
//{
//    return Console.ReadLine();
//}






//Console.WriteLine("Trykk på en tast:");
//var key = ShowReadKey();
//Console.Clear();
//Console.WriteLine($"Du trykket på: {key.Key}");


//ConsoleKeyInfo ShowReadKey()
//{
//    return Console.ReadKey();
//}

Console.WriteLine("Write a number:");
var input1 = Console.ReadLine();
Console.WriteLine(" + ");
var input2 = Console.ReadLine();
Console.WriteLine($"= {AddNumbers(Convert.ToInt32(input1), Convert.ToInt32(input2))}");

int AddNumbers(int number1, int number2)
{
    return number1 + number2;
}
//Pause til 1105