using System;

namespace WzorceProjektowe.Strukturalne.Proxy
{
    public class Client
    {
        public static void Execute()
        {
            IDatabase database = new Database();
            database = new DatabaseProxy(database);

            for (var i = 1; i < 11; i++)
            {
                _ = database.RequestAsync(i);
            }

            Console.ReadKey();

            for (var i = 1; i < 11; i++)
            {
                _ = database.RequestAsync(i);
            }
        }
    }
}