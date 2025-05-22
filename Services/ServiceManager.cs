using SmartServices.Services.Contracts;

namespace SmartServices.Services
{
    public class ServiceManager : IServiceManager

    {
        private readonly ICategoryService _categoryService;
         private readonly IServiceService _serviceService;

        public ServiceManager(ICategoryService categoryService, IServiceService serviceService)
        {
            _categoryService = categoryService;
            _serviceService = serviceService;
        }

        public ICategoryService CategoryService => _categoryService;
        public IServiceService ServiceService => _serviceService;
    }
}
