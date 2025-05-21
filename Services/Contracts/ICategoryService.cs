using SmartServices.Dtos;
using SmartServices.Models;

namespace SmartServices.Services.Contracts
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories(bool trackChanges);
        Category? GetOneCategory(int categoryId, bool trackChanges);
        void CreateCategory(CategoryDtoForInsertion categoryDto);
        void UpdateOneCategory(CategoryDtoForUpdate categoryDto);
        void DeleteOneCategory(int categoryId);
        CategoryDtoForUpdate GetCategoryForUpdate(int categoryId, bool trackChanges);
    }
}
