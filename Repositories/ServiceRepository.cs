using SmartServices.Data;
using SmartServices.Models;
using SmartServices.Repositories.Contracts;

namespace SmartServices.Repositories
{
    public class ServiceRepository : RepositoryBase<Service>, IServiceRepository
    {
        public ServiceRepository(AppDbContext context) : base(context)
        {

        }

        public void CreateOneService(Service service) => Create(service);


        public void DeleteOneService(Service service) => Remove(service);


        public IQueryable<Service> GetAllServices(bool trackChanges) => FindAll(trackChanges);
        
        public Service? GetOneService(int serviceId, bool trackChanges)
        {
            return FindByCondition(x => x.ServiceId.Equals(serviceId), trackChanges);
        }

        public void UpdateOneService(Service entity) => Update(entity);

    }
}
