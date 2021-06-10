using System.Data;
using Olimpia.Balanceador.Infraestructura.Interface;
using Olimpia.Balanceador.Dominio.Entity;
using Olimpia.Balanceador.Transversal.Common;
using System.Linq;

namespace Olimpia.Balanceador.Infraestructura.Repository
{
  public class UsersRepository : IUsersReposiry
  {
    private readonly IConetionFactory _conectionFactory;
    private InfoClimaEntities _context;

    public UsersRepository(IConetionFactory conectionFactory)
    {
      _conectionFactory = conectionFactory;
      //_context = new RepositoryContext(_conectionFactory.GetStringConnection);
      _context = new InfoClimaEntities();
    }
    public Users Authenticate(string username, string password)
    {
     
        var user = _context.Users.Where(u => u.UserName == username && u.Password == password).FirstOrDefault();

        return user;
      
    }
  }
}