using SmartServices.Data;
using SmartServices.Repositories.Contracts;

namespace SmartServices.Repositories
{
    public class RepositoryManager : IRepositoryManager

    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly AppDbContext _context;
        public RepositoryManager(ICategoryRepository categoryRepository, AppDbContext context)
        {
            _context = context;
            _categoryRepository = categoryRepository;
            
        }

        public ICategoryRepository Category => _categoryRepository;
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
