using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern;

class Order
{
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
}

// Happy Hours - 10% upustu w godzinach od 9:00 - 15:00
internal class HappyHoursOrderCalculator
{
    private readonly int from;
    private readonly int to;
    private readonly decimal percentage;

    public HappyHoursOrderCalculator(int from, int to, decimal percentage)
    {
        this.from = from;
        this.to = to;
        this.percentage = percentage;
    }

    public decimal CalculateDiscount(Order order)
    {
        if (order.OrderDate.Hour >= from && order.OrderDate.Hour <= to)
        {
            return order.TotalAmount - order.TotalAmount * percentage;
        }
        else
            return order.TotalAmount;
    }
}
