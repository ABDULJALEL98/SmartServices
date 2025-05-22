using SmartServices.Models;

namespace SmartServices.Repositories.Contracts
{
    public interface IServiceRepository : IRepositoryBase<Service>
    {
        IQueryable<Service> GetAllServices(bool trackChanges);
        Service? GetOneService(int serviceId, bool trackChanges);
        void CreateOneService(Service service);
        void UpdateOneService(Service entity);
        void DeleteOneService(Service service);
        void CreateService(Service service);
    }
    
}
