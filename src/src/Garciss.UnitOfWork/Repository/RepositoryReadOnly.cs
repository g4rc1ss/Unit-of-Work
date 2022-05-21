using Garciss.Core.Data.Databases.UnitOfWork.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Garciss.Core.Data.Databases.UnitOfWork.Repository;

internal class RepositoryReadOnly<T> : BaseRepository<T>, IRepositoryReadOnly<T> where T : class
{
    public RepositoryReadOnly(DbContext context) : base(context)
    {
    }
}
