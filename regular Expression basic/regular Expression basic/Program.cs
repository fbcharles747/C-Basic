// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

string pattern = @"\d{3}";
Regex regex = new Regex(pattern);
string text = "Here is my number 12354563";
MatchCollection matches= regex.Matches(text);
Console.WriteLine($"There are {matches.Count} hit found in {text}");

for(int i = 0; i < matches.Count; i++)
{
    Match match = matches[i];
    Console.WriteLine($"The {i} match is: {match.Value} ");
}
foreach (Match match in matches)
{
    Console.WriteLine(match.Value);
}
