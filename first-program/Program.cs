// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// This is a single line comment

/*
this is a multi
line comment
*/

/// This is a docstring commet

// C# Characters
char c = 'a';
int i = sizeof(char);

Console.WriteLine(c);
Console.WriteLine(i);

// C# Strings
string name = "John Doe";
string greet = "Hello";

// Interpolation
Console.WriteLine($"{greet} {name}");

// Numbers in C#
// int short long uint float double decimal
Console.WriteLine("Please enter your age:");
int age = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Your age is {age}");

short n1 = 1;
int n2 = (int)n1;
// long n3 = 1L;

// by default are double

float f1 = 1.4f;  // need f
double f2 = (double)f1;

// decimal dd = 333.423m;  // need m 

// Booleans
bool isAdmin = true;

Console.WriteLine($"IS admin? {isAdmin}");

// Arrays on C#

// T name = new T[] {....}

string[] friends = new string[]
    {
      "John",
      "Mary",
      "Daniel",
      "Gaby"
    };

Console.WriteLine(friends[0]);

foreach (var item in friends)
{
  Console.WriteLine($"Friend -> {item}");
}

char ch;

Console.WriteLine("Enter your favourite subject option: ");
ch = (char)Console.Read();

if (ch == 'a') 
{
  Console.WriteLine("The char is a");
} 
else if (ch == 'e') 
{
  Console.WriteLine("The char is e");
}
else 
{
  Console.WriteLine($"The char is {ch}");
}


// Loops
int count = 0;

while (count < 5) 
{
  Console.WriteLine($"The count is {count}");
  count++;
}