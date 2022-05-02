// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is " + DateTime.Now);

//make a string:
string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

//make a number:
int myNum = 15;
double a = 5;
decimal c = 1.0M;

//make a boolean:
bool isCSharpFun = true;

//make an if/else if/else block:
int time = 20;
if (time < 18)
{
    Console.WriteLine("Good day.");
}
else
{
    Console.WriteLine("Good evening.");
}
// Outputs "Good evening."

//make a switch block:
int day = 4;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
}
// Outputs "Thursday" (day 4)

//make an array of strings:
string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

//make a for loop:
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

//log each item:
//dotnet run command in terminal

//make a class (object structure):
class Car
{
    string color = "red";
}

//instantiate a class (make a new object):
class Boat
{
    string color = "blue";
    static void Main(string[] args)
    {
        Boat myObj1 = new Boat();
        Boat myObj2 = new Boat();
        Console.WriteLine(myObj1.color);
        Console.WriteLine(myObj2.color);
    }
}

//make a method (function, in a class)
namespace MyApplication
{
    class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        static void Main(string[] args)
        {
            MyMethod();
        }
    }
}
// Outputs "I just got executed!"

//make a method that returns a value:
namespace MyApplication
{
    class Math
    {
        private int Subtract(int firstNumber, int secondNumber)
        {
            int answer;
            answer = firstNumber - secondNumber;
            return answer;
        }
    }
}

//call from instance of class:
//I have researched this but I am still unsure on it.



