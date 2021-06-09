using Olimpia.Balanceador.Dominio.Entity;
using Olimpia.Balanceador.Infraestructura.Interface;
using Olimpia.Balanceador.Dominio.Interface;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Olimpia.Balanceador.Dominio.Core
{
  public class BalanceDomain : IBalanceDomain
  {
    private readonly IClimateRepository _climateRepository;
    public BalanceDomain(IClimateRepository climateRepository)
    {
      _climateRepository = climateRepository;
    }

    public bool Delete(string climateId)
    {
      return _climateRepository.Delete(climateId);
    }

    public async Task<bool> DeleteAsync(string climateId)
    {
      return await _climateRepository.DeleteAsync(climateId);
    }

    public Climates Get(string climateId)
    {
      return _climateRepository.Get(climateId);
    }

    public IEnumerable<Climates> GetAll()
    {
      return _climateRepository.GetAll();
    }

    public async Task<IEnumerable<Climates>> GetAllAsync()
    {
      return await _climateRepository.GetAllAsync();
    }

    public async Task<Climates> GetAsync(string climateId)
    {
      return await _climateRepository.Get(climateId);
    }

    public bool Insertar(Climates climate)
    {
      return _climateRepository.Insertar(climate);
    }

    public async Task<bool> InsertarAsync(Climates climate)
    {
      return await _climateRepository.InsertarAsync(climate);
    }

    public bool Update(Climates climate)
    {
      return _climateRepository.Update(climate);
    }

    public async Task<bool> UpdateAsync(Climates climate)
    {
      return await _climateRepository.UpdateAsync(climate);
    }
  }
}