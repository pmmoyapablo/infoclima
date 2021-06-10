using Olimpia.Balanceador.Transversal.Common;
using Olimpia.Balanceador.Transversal.Inyeccion;
using Olimpia.Balanceador.Infraestructura.Interface;
using Olimpia.Balanceador.Infraestructura.Repository;
using Olimpia.Balanceador.Infraestructura.Data;
using Olimpia.Balanceador.Dominio.Interface;
using Olimpia.Balanceador.Dominio.Core;
using Olimpia.Balanceador.Aplicacion.Interface;
using Microsoft.Extensions.Configuration;
using Olimpia.Balanceador.Aplicacion.Main;
using Olimpia.Balanceador.Transversal.Logging;

namespace Olimpia.Balanceador.Servicio.InterRoot
{
  public class Mireware : IMireware
  {
    public Mireware()
    {
      this.ConfigureDependencies();
    }

    public IBalanceAplicacion BalanceAplicacion { 
      get {
        return Injector.Get<IBalanceAplicacion>();
      } 
    }

    public IUsersApplication UsersApplication
    {
      get { 
        return Injector.Get<IUsersApplication>(); 
      }
    }
    private void ConfigureDependencies()
    {
      Injector.Clear();
      Injector.Map<IConfiguration, AppConfiguration>();
      Injector.Map<IConetionFactory, ConectionFactory>();
      Injector.Map<IUsersReposiry, UsersRepository>();
      Injector.Map<IClimateRepository, ClimateRepository>();
      Injector.Map<IUsersDomain, UsersDomain>();
      Injector.Map<IBalanceDomain, BalanceDomain>();
      Injector.Map<IUsersApplication, UsersApplication>();
      Injector.Map<IBalanceAplicacion, BalanceAplicacion>();
      //Injector.Map<IAppLogger<BalanceAplicacion>, LoggerAdapter<BalanceAplicacion>>();
    }
  }
}
