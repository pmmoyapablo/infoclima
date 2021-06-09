using Olimpia.Balanceador.Dominio.Entity;

namespace Olimpia.Balanceador.Infraestructura.Interface
{
  public interface IUsersReposiry
  {
    Users Authenticate(string username, string password);
  }
}
