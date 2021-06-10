using Olimpia.Balanceador.Aplicacion.Interface;
using Olimpia.Balanceador.Dominio.Entity;
using Olimpia.Balanceador.Dominio.Interface;
using Olimpia.Balanceador.Transversal.Common;
using System;

namespace Olimpia.Balanceador.Aplicacion.Main
{
  public class UsersApplication : IUsersApplication
  {
    private readonly IUsersDomain _userDomain;
   // private readonly IAppLogger<UsersApplication> _logger;

    public UsersApplication(IUsersDomain userDomain) // IAppLogger<UsersApplication> logger
    {
      _userDomain = userDomain;
     // _logger = logger;
    }

    public Response<Users> Authenticate(string username, string password)
    {
      var response = new Response<Users>();
      var validation = !String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(password);
      try
      {
        if (!validation)
        {
          response.Messange = "Errores de validacion";
          response.IsSuccess = false;
          return response;
        }

        var user = _userDomain.Authenticate(username, password);
        response.Data = user;
        if (response.Data != null)
        {
          response.IsSuccess = true;
          response.Messange = "Autenticacion Exitosa OK";
         // _logger.LogInformation(response.Messange);
        }

      }
      catch (InvalidOperationException ex)
      {
        response.IsSuccess = true;
        response.Messange = "Usuario no existe";
       // _logger.LogWarning(response.Messange);
      }
      catch (Exception ex)
      {
        response.IsSuccess = false;
        response.Messange = ex.Message;
       // _logger.LogError(response.Messange);
      }

      return response;
    }
  }
}
