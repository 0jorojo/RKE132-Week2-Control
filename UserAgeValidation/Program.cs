//ask for age, restrict access

Console.WriteLine("How old are you?");

string age = Console.ReadLine();
int ageNum = 0;
bool isAgeNum = Int32.TryParse(age, out ageNum);

Console.WriteLine($"Parse result {isAgeNum}. User is {ageNum} y.o.");

if(isAgeNum == true)
{
    if (ageNum >= 13)
    {
        Console.WriteLine("Welcome to heck!");
    }
    else
    {
        Console.WriteLine("Go away!");
    }
}
else
{
    Console.WriteLine("Does not compute.");
}

//int age = Int32.Parse(Console.ReadLine());

//if (age >= 13)
//{
//  Console.WriteLine("Welcome to heck!");
//}
//else
//{
//   Console.WriteLine("Go away!");
//}