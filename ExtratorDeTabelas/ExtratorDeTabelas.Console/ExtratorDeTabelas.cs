using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace ExtratorDeTabelas.Console
{
    public class ExtratorDeTabelas
    {
        public string GetFirstTagTableString(string path)
        {
            var doc = new HtmlDocument();
            doc.Load(path);
            return doc.DocumentNode.SelectSingleNode("//table").OuterHtml;
        }
        public List<string?> GetAllTagTableString(string path)
        {
            List<string?> result = new();
            var doc = new HtmlDocument();
            doc.Load(path);
            var htmlNodes = doc.DocumentNode.SelectNodes("//table").ToList();
            htmlNodes.ForEach(c => result.Add(c.OuterHtml));
            return result;
        }
        public List<string> GetColumnData(string path, string columnName)
        {
            int index;
            List<string> result = new();
            var doc = new HtmlDocument();
            var tables = this.GetAllTagTableString(path);
            List<HtmlNode> htmlNodes = new();
            foreach (var table in tables)
            {
                try
                {
                    doc.LoadHtml(table);
                    htmlNodes = doc.DocumentNode.SelectNodes("//tr").ToList();
                    break;
                }
                catch { }
            }
            index = htmlNodes[0].InnerText.Split("\n").Count(c => c.Contains(columnName)); // não funciona

            return result;
        }
    }
}
