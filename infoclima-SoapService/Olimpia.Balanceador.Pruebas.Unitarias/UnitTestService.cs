using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Olimpia.Balanceador.Pruebas.Unitarias.ServiceReference1;
using System.ServiceModel;
using System.Net;

namespace Olimpia.Balanceador.Pruebas.Unitarias
{
  [TestClass]
  public class UnitTestService
  {
    private readonly string URL_SOAP = "http://localhost:58590/ServiceClimate.svc?wsdl";
    private ServiceClimateClient _client;

    [TestMethod]
    public void TestMethodLoginOk()
    {
      //Arrange
      Initialize();

      //Act
      var user = _client.Login("pmoya", "Moneda32");

      //Assert
      Assert.IsTrue(user != null);

      Closed();
    }

    [TestMethod]
    public void TestMethodLoginError()
    {
      //Arrange
      Initialize();

      //Act
      var user = _client.Login("carlo45", "24279rwhfeh");

      //Assert
      Assert.IsTrue(user == null);

      Closed();
    }

    [TestMethod]
    public void TestMethodRegistrarClimaOk()
    {
      //Arrange
      Initialize();
      var clima = new Clima() { 
        ClimaID = 0,
        Description = "Claro como el agua",
        City = "Cartagena",
        Date = DateTime.Now,
        Humidity = 15,
        Temperature = 30,
        Wind = 3
      };

      //Act
      var repuesta = _client.Registar(clima);

      //Assert
      Assert.IsTrue(repuesta.IsSuccess);

      Closed();
    }

    [TestMethod]
    public void TestMethodActualizarClimaOk()
    {
      //Arrange
      Initialize();
      var clima = new Clima()
      {
        ClimaID = 5,
        Description = "Solazo parejo",
        City = "Barranquilla",
        Date = DateTime.Now,
        Humidity = 13,
        Temperature = 32,
        Wind = 4
      };

      //Act
      var repuesta = _client.Actualizar(clima);

      //Assert
      Assert.IsTrue(repuesta.IsSuccess);

      Closed();
    }

    [TestMethod]
    public void TestMethodConsultarClimaOk()
    {
      //Arrange
      Initialize();

      //Act
      var clima = _client.Consultar("2");

      //Assert
      Assert.IsTrue(clima != null);

      Closed();
    }

    [TestMethod]
    public void TestMethodEliminarClimaOk()
    {
      //Arrange
      Initialize();

      //Act
      var result = _client.Eliminar("7");

      //Assert
      Assert.IsTrue(result.IsSuccess);

      Closed();
    }

    [TestMethod]
    public void TestMethodConsultarTodosClimasAsynOk()
    {
      //Arrange
      Initialize();

      //Act
      var climas = _client.ConsultarTodosAsync();

      //Assert
      Assert.IsTrue(climas != null);

      Closed();
    }
    private ServiceClimateClient Initialize()
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

    private void Closed()
    {
      _client.Close();
      _client = null;
    }
  }
}
