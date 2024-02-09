




Console.WriteLine("write something");

string input = Console.ReadLine();

if(int.TryParse(input, out int number))
{
    Console.WriteLine("🟢 Test pased");

}
else
{
    Console.WriteLine("🔴 Test failed"); 
};