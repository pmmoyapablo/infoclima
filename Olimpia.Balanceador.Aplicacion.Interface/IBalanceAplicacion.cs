using Olimpia.Balanceador.Transversal.Common;
using Olimpia.Balanceador.Dominio.Entity;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Olimpia.Balanceador.Aplicacion.Interface
{
  public interface IBalanceAplicacion
  {
    #region Metodos Sincronos

    Response<bool> Insertar(Climates climate);
    Response<bool> Update(Climates climate);
    Response<bool> Delete(string climateId);
    Response<Climates> Get(string climateId);
    Response<IEnumerable<Climates>> GetAll();

    #endregion 

    #region Metodos Asincronos

    Task<Response<bool>> InsertarAsync(Climates climate);
    Task<Response<bool>> UpdateAsync(Climates climate);
    Task<Response<bool>> DeleteAsync(string climateId);
    Task<Response<Climates>> GetAsync(string climateId);
    Task<Response<IEnumerable<Climates>>> GetAllAsync();

    #endregion 
  }
}