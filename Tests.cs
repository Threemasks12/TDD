using UnitConverters;
Console.WriteLine(UnitConverters.UnitRatios.inchToMm);

Converter conv = new Converter();
int tester = 3;
double testerCm = 2.54;

static double mutiply(int a, double b)
{
    return a * b;
};

var accually = mutiply(tester, testerCm);

try
{
    if (accually is double)
    {
        Console.WriteLine("🟢 Test passed");
    }
    else
    {
        Console.WriteLine("🔴 Test failed 2");
    }
}
catch
{
    Console.WriteLine("🔴 Test failed");
}





// Testing input is indeed a number:
/*
Console.WriteLine("write something");

string input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    Console.WriteLine("🟢 Test pased");

}
else
{
    Console.WriteLine("🔴 Test failed");
};
*/


//Start screen for inputs and calculastions
/*
Console.WriteLine("Pick your converter");
Console.WriteLine("1. Inch to MM");
Console.WriteLine("2. Inch to CM");
Console.WriteLine("3. Inch to M");


string converter = Console.ReadLine();

if (int.TryParse(converter, out int convert))
{
    Console.WriteLine("🟢 Test pased");

}
else
{
    Console.WriteLine("🔴 Test failed");
};

if ($"{converter} = '1'")
{
    Console.WriteLine("write the number you want to convert to MM");
    string inputMM = Console.ReadLine();
    converterSum(inputMM * inchToMm);
    if (converterSum == 40)
    {
        Console.WriteLine("🟢 Test pased");

    }
    else
    {
        Console.WriteLine("🔴 Test failed");
    };

}
else if ($"{converter} = '2'")
{
    Console.WriteLine("write the number you want to convert to CM");
    string inputCM = Console.ReadLine();
}
else if ($"{converter} = '3'")
{
    Console.WriteLine("write the number you want to convert to M");
    string inputM = Console.ReadLine();
}
else
{
    Console.WriteLine("Quiting program");
}

*/


//converter test




/*

Console.Write("Enter a decimal number: ");
string userInput = Console.ReadLine();
if (double.TryParse(userInput, out double userValue))
{


    double result = userInput * inchToMm;
    if(double.TryParse(userInput, out double result))
    {
    Console.WriteLine("🟢 Test pased");

}
else
{
    Console.WriteLine("🔴 Test failed");
};



}
else
{
    Console.WriteLine("Invalid input. Please enter a valid decimal number.");
}

*/