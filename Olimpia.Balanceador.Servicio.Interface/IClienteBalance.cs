using Olimpia.Balanceador.Dominio.Entity;
using System.Threading.Tasks;

namespace Olimpia.Balanceador.Servicio.Interface
{
  public interface IClienteBalance
  {
    Task<TransaccionDTO[]> GetTransactions();
    Task<string> GetClaveCifradoCuenta(long ctaOrigin);
    void SaveData(SaldoDTO[] saldosDTOs);
  }
}
