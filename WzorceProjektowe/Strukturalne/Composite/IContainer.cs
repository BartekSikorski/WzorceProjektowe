namespace WzorceProjektowe.Strukturalne.Composite
{
    public interface IContainer
    {
        void Add(ProductBase product);

        void Remove(ProductBase product);
    }
}