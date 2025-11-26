using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern;

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
