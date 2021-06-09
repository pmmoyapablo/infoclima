using System;
using System.Collections.Generic;
using System.Net;
using System.ServiceModel;
using System.Threading.Tasks;
using Olimpia.Balanceador.Servicio.ClienteSoap.ServicioPrueba;
using Olimpia.Balanceador.Servicio.Interface;
using Olimpia.Balanceador.Dominio.Entity;
using Microsoft.Extensions.Configuration;

namespace Olimpia.Balanceador.Servicio.ClienteSoap
{
  public class ClienteBalance : IClienteBalance
  {
    private readonly ServiceClient _client;
    private readonly IConfiguration _configuration;
    public ClienteBalance(IConfiguration configuration)
    {
      _configuration = configuration;
      string urlSOAP = _configuration["urlSOAP"];
      var endPoint = new EndpointAddress(urlSOAP);

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

      _client = new ServiceClient(binding, endPoint);
      ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => { return true; };
      _client.Open();
    }

    public async Task<TransaccionDTO[]> GetTransactions()
    {
      string username = _configuration["usuario"]; 
      string password = _configuration["password"];
      var transaccions = await _client.GetDataAsync(username, password);
      var transactionDTOs = new List<TransaccionDTO>();

      foreach(Transaccion trans in transaccions)
      {
        var transDto = new TransaccionDTO {
            CuentaOrigen = trans.CuentaOrigen,
            TipoTransaccion = trans.TipoTransaccion,
            Titular = trans.Titular,
            ValorTransaccion = trans.ValorTransaccion
        };
        transactionDTOs.Add(transDto);
      }

      return transactionDTOs.ToArray();
    }

    public async Task<string> GetClaveCifradoCuenta(long ctaOrigin)
    {
      string username = _configuration["usuario"];
      string password = _configuration["password"];

      var clave = await _client.GetClaveCifradoCuentaAsync(username, password, ctaOrigin);

      return clave;
    }

    public async void SaveData( SaldoDTO[] saldosDTOs)
    {
      var saldos = new List<Saldo>();
      string username = _configuration["usuario"];
      string password = _configuration["password"];

      foreach (SaldoDTO salDto in saldosDTOs)
      {
         var saldo = new Saldo { 
             CuentaOrigen = salDto.CuentaOrigen,
             Titular = salDto.Titular,
             SaldoCuenta = salDto.SaldoCuenta
         };
         saldos.Add(saldo);
      }

      await _client.SaveDataAsync(username, password, saldos.ToArray());
    }
  }
}