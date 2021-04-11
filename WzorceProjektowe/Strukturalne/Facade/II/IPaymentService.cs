namespace WzorceProjektowe.Strukturalne.Facade.II
{
    public interface IPaymentService
    {
        void Pay(int cartId, decimal totalPrice);
    }
}