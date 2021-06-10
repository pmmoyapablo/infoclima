using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using System.Collections.Generic;

namespace Olimpia.Balanceador.Servicio.InterRoot
{
  public class AppConfiguration : IConfiguration
  {
    public string this[string key]
    {
      get => GetPropertie(key);
      set => SetPropertie(key, value);
    }

    public IEnumerable<IConfigurationSection> GetChildren()
    {
      throw new System.NotImplementedException();
    }

    public IChangeToken GetReloadToken()
    {
      throw new System.NotImplementedException();
    }

    public IConfigurationSection GetSection(string key)
    {
      throw new System.NotImplementedException();
    }

    private string GetPropertie(string key)
    {
      string value = string.Empty;

      switch (key)
      {
        case "StringConection":          
          value = Settings1.Default.StringConection;
          break;

        default:
          break;
      }
      return value;
    }

    private void SetPropertie(string key, string value)
    {

      switch (key)
      {
        case "StringConection":
          Settings1.Default.StringConection = value;
          break;      

        default:
          break;
      }

      Settings1.Default.Save();
      Settings1.Default.Reload();
    }
  }
}
