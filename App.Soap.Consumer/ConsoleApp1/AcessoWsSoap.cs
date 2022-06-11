using SoapHttpClient;
using SoapHttpClient.Enums;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class AcessoWsSoap
    {
        private const string EndpointSoap = "https://www.crcind.com:443/csp/samples/SOAP.Demo.cls";

        public async Task<string> ConsumoWsGenerico(string nomeAction)
        {
            var soapClient = new SoapClient();
            var ns = XNamespace.Get("http://tempuri.org");

            var result =
                await soapClient.PostAsync(
                    new Uri(EndpointSoap),
                    SoapVersion.Soap11,
                    body: new XElement(ns.GetName(nomeAction))
                    , action: $"http://tempuri.org/SOAP.Demo.{nomeAction}");

            var content = await result.Content.ReadAsStringAsync();

            return content.ToString();
        }
    }
}
