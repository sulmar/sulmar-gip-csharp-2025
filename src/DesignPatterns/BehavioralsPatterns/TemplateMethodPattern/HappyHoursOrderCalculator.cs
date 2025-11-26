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
internal class HappyHoursOrderCalculator : PercentageOrderCalculatorTemplate
{
    private readonly TimeSpan from;
    private readonly TimeSpan to;

    public HappyHoursOrderCalculator(TimeSpan from, TimeSpan to, decimal percentage)
        : base(percentage)
    {
        this.from = from;
        this.to = to;
    }

    public override bool CanDiscount(Order order) => order.OrderDate.TimeOfDay >= from && order.OrderDate.TimeOfDay <= to;
}

// SpecialDate - 20% upustu w okreslony dzien
class SpecialDateOrderCalculator : PercentageOrderCalculatorTemplate
{
    private readonly DateTime specialDate;

    public SpecialDateOrderCalculator(DateTime specialDate, decimal percentage)
        : base(percentage)
    {
        this.specialDate = specialDate;
    }

    public override bool CanDiscount(Order order) => order.OrderDate.Date == specialDate.Date;

}

abstract class PercentageOrderCalculatorTemplate : OrderCalculatorTemplate
{
    private decimal percentage;

    protected PercentageOrderCalculatorTemplate(decimal percentage)
    {
        this.percentage = percentage;
    }

    public override decimal GetDiscount(Order order) => order.TotalAmount - order.TotalAmount * percentage;
}

// Template Method 
abstract class OrderCalculatorTemplate
{
    public abstract bool CanDiscount(Order order);
    public abstract decimal GetDiscount(Order order);

    public decimal CalculateDiscount(Order order)
    {
        if (CanDiscount(order)) // Predykat
        {
            return GetDiscount(order); // Rabat
        }
        else
            return order.TotalAmount; // Brak rabatu
    }
}
