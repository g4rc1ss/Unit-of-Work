namespace Garciss.Core.Data.Databases.UnitOfWork.Repository.Interfaces;

public interface IRepositoryReadOnly<T> : IReadRepository<T> where T : class
{

}
