using Olimpia.Balanceador.Infraestructura.Interface;
using Olimpia.Balanceador.Dominio.Entity;
using Olimpia.Balanceador.Dominio.Interface;

namespace Olimpia.Balanceador.Dominio.Core
{
  public class UsersDomain : IUsersDomain
  {
    private readonly IUsersReposiry _userRepository;

    public UsersDomain(IUsersReposiry userRepository)
    {
      _userRepository = userRepository;
    }

    public Users Authenticate(string username, string password)
    {
      return _userRepository.Authenticate(username, password);
    }
  }
}
