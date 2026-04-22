Console.WriteLine("Hello, World!");

// Declare and use variables
string aFriend = "Bill";
Console.WriteLine($"Hello {aFriend}");
aFriend = "Maria";
Console.WriteLine($"Hello {aFriend}");

// Work with strings
string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

// Remove whitespace from strings
string greeting = "    Hello World!    ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

// Search and replace text in strings
string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

// Make a string all caps or all lowercase
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

// Return a boolean value
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.StartsWith("goodbye"));

Console.WriteLine(songLyrics.EndsWith("hello"));
Console.WriteLine(songLyrics.EndsWith("goodbye"));


// Explore integer math
//WorkWithIntegers();
OrderPrecedence();

void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);

    // subtraction
    c = a - b;
    Console.WriteLine(c);

    // multiplication
    c = a * b;
    Console.WriteLine(c);

    // division
    c = a / b;
    Console.WriteLine(c);
}

void OrderPrecedence()
{
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d);

    d = (a + b) * c;
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);
}

// Explore integer precision and limits
int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");
int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");

// Work with the double type
void WorkWithDoubles()
{
    double i = 19;
    double j = 23;
    double k = 8;
    double l = (i + j) / k;
    Console.WriteLine(l);

    double dmax = double.MaxValue;
    double dmin = double.MinValue;
    Console.WriteLine($"The range of double is {dmin} to {dmax}");
    double third = 1.0 / 3.0;
    Console.WriteLine(third);
}

// Work with decimal types
decimal decmin = decimal.MinValue;
decimal decmax = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {decmin} to {decmax}");

double m = 1.0;
double n = 3.0;
Console.WriteLine(m / n);

decimal o = 1.0M;
decimal p = 3.0M;
Console.WriteLine(o / p);

// Calculate the area of a circle
double radius = 2.5;
double area = Math.PI * radius * radius;
Console.WriteLine($"The area of a circle with radius {radius} is {area}");