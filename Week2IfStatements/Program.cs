Console.WriteLine("Enter your lastname:");
string lastName = Console.ReadLine();

Console.WriteLine("Enter your gender (f/m/d):");
char userGender = char.Parse(Console.ReadLine());

string greeting;

if(userGender == 'f')
{
    greeting = "Ms.";
}
else if (userGender == 'm')
{
    greeting = "Mr.";
}
else
{
    greeting = "";
}

Console.WriteLine($"Hello, {greeting} {lastName}!");

Console.WriteLine("Enter your birthday:");

int userYB = Int32.Parse(Console.ReadLine());

int currentYear = DateTime.Now.Year;

int userAge = currentYear - userYB;

//Console.WriteLine($"Current year: {currentYear}");

//int userAge = Int32.Parse(Console.ReadLine());


if (userAge >= 13)
{
    Console.WriteLine($"You are {userAge} - old enough to have an account");
}
else
{
    Console.WriteLine($"You are {userAge} - too young to have an account");
}