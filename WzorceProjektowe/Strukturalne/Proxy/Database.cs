using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjektowe.Strukturalne.Proxy
{
    public class Database : IDatabase
    {
        private int _connectionCounter = 0;
        public async Task<int?> RequestAsync(int parameter)
        {
            if (_connectionCounter >= 5)
            {
                Console.WriteLine($"Request {parameter} dropped!");
                return null;
            }

            _connectionCounter++;
            Console.WriteLine($"Opening connection {_connectionCounter}");
            await Task.Delay(3000);

            Console.WriteLine($"Request {parameter} completed ({_connectionCounter})");
            _connectionCounter--;
            return parameter;
        }
    }
}
