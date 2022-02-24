// See https://aka.ms/new-console-template for more information
using ClassLibraryCalculation;

List<int> List1 = new();

int? a = null;
try
{
    int? result = a * 10;
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());  
}



Console.WriteLine("Hello, please input the first number!");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
string str1 = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
string str2 = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

double num1, num2;
try
{
    num1 = Convert.ToDouble(str1);
    num2 = Convert.ToDouble(str2);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    return;
}

Calc<double> MathCalc = new();

bool isequal = MathCalc.IsEqual(num1, num2);
Console.WriteLine("num1 == num2, {0}", isequal);

double sum = MathCalc.Add(Convert.ToDouble(str1), Convert.ToDouble(str2));

Console.WriteLine("The answer is {0}", sum);
Console.ReadKey();