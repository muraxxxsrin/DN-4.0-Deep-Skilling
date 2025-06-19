using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Documents available:\n.docx \n.pdf \n.xlsx");
        Console.WriteLine("Enter the document type:");
        string type = Console.ReadLine();
        
        if (type.ToLower()=="docx"|| type.ToLower()==".docx")
        {
            DocumentFactory wordFactory = new WordDocumentFactory();
            Document word = wordFactory.createDocument();
            word.creating();
            word.opening();
            word.saveing();
            word.closing();
        }
        else if (type.ToLower() == "pdf" || type.ToLower() == ".pdf")
        {
            DocumentFactory pdfFactory = new PdfDocumentFactory();
            Document pdf = pdfFactory.createDocument();
            pdf.creating();
            pdf.opening();
            pdf.saveing();
            pdf.closing();
        }
        else if (type.ToLower() == "xlsx" || type.ToLower() == ".xlsx")
        {
            DocumentFactory excelFactory = new ExcelDocumentFactory();
            Document excel = excelFactory.createDocument();
            excel.creating();
            excel.opening();
            excel.saveing();
            excel.closing();
        }
    }
}
