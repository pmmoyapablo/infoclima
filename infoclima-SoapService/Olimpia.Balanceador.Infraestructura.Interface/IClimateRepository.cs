using Olimpia.Balanceador.Dominio.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Olimpia.Balanceador.Infraestructura.Interface
{
  public interface IClimateRepository
  {
    #region Metodos Sincronos

    bool Insertar(Climates climate);
    bool Update(Climates climate);
    bool Delete(string climateId);
    Climates Get(string climateId);
    IEnumerable<Climates> GetAll();

    #endregion 

    #region Metodos Asincronos

    Task<bool> InsertarAsync(Climates climate);
    Task<bool> UpdateAsync(Climates climate);
    Task<bool> DeleteAsync(string climateId);
    Task<Climates> GetAsync(string climateId);
    Task<IEnumerable<Climates>> GetAllAsync();

    #endregion 
  }
}
