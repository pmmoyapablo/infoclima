using Olimpia.Balanceador.Infraestructura.Interface;
using Olimpia.Balanceador.Dominio.Entity;
using Olimpia.Balanceador.Transversal.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.Entity;

namespace Olimpia.Balanceador.Infraestructura.Repository
{
  public class ClimateRepository : IClimateRepository
  {
    private readonly IConetionFactory _conectionFactory;
    private InfoClimaEntities _context;
    public ClimateRepository(IConetionFactory conetionFactory)
    {
      _conectionFactory = conetionFactory;
      //_context = new RepositoryContext(_conectionFactory.GetStringConnection);
      _context = new InfoClimaEntities();
    }

    #region Metodos Sincronos
    public bool Delete(string climateId)
    {
      var climate = _context.Climates.Find(int.Parse(climateId));

      if (climate == null)
      {
        return false;
      }

      _context.Climates.Remove(climate);
      _context.SaveChanges();

      return true;
    }

    public Climates Get(string climateId)
    {
      var climate = _context.Climates.Find(int.Parse(climateId));

      return climate;   
    }

    public IEnumerable<Climates> GetAll()
    {
        var climates = _context.Climates.ToList();

        return climates;  
    }

    public bool Insertar(Climates climate)
    {
      if (climate == null)
      {
        return false;
      }

      _context.Climates.Add(climate);
      _context.SaveChanges();

      return true;
    }

    public bool Update(Climates climate)
    {
      if (climate == null)
      {
        return false;
      }

      _context.Entry(climate).State = EntityState.Modified;
      _context.SaveChanges();

      return true;
    }

    #endregion

    #region Metodos Asincronos
    public async Task<bool> InsertarAsync(Climates climate)
    {
      if (climate == null)
      {
        return false;
      }

      _context.Climates.Add(climate);
      await _context.SaveChangesAsync();

      return true;
    }

    public async Task<IEnumerable<Climates>> GetAllAsync()
    {
      var climates = await _context.Climates.ToListAsync();

      return climates;
    }

    public async Task<bool> DeleteAsync(string climateId)
    {
      var climate = _context.Climates.Find(int.Parse(climateId));

      if (climate == null)
      {
        return false;
      }

      _context.Climates.Remove(climate);
      await _context.SaveChangesAsync();

      return true;
    }

    public async Task<Climates> GetAsync(string climateId)
    {
      var climate = await _context.Climates.FindAsync(int.Parse(climateId));

      return climate;
    }
    public async Task<bool> UpdateAsync(Climates climate)
    {
      if (climate == null)
      {
        return false;
      }

      _context.Entry(climate).State = EntityState.Modified;
      await _context.SaveChangesAsync();

      return true;
    }
    #endregion
  }
}