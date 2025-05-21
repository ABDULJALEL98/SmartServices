using SmartServices.Data;
using SmartServices.Models;
using SmartServices.Repositories.Contracts;

namespace SmartServices.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {

        }

        public void CreateOneCategory(Category category) => Create(category);


        public void DeleteOneCategory(Category category) => Remove(category);


        public IQueryable<Category> GetAllCategories(bool trackChanges) => FindAll(trackChanges);
            


        public Category? GetOneCategory(int id, bool trackChanges)
        {
            return FindByCondition(c => c.CategoryId.Equals(id), trackChanges);
                
        }

        public void UpdateOneCategory(Category entity) => Update(entity);

    }
    
}
