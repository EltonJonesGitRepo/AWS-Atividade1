using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            AcessoWsSoap acessoWsSoap = new AcessoWsSoap();
          
            Console.WriteLine("\nConsumindo a SoapAction QueryByName.\n Resultado obtido:");            
            Console.WriteLine(await acessoWsSoap.ConsumoWsGenerico("QueryByName"));


            Console.WriteLine("\n\n\nConsumindo a SoapAction GetListByName.\n Resultado obtido:");
            Console.WriteLine(await acessoWsSoap.ConsumoWsGenerico("GetListByName"));


            Console.WriteLine("\n\n\nConsumindo a SoapAction GetDataSetByName.\n Resultado obtido:");
            Console.WriteLine(await acessoWsSoap.ConsumoWsGenerico("GetDataSetByName"));

            Console.ReadKey();
        }
    }
}
