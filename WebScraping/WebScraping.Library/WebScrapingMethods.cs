using System.Text;
using System.Text.RegularExpressions;
using WebScraping.Library.Models;

namespace WebScraping.Library
{
    public static class WebScrapingMethods
    {
        public static List<TableModel> ExtractTables(string fileText)
        {
            List<TableModel> formatTables = new();
            var tables = ExtractDataInTags(fileText, "table");
            tables = tables.Select(table => table = String.Join(String.Empty, ExtractDataInTags(table, "tr")));
            foreach (var table in tables)
            {
                var model = new TableModel
                {
                    Header = ExtractDataInTags(table, "th"),
                    Body = ExtractDataInTags(table, "td")
                };
                formatTables.Add(model);
            }
            return formatTables;
        }
        public static string ReadFile(string path)
        {
            StringBuilder archive = new();
            using var file = new StreamReader(path);
            string? line;
            while ((line = file.ReadLine()) != null)
                archive.AppendLine(line);
            file.Close();
            return archive.ToString();
        }

        public static (string, List<string>) ToTableStrings(this string archive)
        {
            var data = archive.Replace("\r\n", "\n").Split("\n").Where(c => !String.IsNullOrWhiteSpace(c)).ToList();
            string header = data[0];
            data.RemoveAt(0);
            List<string> body = data;
            return (header, body);
        }
        public static IEnumerable<string> ExtractDataInTags(string fileText, string tagName)
        {
            Regex regex = new($"<{tagName}*>(.+?)</{tagName}>"); //<\\s*{tagName}[^>]*>(.*?)<\\s*\\/\\s*{tagName}>
            fileText = RemoveSpacesAndLineBreaks(fileText);
            fileText = fileText[fileText.IndexOf($"<{tagName}")..(fileText.LastIndexOf($"</{tagName}>") + (3 + tagName.Length))];
            return regex.Split(fileText).Where(x => !String.IsNullOrWhiteSpace(x));
        }
        public static string ExtractDataInTag(string fileText, string tagName) => ExtractDataInTags(fileText, tagName).ToArray()[0];
        public static string RemoveSpacesAndLineBreaks(string text)
            => String.Join(String.Empty, String.Join(String.Empty, text.Split("\r")).Split("\n").Select(c => c.Trim()));
    }
}
