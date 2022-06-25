// See https://aka.ms/new-console-template for more information


String[] lines = { "first line", "second line", "third line" };
File.WriteAllLines(@"C:\Users\camel\C#WorkSpace\C#basic\ReadingWritingBasic\hello.txt", lines);

/*
string text = System.IO.File.ReadAllText("hello.txt");
Console.WriteLine(text);
string[] lines = System.IO.File.ReadAllLines(@"C:\Users\camel\C#WorkSpace\C#basic\RWFile\hello.txt");
foreach(string line in lines)
{
    Console.WriteLine("\t" +line);
}
*/
