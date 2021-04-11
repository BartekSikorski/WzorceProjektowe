namespace WzorceProjektowe.Strukturalne.Facade.II
{
    public interface ICartService
    {
        void AddProduct(int cartId, int item, decimal price);
        decimal GetPrice(int cartId);
    }
}