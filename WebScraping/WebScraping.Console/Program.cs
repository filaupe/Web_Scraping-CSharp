using HtmlAgilityPack;

const string ROUTE = @"C:\Users\android\Documents\GitHub\Web_Scraping-CSharp\HTMLScrapping\exemploTable01.html";

HtmlDocument doc = new();
doc.Load(ROUTE);

var tables = WebScraping.Console.WebScraping.Tables(doc.Text);

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
    tables[0].GetCsvFile(@"C:\Users\android\Desktop", "Teste.csv");

