using Exemplo1.Entities;

namespace Exemplo1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010,"Bob Brown",100.0,500.0);
            Console.WriteLine(account.Balace);
            //account.Balace = 200.0;
        }
    }
}