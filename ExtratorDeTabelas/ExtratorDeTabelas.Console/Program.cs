using System.Text.RegularExpressions;

var html = File.ReadAllText("C:\\Users\\android\\Documents\\GitHub\\Web_Scraping-CSharp\\ExtratorDeTabelas\\ExtratorDeTabelas.Console\\HTMLScrapping\\exemploTable02.html");

Regex re = new("<tr.*>.*<\\/tr>", RegexOptions.Multiline);
var table = re.Matches(html);
foreach (var row in table)
    Console.WriteLine(row);
