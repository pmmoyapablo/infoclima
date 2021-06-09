using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using System.Collections.Generic;
using WindowsLiderEntrega.Properties;

namespace WindowsLiderEntrega
{
  public class AppConfiguration : IConfiguration
  {
    public string this[string key] { 
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

      switch(key)
      {
        case "urlSOAP":
          value = Settings.Default.urlSOAP;
          break;

        case "usuario":
          value = Settings.Default.usuario;
          break;

        case "password":
          value = Settings.Default.password;
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
        case "urlSOAP":
          Settings.Default.urlSOAP = value;
          break;

        case "usuario":
          Settings.Default.usuario = value;
          break;

        case "password":
          Settings.Default.password = value;
          break;

        default:
          break;
      }

      Settings.Default.Save();
      Settings.Default.Reload();
    }
  }
}
