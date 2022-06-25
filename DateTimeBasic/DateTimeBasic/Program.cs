// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(DateTime.Today.DayOfWeek);
DateTime now = DateTime.Now;
Console.WriteLine($"{now.Hour} o'clock {now.Minute} minutes and {now.Second} seconds");

Console.WriteLine("enter a date in the format: yyyy-mm-dd");
string input=Console.ReadLine();
if(DateTime.TryParse(input, out DateTime dt))
{
    Console.WriteLine($"The date you entered is: {dt.ToString()}");
    TimeSpan timeSpan=now.Subtract(dt);
    Console.Write($"{timeSpan.Days} days has passed since");
}
else
{
    Console.WriteLine("wrong input");
}
