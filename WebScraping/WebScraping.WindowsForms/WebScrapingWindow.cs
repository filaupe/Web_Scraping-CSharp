using System.Text.RegularExpressions;
using WebScraping.Library;
using WebScraping.Library.Models;

namespace WebScraping.WindowsForms
{
    public partial class WebScrapingWindow : Form
    {
        private readonly Validations _validate;
        private Regex? _regex;
        private TableModel? _tableModel;

        public WebScrapingWindow()
        {
            InitializeComponent();

            this.SetFormStyle();
            this.SetDefaultParameters();
            
            _validate = new();
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
        private void ClearTable()
        {
            dataTableView.Rows.Clear();
            dataTableView.Columns.Clear();
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

                    if (column.HeaderText.ToUpper().Contains(columnName.ToUpper()))
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

            if (CpfCheckBox.Checked || !String.IsNullOrWhiteSpace(CustomColumnTextBox.Text))
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
            else if (!CpfCheckBox.Checked || String.IsNullOrWhiteSpace(CustomColumnTextBox.Text))
            {
                foreach (var cell in cells)
                {
                    
                    if (this.CheckRegexCondition(cell, regex))
                        AlterCellColor(cell, Color.White);
                }
            }
            InvalidCount.Text = $"{notMatches} {columnName} Inválidos";
        }
        private void FilterOptions(string regex, string value, string variant)
        {
            try
            {
                value = String.IsNullOrWhiteSpace(variant) ? value : variant;
                this.FindUnMatch(regex, value);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Você precisa fazer o upload de um arquivo para poder filtra-lo. Erro:{ex.Message}");
            }
        }
        private static async Task<string?> GetHtml(string url)
        {
            using HttpClient client = new();
            var result = await client.GetAsync(url);
            return await result.Content.ReadAsStringAsync();
        }
        private async void WebPageToTable()
        {
            try
            {  
                string? html = await GetHtml(SearchSiteTextBox.Text);
                if (html != null)
                {
                    _tableModel = WebScrapingMethods.ExtractTable(html);
                    var header = _tableModel.Value.Header.ToList();
                    var body = _tableModel.Value.Body!.ToList();
                    PrintInTable(header, body);
                }
                else MessageBox.Show("Error, nada foi requerido. Tente novamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Este não é um url válido. Tente novamente. \n Erro: {ex.Message}");
            }
        }
        private void PrintInTable(List<string> header, List<string> bodyStrings, char delimiter)
        {
            this.ClearTable();
            header.ForEach(x => dataTableView.Columns.Add(x, x));
            bodyStrings.ForEach(x => dataTableView.Rows.Add(x.Split(delimiter)));
        }
        private void PrintInTable(List<string> header, List<string> bodyStrings)
        {
            int count = 0;
            List<string> columns = new List<string>();
            this.ClearTable();
            header.ForEach(x => dataTableView.Columns.Add(x, x));
            foreach (var item in bodyStrings)
            {
                columns.Add(item);
                count++;
                if (count == header.Count)
                {
                    count = 0;
                    dataTableView.Rows.Add(columns.ToArray());
                    columns = new List<string>();
                }
            }
            dataTableView.Rows.Add(columns.ToArray());
        }
        private void UploadBtn_Click(object sender, EventArgs e)
        {
            char delimiter = String.IsNullOrWhiteSpace(delimiterTextBox.Text) ? ';' : delimiterTextBox.Text.ToCharArray()[0];
            OpenFileDialog fileDialog = new();

            fileDialog.ShowDialog();

            var (headerString, bodyStrings) = WebScrapingMethods.ReadFile(fileDialog.FileName).ToTableStrings();
            var header = headerString.Split(delimiter).ToList();

            PrintInTable(header, bodyStrings, delimiter);
        }
        private void CpfCheckBox_CheckedChanged(object sender, EventArgs e) 
            => this.FilterOptions(_validate.CPF, "CPF", CpfVariantTextBox.Text);
        private void PhoneCheckBox_CheckedChanged(object sender, EventArgs e) 
            => this.FilterOptions(_validate.Phone, "Telefone", PhoneVariantTextBox.Text);
        private void EmailCheckBox_CheckedChanged(object sender, EventArgs e) 
            => this.FilterOptions(_validate.Email, "Email", EmailVariantTextBox.Text);
        private void CnpjCheckbox_CheckedChanged(object sender, EventArgs e) 
            => this.FilterOptions(_validate.CNPJ,"CNPJ", CnpjVariantTextBox.Text);
        private void VerifyBtn_Click(object sender, EventArgs e)
        {
            string column = CustomColumnTextBox.Text;
            string regex = CustomRegularExpressionTextBox.Text;
            if (!String.IsNullOrWhiteSpace(regex) && !String.IsNullOrWhiteSpace(column))
                this.FilterOptions(regex, column, column);
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            string none = String.Empty;
            string column = CustomColumnTextBox.Text;
            string regex = CustomRegularExpressionTextBox.Text;
            CustomColumnTextBox.Text = none;
            CustomRegularExpressionTextBox.Text = none;
            if (!String.IsNullOrWhiteSpace(regex) && !String.IsNullOrWhiteSpace(column))
                this.FilterOptions(regex, column, column);
        }
        private void SearchBtn_Click(object sender, EventArgs e) => this.WebPageToTable();

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog fileDialog = new();

                fileDialog.ShowDialog();

                _tableModel!.Value.GetCsvFile($"{fileDialog.FileName}.csv");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Selecione uma tabela primeiro! Erro:{ex}");
            }
        }
    }
}