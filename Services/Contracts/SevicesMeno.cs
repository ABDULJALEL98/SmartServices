using AutoMapper;
using SmartServices.Dtos;
using SmartServices.Models;
using SmartServices.Repositories.Contracts;

namespace SmartServices.Services.Contracts
{
    public class SevicesMeno : IServiceService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        public SevicesMeno(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public void CreateService(ServiceDtoForInsertion serviceDto)
        {
            Service service = _mapper.Map<Service>(serviceDto);
            _manager.Service.CreateService(service);
            _manager.Save();
        }

        public void DeleteOneService(int serviceId)
        {
            Service service = GetOneService(serviceId, false);
            if (service is not null)
            {
                _manager.Service.DeleteOneService(service);
                _manager.Save();
            }
          
        }

        public IEnumerable<Service> GetAllServices(bool trackChanges)
        {
          return  _manager.Service.GetAllServices(trackChanges);
        }

        public Service? GetOneService(int serviceId, bool trackChanges)
        {
            var service = _manager.Service.GetOneService(serviceId, trackChanges);
            if (service is null)
                throw new Exception("Service not found!");
            return service;
        }

        public ServiceDtoForUpdate GetServiceForUpdate(int serviceId, bool trackChanges)
        {
            var service = GetOneService(serviceId, trackChanges);
            var serviceDto = _mapper.Map<ServiceDtoForUpdate>(service);
            return serviceDto;
        }

        public void UpdateOneService(ServiceDtoForUpdate serviceDto)
        {
            var entity = _mapper.Map<Service>(serviceDto);
            _manager.Service.UpdateOneService(entity);
            _manager.Save();
        }
    }
}
