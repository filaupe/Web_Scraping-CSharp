using System.Text;
using System.Text.RegularExpressions;
using WebScraping.Library.Models;

namespace WebScraping.Library
{
    public static class WebScrapingMethods
    {
        public static TableModel ExtractTable(string fileText)
        {
            int a = 0;
            var tables = ExtractDataInTableTag(fileText, "table");

            var head = tables.Select(table => table = String.Join(String.Empty, ExtractDataInTags(table, "thead"))).ToList();
            head = head.Select(table => table = String.Join(String.Empty, ExtractDataInTags(table, "tr"))).ToList();
            head = ExtractDataInTags(String.Join(String.Empty, head), "th").ToList();
            head.RemoveAt(0);

            var body = tables.Select(table => table = String.Join(String.Empty, ExtractDataInTags(table, "tbody"))).ToList();
            body = body.Select(table => table = String.Join(String.Empty, ExtractDataInTags(table, "tr"))).ToList();
            body = ExtractDataInTags(String.Join(String.Empty, body), "td").ToList();

            if (body.Any(c => c.Contains("th")))
            {
                foreach (var item in body.ToList())
                    if (item.Contains("<th"))
                        body.Remove(item);
            }

            return new TableModel
            {
                Header = head,
                Body = body
            };
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
        public static IEnumerable<string> ExtractDataInTableTag(string fileText, string tagName)
        {
            Regex regex = new($"<{tagName}*>(.+?)</{tagName}>"); //<\\s*{tagName}[^>]*>(.*?)<\\s*\\/\\s*{tagName}>
            fileText = RemoveSpacesAndLineBreaks(fileText);
            fileText = fileText[fileText.IndexOf($"<{tagName}")..(fileText.IndexOf($"</{tagName}>") + (3 + tagName.Length))];
            return regex.Split(fileText).Where(x => !String.IsNullOrWhiteSpace(x));
        }
        public static IEnumerable<string> ExtractDataInTags(string fileText, string tagName)
        {
            Regex regex = new($"<\\s*{tagName}[^>]*>(.*?)<\\s*\\/\\s*{tagName}>"); //<{tagName}*>(.+?)</{tagName}>
            fileText = RemoveSpacesAndLineBreaks(fileText);
            fileText = fileText[fileText.IndexOf($"<{tagName}")..(fileText.LastIndexOf($"</{tagName}>") + (3 + tagName.Length))];
            return regex.Split(fileText).Where(x => !String.IsNullOrWhiteSpace(x));
        }
        public static string RemoveSpacesAndLineBreaks(string text)
            => String.Join(String.Empty, String.Join(String.Empty, text.Split("\r")).Split("\n").Select(c => c.Trim()));
    }
}
