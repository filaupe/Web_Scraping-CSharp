using HtmlAgilityPack;
using WebScraping.Library;

const string ROUTE = @"C:\Users\MulinhaGPlays\Documents\GitHub\Web_Scraping-CSharp\HTMLScrapping\exemploTable01.html";

HtmlDocument doc = new();
doc.Load(ROUTE);

var ws = new WebScrapingMethods();
var tables = ws.ExtractTables(doc.Text);

foreach (var table in tables)
{
    int count;
    Console.Write("Pré-Visualização da Tabela:");
    Console.Write("\n");
    Console.Write("\n");
    foreach (var header in table.Header)
    {
        Console.Write(header);
        Console.Write("|");
    }
    Console.Write("\n");
    if (table.Body != null)
    {
        count = 0;
        foreach (var field in table.Body)
        {
            count++;
            Console.Write(field);
            Console.Write("|");
            if (count == table.Header.Count())
            {
                count = 0;
                Console.Write("\n");
            }
        }
    }

}
Console.WriteLine("Digite S/N para baixar o arquivo");
if (Console.ReadLine()!.ToUpper() == "S")
    tables[0].GetCsvFile(@"C:\Users\MulinhaGPlays\Desktop", "Teste.csv");

