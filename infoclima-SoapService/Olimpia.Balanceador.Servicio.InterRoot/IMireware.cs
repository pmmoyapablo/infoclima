using Olimpia.Balanceador.Aplicacion.Interface;

namespace Olimpia.Balanceador.Servicio.InterRoot
{
  public interface IMireware
  {
    IBalanceAplicacion BalanceAplicacion { get; }
    IUsersApplication UsersApplication { get;  }
  }
}