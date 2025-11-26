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

// Happy Hours - 10% upustu w godzinach od 8:30 - 15:30
internal class HappyHoursOrderCalculator
{
    private readonly TimeSpan from;
    private readonly TimeSpan to;
    private readonly decimal percentage;

    public HappyHoursOrderCalculator(TimeSpan from, TimeSpan to, decimal percentage)
    {
        this.from = from;
        this.to = to;
        this.percentage = percentage;
    }

    public decimal CalculateDiscount(Order order)
    {
        if (order.OrderDate.TimeOfDay >= from && order.OrderDate.TimeOfDay <= to)
        {
            return order.TotalAmount - order.TotalAmount * percentage;
        }
        else
            return order.TotalAmount;
    }
}
