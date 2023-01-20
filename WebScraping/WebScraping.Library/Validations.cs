namespace WebScraping.Library
{
    public class Validations
    {
        public string CPF = @"^\d{3}\.\d{3}\.\d{3}\-\d{2}$";
        public string Phone = @"^\d{2,3}\d{2}\d{8,9}$";
        public string CNPJ = @"^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$";
        public string Email = @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$";
    }
}
