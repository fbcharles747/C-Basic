// See https://aka.ms/new-console-template for more information
string input = File.ReadAllText(@"C:\Users\camel\C#WorkSpace\C#basic\Assignment 2\input.txt");
string[] output = input.Split("split");
File.WriteAllLines(@"C:\Users\camel\C#WorkSpace\C#basic\Assignment 2\output.txt", output);

