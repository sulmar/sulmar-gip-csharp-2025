
using ExtensionMethodConsoleApp;
using ExtensionMethodConsoleApp.Extensions;

Console.WriteLine("Hello, Extension Methods!");

DateTime date = DateTime.Today.AddWorkDays(3);

if (date.IsWeekend())
{
    Console.WriteLine("juz weekend :-)");
}
else
{
    Console.WriteLine("Ciezka robota :-(");
}




