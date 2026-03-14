using Subscription.Domain.Entities;
using Subscription.Domain.Interfaces.Repositories;
using Subscription.Infra.Data.Contexts;

namespace Subscription.Infra.Data.Repositories;

public class ClienteRepository(AppDbContext context)
    : BaseRepository<Cliente, Guid>(context), IClienteRepository
{

}