using Olimpia.Balanceador.Transversal.Common;
using Olimpia.Balanceador.Dominio.Entity;
using Olimpia.Balanceador.Dominio.Interface;
using Olimpia.Balanceador.Aplicacion.Interface;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace Olimpia.Balanceador.Aplicacion.Main
{
  public class BalanceAplicacion : IBalanceAplicacion
  {
    private readonly IBalanceDomain _balanceDomain;
   // private readonly IAppLogger<BalanceAplicacion> _logger;
    public BalanceAplicacion(IBalanceDomain balanceDomain)  //, IAppLogger<BalanceAplicacion> logger
    {
      _balanceDomain = balanceDomain;
     // _logger = logger;
    }
    public Response<bool> Delete(string climateId)
    {
      var response = new Response<bool>();
      try
      {
        response.Data = _balanceDomain.Delete(climateId);
        if (response.Data)
        {
          response.IsSuccess = true;
          response.Messange = "Borrado Exitoso OK";
        }

      }
      catch (Exception ex)
      {
        response.IsSuccess = false;
        response.Messange = ex.Message;
      }

      return response;
    }

    public async Task<Response<bool>> DeleteAsync(string climateId)
    {
      var response = new Response<bool>();
      try
      {
        response.Data = await _balanceDomain.DeleteAsync(climateId);
        if (response.Data)
        {
          response.IsSuccess = true;
          response.Messange = "Borrado Exitoso OK";
        }

      }
      catch (Exception ex)
      {
        response.IsSuccess = false;
        response.Messange = ex.Message;
      }

      return response;
    }

    public Response<Climates> Get(string climateId)
    {
      var response = new Response<Climates>();
      try
      {
        var climate = _balanceDomain.Get(climateId);
        response.Data = climate;
        if (response.Data != null)
        {
          response.IsSuccess = true;
          response.Messange = "Consulta Exitosa OK";
         // _logger.LogInformation(response.Messange);
        }

      }
      catch (Exception ex)
      {
        response.IsSuccess = false;
        response.Messange = ex.Message;
       // _logger.LogError(ex.Message);
      }

      return response;
    }

    public Response<IEnumerable<Climates>> GetAll()
    {
      var response = new Response<IEnumerable<Climates>>();
      try
      {
        var climates = _balanceDomain.GetAll();
        response.Data = climates;
        if (response.Data != null)
        {
          response.IsSuccess = true;
          response.Messange = "Consulta Exitosa OK";
        }

      }
      catch (Exception ex)
      {
        response.IsSuccess = false;
        response.Messange = ex.Message;
      }

      return response;
    }

    public async Task<Response<IEnumerable<Climates>>> GetAllAsync()
    {
      var response = new Response<IEnumerable<Climates>>();
      try
      {
        var climates = await _balanceDomain.GetAllAsync();
        response.Data = climates;
        if (response.Data != null)
        {
          response.IsSuccess = true;
          response.Messange = "Consulta Exitosa OK";
        }

      }
      catch (Exception ex)
      {
        response.IsSuccess = false;
        response.Messange = ex.Message;
      }

      return response;
    }

    public async Task<Response<Climates>> GetAsync(string climateId)
    {
      var response = new Response<Climates>();
      try
      {
        var climate = await _balanceDomain.GetAsync(climateId);
        response.Data = climate;
        if (response.Data != null)
        {
          response.IsSuccess = true;
          response.Messange = "Consulta Exitosa OK";
        }

      }
      catch (Exception ex)
      {
        response.IsSuccess = false;
        response.Messange = ex.Message;
      }

      return response;
    }

    public Response<bool> Insertar(Climates climate)
    {
      var response = new Response<bool>();
      try
      {
        response.Data = _balanceDomain.Insertar(climate);
        if (response.Data)
        {
          response.IsSuccess = true;
          response.Messange = "Registro Exitoso OK";
        }

      }
      catch (Exception ex)
      {
        response.IsSuccess = false;
        response.Messange = ex.Message;
      }

      return response;
    }

    public async Task<Response<bool>> InsertarAsync(Climates climate)
    {
      var response = new Response<bool>();
      try
      {
        response.Data = await _balanceDomain.InsertarAsync(climate);
        if (response.Data)
        {
          response.IsSuccess = true;
          response.Messange = "Registro Exitoso OK";
        }

      }
      catch (Exception ex)
      {
        response.IsSuccess = false;
        response.Messange = ex.Message;
      }

      return response;
    }

    public Response<bool> Update(Climates climate)
    {
      var response = new Response<bool>();
      try
      {
        response.Data = _balanceDomain.Update(climate);
        if (response.Data)
        {
          response.IsSuccess = true;
          response.Messange = "Actualizacion Exitosa OK";
        }

      }
      catch (Exception ex)
      {
        response.IsSuccess = false;
        response.Messange = ex.Message;
      }

      return response;
    }

    public async Task<Response<bool>> UpdateAsync(Climates climate)
    {
      var response = new Response<bool>();
      try
      {
        response.Data = await _balanceDomain.UpdateAsync(climate);
        if (response.Data)
        {
          response.IsSuccess = true;
          response.Messange = "Actualizacion Exitosa OK";
        }

      }
      catch (Exception ex)
      {
        response.IsSuccess = false;
        response.Messange = ex.Message;
      }

      return response;
    }
  }
}
