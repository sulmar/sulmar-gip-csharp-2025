namespace TemplateMethodPattern;

class CouponOrderCalculatorTemplate : OrderCalculatorTemplate
{
    public override bool CanDiscount(Order order)
    {
        throw new NotImplementedException();
    }

    public override decimal GetDiscount(Order order)
    {
        throw new NotImplementedException();
    }
}