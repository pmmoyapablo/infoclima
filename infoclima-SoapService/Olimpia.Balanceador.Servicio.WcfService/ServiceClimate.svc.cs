using System;
using System.Collections.Generic;
using Olimpia.Balanceador.Servicio.InterRoot;
using Olimpia.Balanceador.Aplicacion.Interface;
using Olimpia.Balanceador.Dominio.Entity;
using Olimpia.Balanceador.Transversal.Common;
using System.Threading.Tasks;

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
public class ServiceClimate : IServiceClimate
 {
    private IMireware _mireware;
    public ServiceClimate()
    {
        _mireware = new Mireware();
    }

    #region Metodos Sincronos
    public Usuario Login(string username, string password)
    {
      var application = _mireware.UsersApplication;

      var response = application.Authenticate(username, password);

      var user = response.Data;

      Usuario usuario = null;

      if (user != null)
      {
        usuario = new Usuario()
        {
          FirstName = user.FirstName,
          LastName = user.LastName,
          UserName = user.UserName,
          UserID = user.UserID,
          Token = user.Token
        };
      }

      return usuario;
    }

    public Repuesta Registar(Clima clima)
    {
      var application = _mireware.BalanceAplicacion;

      Climates climate = new Climates();
      climate.ClimaID = clima.ClimaID;
      climate.Description = clima.Description;
      climate.City = clima.City;
      climate.Date = clima.Date;
      climate.Humidity = clima.Humidity;
      climate.Temperature = clima.Temperature;
      climate.Wind = clima.Wind;

      var response = application.Insertar(climate);

      var result = new Repuesta() { IsSuccess = response.IsSuccess, Messange = response.Messange };

      return result;
    }
    public Repuesta Actualizar(Clima clima)
    {
      var application = _mireware.BalanceAplicacion;

      Climates climate = new Climates();
      climate.ClimaID = clima.ClimaID;
      climate.Description = clima.Description;
      climate.City = clima.City;
      climate.Date = clima.Date;
      climate.Humidity = clima.Humidity;
      climate.Temperature = clima.Temperature;
      climate.Wind = clima.Wind;

      var response = application.Update(climate);

      var result = new Repuesta(){ IsSuccess = response.IsSuccess, Messange = response.Messange };

      return result;
    }

    public Clima Consultar(string climaId)
    {
      var application = _mireware.BalanceAplicacion;

      var response = application.Get(climaId);

      Climates climate = response.Data;
      Clima clima = null;

      if (climate != null)
      {
        clima = new Clima();
        clima.ClimaID = climate.ClimaID;
        clima.Description = climate.Description;
        clima.City = climate.City;
        clima.Date = climate.Date;
        clima.Humidity = climate.Humidity;
        clima.Temperature = climate.Temperature;
        clima.Wind = climate.Wind;
      }

      return clima;
    }

    public List<Clima> ConsultarTodos()
    {
      var application = _mireware.BalanceAplicacion;

      var response = application.GetAll();

      var climates = response.Data;
      List<Clima> climas = new List<Clima>();

      foreach (Climates climate in climates)
      {
        Clima clima = new Clima();
        clima.ClimaID = climate.ClimaID;
        clima.Description = climate.Description;
        clima.City = climate.City;
        clima.Date = climate.Date;
        clima.Humidity = climate.Humidity;
        clima.Temperature = climate.Temperature;
        clima.Wind = climate.Wind;

        climas.Add(clima);
      }

      return climas;
    }

    public Repuesta Eliminar(string climaId)
    {
      var application = _mireware.BalanceAplicacion;

      var response = application.Delete(climaId);

      var result = new Repuesta() { IsSuccess = response.IsSuccess, Messange = response.Messange };

      return result;
    }

    #endregion

    #region Metodos Asincronos
    /*
    public async Task<Repuesta> ActualizarAsync(Clima clima)
    {
      var application = _mireware.BalanceAplicacion;

      Climates climate = new Climates();
      climate.ClimaID = clima.ClimaID;
      climate.Description = clima.Description;
      climate.City = clima.City;
      climate.Date = clima.Date;
      climate.Humidity = clima.Humidity;
      climate.Temperature = clima.Temperature;
      climate.Wind = clima.Wind;

      var response = await application.UpdateAsync(climate);

      var result = new Repuesta() { IsSuccess = response.IsSuccess, Messange = response.Messange };

      return result;
    }

    public async Task<Clima> ConsultarAsync(string climaId)
    {
      var application = _mireware.BalanceAplicacion;

      var response = await application.GetAsync(climaId);

      Climates climate = response.Data;
      Clima clima = null;

      if (climate != null)
      {
        clima = new Clima();
        clima.ClimaID = climate.ClimaID;
        clima.Description = climate.Description;
        clima.City = climate.City;
        clima.Date = climate.Date;
        clima.Humidity = climate.Humidity;
        clima.Temperature = climate.Temperature;
        clima.Wind = climate.Wind;
      }

      return clima;
    }

    public async Task<List<Clima>> ConsultarTodosAsync()
    {
      var application = _mireware.BalanceAplicacion;

      var response = await application.GetAllAsync();

      var climates = response.Data;
      List<Clima> climas = new List<Clima>();

      foreach (Climates climate in climates)
      {
        Clima clima = new Clima();
        clima.ClimaID = climate.ClimaID;
        clima.Description = climate.Description;
        clima.City = climate.City;
        clima.Date = climate.Date;
        clima.Humidity = climate.Humidity;
        clima.Temperature = climate.Temperature;
        clima.Wind = climate.Wind;

        climas.Add(clima);
      }

      return climas;
    }

    public async Task<Repuesta> EliminarAsync(string climaId)
    {
      var application = _mireware.BalanceAplicacion;

      var response = await application.DeleteAsync(climaId);

      var result = new Repuesta() { IsSuccess = response.IsSuccess, Messange = response.Messange };

      return result;
    }

    public async Task<Repuesta> RegistarAsync(Clima clima)
    {
      var application = _mireware.BalanceAplicacion;

      Climates climate = new Climates();
      climate.ClimaID = clima.ClimaID;
      climate.Description = clima.Description;
      climate.City = clima.City;
      climate.Date = clima.Date;
      climate.Humidity = clima.Humidity;
      climate.Temperature = clima.Temperature;
      climate.Wind = clima.Wind;

      var response = await application.InsertarAsync(climate);

      var result = new Repuesta() { IsSuccess = response.IsSuccess, Messange = response.Messange };

      return result;
    }
    */
    #endregion
  }
}