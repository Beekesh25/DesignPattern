using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentExample_VisitorDesignPattern
{
    public class VisitorPatternImplimentation
    {
        static void Main(string[] args)
        {
            PICDocument document = new PICDocument();
            DocumentPart paragraph = new Paragraph();
            DocumentPart link = new Link();
            DocumentPart header = new Header();
            document.AddPart(paragraph);
            document.AddPart(link);
            document.AddPart(header);
            document.Open();
            PICDocumentConvertor convertor = new HTMLDocumentConvertor();
            document.Convert(convertor);
            document.Close();

        }
    }
}
public abstract class DocumentPart
{
    public abstract void Open();
    public abstract void Close();
    public abstract void Dispose();
    public abstract void Convert(PICDocumentConvertor pICDocumentConvertor);
}
public class Paragraph : DocumentPart
{
    string content = "Some Content";
    public override void Open()
    {
        Console.WriteLine(content);
    }
    public override void Close()
    {
        Console.WriteLine("Closed Successfully");
    }

    public override void Dispose()
    {
        Console.WriteLine("Disposed Successfully");
    }

    public override void Convert(PICDocumentConvertor pICDocumentConvertor)
    {
        pICDocumentConvertor.convert(this);
    }
}
public class Link : DocumentPart
{
    string title = "Title";
    public override void Open()
    {
        Console.WriteLine(title);
    }
    public override void Close()
    {
        Console.WriteLine("Closed Successfully");
    }

    public override void Dispose()
    {
        throw new NotImplementedException();
    }
    public override void Convert(PICDocumentConvertor pICDocumentConvertor)
    {
        pICDocumentConvertor.convert(this);
    }
}
public class Header : DocumentPart
{
    string header = " Some Header";
    public override void Open()
    {
        Console.WriteLine(header);
    }
    public override void Close()
    {
        Console.WriteLine("Closed Successfully");
    }

    public override void Dispose()
    {
        throw new NotImplementedException();
    }
    public override void Convert(PICDocumentConvertor pICDocumentConvertor)
    {
        pICDocumentConvertor.convert(this);
    }
}
public abstract class PICDocumentConvertor
{
    public abstract void convert(Paragraph paragraph);
    public abstract void convert(Link link);
    public abstract void convert(Header header);
}
public class PICDocument
{
    public List<DocumentPart> parts = new List<DocumentPart>();
    public void Open()
    {
        Console.WriteLine("Open Document");
        foreach (var item in parts)
        {
            item.Open();
        }

    }
    public void Close()
    {
        Console.WriteLine("Closed Successfully");
        foreach (var item in parts)
        {
            item.Close();
        }
    }
    public void Convert(PICDocumentConvertor pICDocumentConvertor)
    {
        foreach (var item in parts)
        {
            item.Convert(pICDocumentConvertor);
        }
    }

    public void AddPart(DocumentPart documentPart)
    {
        parts.Add(documentPart);
    }

    public void RemovePart(DocumentPart documentPart)
    {
        parts.Remove(documentPart);
    }
}

public class HTMLDocumentConvertor : PICDocumentConvertor
{
    public override void convert(Paragraph paragraph)
    {
        Console.WriteLine("Convert Paragraph");
    }

    public override void convert(Link link)
    {
        Console.WriteLine("Convert Link");
    }

    public override void convert(Header header)
    {
        Console.WriteLine("Convert Header");
    }
}