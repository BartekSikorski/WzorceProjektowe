using System.Threading.Tasks;

namespace WzorceProjektowe.Strukturalne.Proxy
{
    public interface IDatabase
    {
        Task<int?> RequestAsync(int parameter);
    }
}