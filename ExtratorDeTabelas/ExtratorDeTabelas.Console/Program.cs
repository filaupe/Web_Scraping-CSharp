using HtmlAgilityPack;

public class Program
{
    public static void Main(string[] args)
    {
        var path = "C:\\Users\\MulinhaGPlays\\Documents\\GitHub\\Web_Scraping-CSharp\\ExtratorDeTabelas\\ExtratorDeTabelas.Console\\HTMLScrapping\\exemploTable02.html";

        var exdt = new ExtratorDeTabelas.Console.ExtratorDeTabelas();

        //Console.WriteLine(exdt.GetFirstTagTableString(path));
        //Console.WriteLine(exdt.GetAllTagTableString(path)[1]);
        foreach (var row in exdt.GetColumnData(path, "score"))
            Console.WriteLine(row);
        
    }
}