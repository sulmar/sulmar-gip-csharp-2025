using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern;

// Wzorzec Budowniczy 
// odziela obiekt od jego reprezentacji

// Abstract Builder
interface IReportBuilder
{
    void AddHeader();
    void AddContent();
    void AddFooter();

    string Build();
}

// Concrete Builder A
class TextReportBuilder : IReportBuilder
{
    private readonly Report report;

    private string content = string.Empty;

    public TextReportBuilder(Report report)
    {
        this.report = report;
    }

    public void AddHeader()
    {
        content += $"Raport {report.Title} z dn. {DateTime.Now}";
    }

    public void AddContent()
    {
        content += $"Wartosc sprzedazy: {report.TotalAmount:C2}";

        content += $"Ilosc artykulow: {report.Count}";
    }

    public void AddFooter()
    {
        content += "Wygenerowano w aplikacji Builder";
    }

    // Product
    public string Build()
    {
        return content;
    }


}

// Concrete Builder B
class HtmlReportBuilder : IReportBuilder
{
    private readonly Report report;
    private string html;

    public HtmlReportBuilder(Report report)
    {
        this.report = report;
    }

    public void AddContent()
    {
        html += $"<p>Wartosc sprzedazy: {report.TotalAmount:C2}</p>";

        html += $"Ilosc artykulow: {report.Count}";
    }

    public void AddFooter()
    {
        html += "Wygenerowano w aplikacji Builder";
    }

    public void AddHeader()
    {
        html += $"<h1>Raport {report.Title} z dn. {DateTime.Now}</h1>";
    }

    // Product
    public string Build()
    {
        return html;
    }
}

internal class Report
{
    public string Title {  get; set; }
    public decimal TotalAmount { get; set; }
    public int Count { get; set; }
}


// Concrete Builder C
class MarkdownBuilder : IReportBuilder
{
    private readonly Report report;

    private StringBuilder builder = new StringBuilder();

    public MarkdownBuilder(Report report)
    {
        this.report = report;
    }

    public void AddContent()
    {
        builder.AppendLine($"_Wartosc sprzedazy: {report.TotalAmount:C2}_");

        builder.AppendLine($"Ilosc artykulow: {report.Count}");       
    }

    public void AddFooter()
    {
        builder.AppendLine("Wygenerowano w aplikacji Builder");
    }

    public void AddHeader()
    {
        builder.AppendLine( $"*Raport {report.Title} z dn. {DateTime.Now}*");
    }

    // Product
    public string Build()
    {
        return builder.ToString();
    }
}


class PdfBuilder 
{
    public PdfBuilder(Report report)
    {
        
    }
    public void AddContent()
    {
        throw new NotImplementedException();
    }

    public void AddFooter()
    {
        throw new NotImplementedException();
    }

    public void AddHeader()
    {
        throw new NotImplementedException();
    }

    public byte[] Build()
    {
        throw new NotImplementedException();
    }
}


class ReportBuilderFactory
{
    public IReportBuilder Create(Report report, FormatType format)
    {
        switch (format)
        {
            case FormatType.Text: return new TextReportBuilder(report);
            case FormatType.Html: return new HtmlReportBuilder(report);
            case FormatType.Markdown: return new MarkdownBuilder(report);            
            default:
                throw new NotSupportedException();
        }
    }

    public enum FormatType
    {
        Text,
        Html,
        Markdown,
        Pdf
    }
}