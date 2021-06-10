using System;
using Olimpia.Balanceador.Transversal.Common;
using Microsoft.Extensions.Configuration;

namespace Olimpia.Balanceador.Infraestructura.Data
{
  public class ConectionFactory : IConetionFactory
  {
    private readonly IConfiguration _configuration;
    public ConectionFactory(IConfiguration configuration)
    {
      _configuration = configuration;
    }
    public String GetStringConnection
    {
      get {
      
        var connectionString = _configuration["StringConection"];

        return connectionString;
      }
    }
  }
}