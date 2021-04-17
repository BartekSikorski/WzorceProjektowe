namespace WzorceProjektowe.Behavioral.ChainOfResponsibility.I
{
    public interface IDiscountHandler
    {
        bool Discount(float value, float price);
    }
}