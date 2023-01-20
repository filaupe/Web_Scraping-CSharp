using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Text;

namespace WebScraping.Library.Models
{
    public struct TableModel
    {
        public required IEnumerable<string> Header { get; set; }

        public IEnumerable<string>? Body { get; set; }

        public void GetCsvFile(string filePath, string fileName)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";",
                Encoding = Encoding.UTF8,
            };

            using var streamWriter = new StreamWriter(Path.Combine(filePath, fileName));
            using var csv = new CsvWriter(streamWriter, config);
            int count = 0;
            foreach (var header in Header)
                csv.WriteField(header);
            csv.NextRecord();

            if (Body != null)
            {
                count = 0;
                foreach (var field in Body)
                {
                    count++;
                    csv.WriteField(field);
                    if (count == Header.Count())
                    {
                        count = 0;
                        csv.NextRecord();
                    }
                }
                csv.Flush();
            }
        }
    }
}
