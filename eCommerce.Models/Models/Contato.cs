using eCommerce.Models.Contratos.Repositorios;
using eCommerce.Models.Models.Base;

namespace eCommerce.Models.Models;

public class Contato : EntidadeBase<int>, IEntidade<int>
{
	public override int Id { get; set; }
	public int UsuarioId { get; set; }
	public string? Telefone { get; set; }
	public string? Celular { get; set; }

	public Usuario? Usuario { get; set; }

}
