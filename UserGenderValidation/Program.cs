//ask gender & surname, greet by both

Console.Write("Please select your gender (m/f):");
char gender = Char.Parse(Console.ReadLine());

Console.WriteLine("Please enter your surname:");
string name = Console.ReadLine();

if (gender == 'm')
{
    Console.WriteLine($"Greetings, Mr. {name}!");
}
else if (gender == 'f')
{
    Console.WriteLine($"Greetings, Ms. {name}!");
}
else
{
    Console.WriteLine($"Welcome, {name}!");
}