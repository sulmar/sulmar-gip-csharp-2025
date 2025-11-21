using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern;

internal class Report
{
    public string Title {  get; set; }

    public decimal TotalAmount { get; set; }

    public int Count { get; set; }

    public string Create()
    {
        string content = string.Empty;

        // Header
        content += $"Raport {Title} z dn. {DateTime.Now}";

        // Content
        content += $"Wartosc sprzedazy: {TotalAmount:C2}";

        content += $"Ilosc artykulow: {Count}";

        // Footer
        content += "Wygenerowano w aplikacji Builder";

        return content;

    }

    public string CreateHtml()
    {
        string content = string.Empty;

        // Header
        content += $"<h1>Raport {Title} z dn. {DateTime.Now}</h1>";

        // Content

        content += $"<p>Wartosc sprzedazy: {TotalAmount:C2}</p>";

        content += $"Ilosc artykulow: {Count}";

        // Footer
        content += "Wygenerowano w aplikacji Builder";

        return content;

    }
}
