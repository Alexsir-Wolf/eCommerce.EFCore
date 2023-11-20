using eCommerce.Models.Contratos.Repositorios;
using eCommerce.Models.Models.Base;

namespace eCommerce.Models.Models;

public class Departamento : EntidadeBase<int>, IEntidade<int>
{
	public override int Id { get; set; }
	public string? Nome { get; set; }

    public ICollection<Usuario>? Usuarios { get; set; }
}
