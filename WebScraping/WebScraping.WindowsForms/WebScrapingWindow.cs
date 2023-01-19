using System.Text;
using System.Text.RegularExpressions;

namespace WebScraping.WindowsForms
{
    public partial class WebScrapingWindow : Form
    {
        public WebScrapingWindow()
        {
            InitializeComponent();
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            Regex cpfRegex = new("^\\d{3}\\.\\d{3}\\.\\d{3}\\-\\d{2}$");
            OpenFileDialog path = new();
            StringBuilder archive = new();
            path.ShowDialog();

            using var file = new StreamReader(path.FileName);
            string? line;

            while ((line = file.ReadLine()) != null)
                archive.AppendLine(line);

            var lines = archive.ToString()
                .Replace("\r\n", "\n")
                .Split("\n")
                .Where(c => !String.IsNullOrWhiteSpace(c))
                .ToArray();

            var header = lines[0].Split(";");
            int o = 0;
            int notMatches = 0;
            foreach (var item in header)
                if (!item.Contains("CPF"))
                    o++;

            dataTableView.ColumnCount = header.Length;

            for (int i = 0; i < header.Length ; i++)
                dataTableView.Columns[i].Name = header[i];
            for (int i = 1; i < lines.Length; i++)
            {
                var row = lines[i].Split(";");
                dataTableView.Rows.Add(row);
                if (!cpfRegex.IsMatch(row[o]))
                {
                    notMatches++;
                    dataTableView.Rows[i-1].Cells[o].Style.BackColor = Color.Red;
                } 
            }
            InvalidCpfCount.Text = $"{notMatches} CPFs Inválidos";
        }
    }
}