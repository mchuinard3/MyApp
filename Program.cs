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
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

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
  static void Main(string[] args)
  {
    Car myObj1 = new Car();
    Car myObj2 = new Car();
    Console.WriteLine(myObj1.color);
    Console.WriteLine(myObj2.color);
  }
}

//instantiate a class (make a new object):


