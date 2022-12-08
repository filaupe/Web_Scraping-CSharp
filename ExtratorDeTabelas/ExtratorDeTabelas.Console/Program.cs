using System.Collections.Immutable;
using System.Text.RegularExpressions;

var html = File.ReadAllText("C:\\Users\\MulinhaGPlays\\Documents\\GitHub\\Web_Scraping-CSharp\\ExtratorDeTabelas\\ExtratorDeTabelas.Console\\HTMLScrapping\\exemploTable01.html");

Regex reHTML = new("<tr[\\s\\S]*?<\\/tr>", RegexOptions.Multiline);
var table = reHTML.Matches(html.Replace(" ", ""));
Regex reTDS = new("<[tdh]*>(.*)</[tdh]*>", RegexOptions.Multiline);
var tds = reTDS.Matches(table[0].ToString());
int local = -1;
List<string> scoreList = new();
foreach (var td in tds)
{
	local++;
	if (td.ToString()!.ToLower().Contains("score")) break;
}
Regex extrairConteudo = new(@"(<td>.*</td>)");
var tableList = table.ToList();
tableList.RemoveAt(0);
foreach (var tr in tableList)
{
	var trTds = reTDS.Matches(tr.ToString()!);
	var conteudo = extrairConteudo.Matches(trTds[local].ToString());
	scoreList.Add(conteudo[0].ToString().Replace("<td>", "").Replace("</td>", ""));
}

foreach (var item in scoreList)
{
	Console.WriteLine(item);
}