namespace TemplateMethodPattern;

abstract class PercentageOrderCalculatorTemplate : OrderCalculatorTemplate
{
    private decimal percentage;

    protected PercentageOrderCalculatorTemplate(decimal percentage)
    {
        this.percentage = percentage;
    }

    public override decimal GetDiscount(Order order) => order.TotalAmount - order.TotalAmount * percentage;
}
