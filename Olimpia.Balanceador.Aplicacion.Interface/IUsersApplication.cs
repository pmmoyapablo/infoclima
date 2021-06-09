using Olimpia.Balanceador.Transversal.Common;
using Olimpia.Balanceador.Dominio.Entity;

namespace Olimpia.Balanceador.Aplicacion.Interface
{
  public interface IUsersApplication
  {
    Response<Users> Authenticate(string username, string password);
  }
}
