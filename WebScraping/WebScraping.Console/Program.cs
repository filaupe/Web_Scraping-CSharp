using WebScraping.Library;

using HttpClient client = new();
var result = await client.GetAsync("https://getbootstrap.com/docs/5.3/content/tables/#accented-tables");
var content = await result.Content.ReadAsStringAsync();

var table = WebScrapingMethods.ExtractTable(content);

//foreach (var table in tables)
//{
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
        foreach (var field in table.Body!)
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
//}
Console.WriteLine("Digite S/N para baixar o arquivo");
if (Console.ReadLine()!.ToUpper() == "S")
    table.GetCsvFile(@"C:\Users\android\Desktop\Teste.csv");

