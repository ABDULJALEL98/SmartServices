using SmartServices.Models;

namespace SmartServices.Repositories.Contracts
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
        IQueryable<Category> GetAllCategories(bool trackChanges);
        Category? GetOneCategory(int categoryId, bool trackChanges);
        void CreateOneCategory(Category category);
        void UpdateOneCategory(Category entity);
        void DeleteOneCategory(Category category);
    }
}
