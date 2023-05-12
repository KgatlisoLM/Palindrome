// See https://aka.ms/new-console-template for more information

Console.Write("Enter a string to see if it's a Palindrome: ");

string name = Console.ReadLine();

char[] nameArray = name.ToCharArray();

Array.Reverse(nameArray);

string reverse = new string(nameArray);

if (name.Equals(reverse, StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine($"{name} is Palindrome");
}
else
{
    Console.WriteLine($"{name} is not Palindrome");
}
Console.ReadKey();
