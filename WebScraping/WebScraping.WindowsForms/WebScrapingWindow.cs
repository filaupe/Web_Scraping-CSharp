using System.Text.RegularExpressions;
using WebScraping.Library;

namespace WebScraping.WindowsForms
{
    public partial class WebScrapingWindow : Form
    {
        public readonly Validations _validate;
        public Regex? _regex;

        public WebScrapingWindow()
        {
            InitializeComponent();

            this.SetFormStyle();
            this.SetDefaultParameters();
            

            _validate = new();
        }

        private void ClearTable()
        {
            dataTableView.Rows.Clear();
            dataTableView.Columns.Clear();
        }

        private void SetFormStyle()
        {
            this.SetTableStyle(); 
        }

        private void SetTableStyle()
        {
            dataTableView.BackgroundColor = Color.White;
        }

        private void SetDefaultParameters()
        {
            delimiterTextBox.Text = ";";
        }

        private List<DataGridViewCell> FindCellsInColumn(int columns, int rows, string columnName)
        {
            List<DataGridViewCell> Cells = new();
            for (int y = 1; y < rows; y++)
            {
                for (int x = 0; x < columns; x++)
                {
                    var column = dataTableView.Columns[x];
                    var cell = dataTableView.Rows[y - 1].Cells[x];

                    if (column.HeaderText.Contains(columnName))
                        Cells.Add(cell);
                }
            }
            return Cells;
        }

        private bool CheckRegexCondition(DataGridViewCell cell, string regex)
        {
            _regex = new(regex);
            return cell.Value != null && !_regex.IsMatch((string)cell.Value);
        }

        private static void AlterCellColor(DataGridViewCell cell, Color color) => cell.Style.BackColor = color;

        private void FindUnMatch(string regex, string columnName)
        {
            _regex = new(regex);
            int notMatches = 0;
            int columns = dataTableView.ColumnCount;
            int rows = dataTableView.RowCount;
            var cells = this.FindCellsInColumn(columns, rows, columnName);

            if (CpfCheckBox.Checked)
            {
                foreach (var cell in cells)
                {
                    if (this.CheckRegexCondition(cell, regex))
                    {
                        notMatches++;
                        AlterCellColor(cell, Color.Red);
                    }     
                }
            }
            else
            {
                foreach (var cell in cells)
                {
                    
                    if (this.CheckRegexCondition(cell, regex))
                        AlterCellColor(cell, Color.White);
                }
            }
            InvalidCount.Text = $"{notMatches} {columnName} Inválidos";
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            char delimiter = String.IsNullOrWhiteSpace(delimiterTextBox.Text) ? ';' : delimiterTextBox.Text.ToCharArray()[0];
            OpenFileDialog fileDialog = new();

            this.ClearTable();
            fileDialog.ShowDialog();

            var (headerString, bodyStrings) = WebScrapingMethods.ReadFile(fileDialog.FileName).ToTableStrings();
            var header = headerString.Split(delimiter).ToList();

            header.ForEach(x => dataTableView.Columns.Add(x, x));
            bodyStrings.ForEach(x => dataTableView.Rows.Add(x.Split(delimiter)));
        }

        private void CpfCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string value = String.IsNullOrWhiteSpace(CpfVariantTextBox.Text) ? "CPF" : CpfVariantTextBox.Text;
            this.FindUnMatch(_validate.CPF, value);
        }
    }
}