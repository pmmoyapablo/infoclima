using Olimpia.Balanceador.Dominio.Entity;

namespace Olimpia.Balanceador.Dominio.Interface
{
  public interface IUsersDomain
  {
    Users Authenticate(string username, string password);
  }
}
