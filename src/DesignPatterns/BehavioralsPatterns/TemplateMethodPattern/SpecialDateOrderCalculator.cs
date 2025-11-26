namespace TemplateMethodPattern;

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
