using System.Text.RegularExpressions;
using WebScraping.Console.Objects;

namespace WebScraping.Console;

public class WebScraping
{
    public static List<TableModel> Tables(string fileText)
    {
        List<TableModel> formatTables = new();
        var tables = ExtractData(fileText, "table");
        tables = tables.ToList().Select(table => table = String.Join(String.Empty, ExtractData(table, "tr")));
        foreach (var table in tables)
        {
            var model = new TableModel
            {
                Header = ExtractData(table, "th"),
                Body = ExtractData(table, "td")
            };
            formatTables.Add(model);
        }
        return formatTables;
    }
    public static IEnumerable<string> ExtractData(string fileText, string tagName)
    {
        Regex regex = new ($"<{tagName}*>(.+?)</{tagName}>");
        fileText = RemoveSpacesAndLineBreaks(fileText);
        fileText = fileText[fileText.IndexOf($"<{tagName}")..(fileText.LastIndexOf($"</{tagName}>") + (3 + tagName.Length))];
        return regex.Split(fileText).Where(x => !String.IsNullOrWhiteSpace(x));
    }
    private static string RemoveSpacesAndLineBreaks(string text)
        => String.Join(String.Empty, String.Join(String.Empty, text.Split("\r")).Split("\n").Select(c => c.Trim()));
}