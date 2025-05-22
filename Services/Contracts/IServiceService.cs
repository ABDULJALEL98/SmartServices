using SmartServices.Dtos;
using SmartServices.Models;

namespace SmartServices.Services.Contracts
{
    public interface IServiceService
    {
        IEnumerable<Service> GetAllServices(bool trackChanges);
        Service? GetOneService(int serviceId, bool trackChanges);
        void CreateService(ServiceDtoForInsertion serviceDto);
        void UpdateOneService(ServiceDtoForUpdate serviceDto);
        void DeleteOneService(int serviceId);
        ServiceDtoForUpdate GetServiceForUpdate(int serviceId, bool trackChanges);

    }
}
