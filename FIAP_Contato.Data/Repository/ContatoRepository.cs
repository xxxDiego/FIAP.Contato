using FIAP_Contato.Data.Context;
using FIAP_Contato.Domain.Entity;
using FIAP_Contato.Domain.Interface.Repository;
using System.Data;

namespace FIAP_Contato.Data.Repository;

public class ContatoRepository(IDbConnection context) : Context<Contato>(context), IContatoRepository
{
}