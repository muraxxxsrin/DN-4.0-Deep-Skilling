using System;

public class Program
{
    public static void Main(string[] args)
    {
        
            DocumentFactory wordFactory = new WordDocumentFactory();
            Document word = wordFactory.createDocument();
            word.creating();
            word.opening();
            word.saveing();
            word.closing();
            Console.WriteLine("--------------------------------------------------");
            DocumentFactory pdfFactory = new PdfDocumentFactory();
            Document pdf = pdfFactory.createDocument();
            pdf.creating();
            pdf.opening();
            pdf.saveing();
            pdf.closing();
            Console.WriteLine("--------------------------------------------------");
            DocumentFactory excelFactory = new ExcelDocumentFactory();
            Document excel = excelFactory.createDocument();
            excel.creating();
            excel.opening();
            excel.saveing();
            excel.closing();
        
    }
}
