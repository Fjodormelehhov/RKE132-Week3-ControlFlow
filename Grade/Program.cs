
char grade;

Console.WriteLine("Enter your grade:");
grade = Convert.ToChar(Console.ReadLine().ToUpper());

if (grade == 'A')
{
    Console.WriteLine("Suurepärane!");
}
else if (grade == 'B')
{
    Console.WriteLine("Väga hea!");
}
else if (grade == 'C')
{
    Console.WriteLine("Hea!");
}
else if (grade == 'D')
{
    Console.WriteLine("Rahuldav");
}
else if (grade == 'E')
{
    Console.WriteLine("Kasin");
}
else if (grade == 'F')
{
    Console.WriteLine("Puudulik");
}
else
{
    Console.WriteLine("Vale Väärtus");
}