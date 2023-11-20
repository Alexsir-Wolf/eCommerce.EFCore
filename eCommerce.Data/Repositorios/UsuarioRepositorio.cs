using eCommerce.Data.Repositorios.Base;
using eCommerce.Models;
using eCommerce.Models.Contratos.Repositorios;
using eCommerce.Models.Models;

namespace eCommerce.Data.Repositorios;

public class UsuarioRepositorio : BaseRepositorio<Usuario, int>, IUsuarioRepositorio
{
	public UsuarioRepositorio(eCommerceDbContext dbContext) : base(dbContext)
	{
	}
}
