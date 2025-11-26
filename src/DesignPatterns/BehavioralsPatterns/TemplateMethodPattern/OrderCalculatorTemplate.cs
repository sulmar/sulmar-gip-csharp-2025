namespace TemplateMethodPattern;

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
