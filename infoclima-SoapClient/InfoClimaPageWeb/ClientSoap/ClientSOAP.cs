using InfoClimaPageWeb.ServiceReference1;
using System.ServiceModel;
using System.Net;
using System.Configuration;
using System;

namespace InfoClimaPageWeb.ClientSoap
{
  public class ClientSOAP
  {
    private ServiceClimateClient _client;
    private string URL_SOAP = ConfigurationManager.AppSettings["URL_SOAP"];
    public ServiceClimateClient Initialize()
    {
      string[] arr = URL_SOAP.Split(':');

      var endPoint = new EndpointAddress(URL_SOAP);

      if (arr[0] == "https")
      {
        var binding = new BasicHttpsBinding();

        binding.MaxBufferPoolSize = 2147483647;
        binding.MaxBufferSize = 2147483647;
        binding.MaxReceivedMessageSize = 2147483647;
        binding.ReaderQuotas.MaxStringContentLength = 2147483647;
        binding.ReaderQuotas.MaxArrayLength = 2147483647;
        binding.ReaderQuotas.MaxDepth = 2147483647;
        binding.ReaderQuotas.MaxBytesPerRead = 2147483647;
        binding.SendTimeout = new TimeSpan(0, 0, 10, 0);
        binding.ReceiveTimeout = new TimeSpan(0, 0, 10, 0);

        _client = new ServiceClimateClient(binding, endPoint);
      }
      else
      {
        var binding = new BasicHttpBinding();
        binding.MaxBufferPoolSize = 2147483647;
        binding.MaxBufferSize = 2147483647;
        binding.MaxReceivedMessageSize = 2147483647;
        binding.ReaderQuotas.MaxStringContentLength = 2147483647;
        binding.ReaderQuotas.MaxArrayLength = 2147483647;
        binding.ReaderQuotas.MaxDepth = 2147483647;
        binding.ReaderQuotas.MaxBytesPerRead = 2147483647;
        binding.SendTimeout = new TimeSpan(0, 0, 10, 0);
        binding.ReceiveTimeout = new TimeSpan(0, 0, 10, 0);

        _client = new ServiceClimateClient(binding, endPoint);

      }


      ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => { return true; };
      _client.Open();

      return _client;
    }

    public void Closed()
    {
      _client.Close();
      _client = null;
    }
  }
}