Console.WriteLine("Hello, World!");
//declaring variables in a strict language
int number = 13;
double rate = 3.14;
char letter = 'A';
string name = "David";
bool isHappy = true;

Console.WriteLine(rate); //Cannot change number to a string! (must be in it's own WriteLine)
Console.WriteLine($"Name: {name}, Letter: {letter}, Is Happy {isHappy}");

// if loop syntax 
if (number > 0)
{
    Console.WriteLine("The number is positive.");
}
else if (number < 0)
{
    Console.WriteLine("The number is negative.");
}
else
{
    Console.WriteLine("The number is zero.");
}

// switch syntax
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
    default:
        Console.WriteLine("Invalid day");
        break;
}
// for loops look very similar to js
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}


Greet(name);

static void Greet(string name)
{
    Console.WriteLine("Hello, " + name);
}

