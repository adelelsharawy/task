// See https://aka.ms/new-console-template for more information

int firstnumber, scondnumber, sum = 0;

Console.WriteLine("Please enter the first number1");
firstnumber = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter the scond number2");
scondnumber  =int.Parse(Console.ReadLine());

Console.WriteLine("\n The prefect numbers between {0} and {1} is :\n", firstnumber, scondnumber);

for (int x = firstnumber; x <= scondnumber; x++)
{
    sum = 0;
    for (int y = 1; y < x; y++)
    {
        if (x % y == 0)
        {
            sum += y; 
        }
    }
    if (sum == x && x != 0)
        Console.WriteLine(x);
}






