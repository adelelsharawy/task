// See https://aka.ms/new-console-template for more information

int firstNumber, scondNumber, sum = 0;


Console.WriteLine("enter the first number");
firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("enter the scond number");
scondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("\n The prime numbers betwen {0} and {1} is : \n", firstNumber, scondNumber);


for (int a = firstNumber; a <= scondNumber; a++)
{
    sum = 0;
    for (int b = 2; b <= a / 2; b++)
    {
        if (a % b == 0)
        {
            sum = sum + 1;
            break;
        }
    }
    if (sum == 0 && a != 1 && a != 0)
    {
        Console.WriteLine("\t {0}", a);
    }
}








