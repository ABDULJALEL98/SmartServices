using SmartServices.Services.Contracts;

namespace SmartServices.Services
{
    public class ServiceManager : IServiceManager

    {
        private readonly ICategoryService _categoryService;

        public ServiceManager(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ICategoryService CategoryService => _categoryService;
    }
}
