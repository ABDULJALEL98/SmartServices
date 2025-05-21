using AutoMapper;
using SmartServices.Dtos;
using SmartServices.Models;
using SmartServices.Repositories.Contracts;
using SmartServices.Services.Contracts;

namespace SmartServices.Services
{
    public class CategoryManager : ICategoryService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public CategoryManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public void CreateCategory(CategoryDtoForInsertion categoryDto)
        {
            Category category = _mapper.Map<Category>(categoryDto);
            _manager.Category.Create(category);
            _manager.Save();
        }

        public void DeleteOneCategory(int categoryId)
        {
            Category category = GetOneCategory(categoryId, false);
            if(category is not null)
            {
                _manager.Category.DeleteOneCategory(category);
                _manager.Save();
            }
        }

        public IEnumerable<Category> GetAllCategories(bool trackChanges)
        {
            return _manager.Category.GetAllCategories(trackChanges);
               
        }

        public CategoryDtoForUpdate GetCategoryForUpdate(int categoryId, bool trackChanges)
        {
            var category = GetOneCategory(categoryId, trackChanges);
            var categoryDto = _mapper.Map<CategoryDtoForUpdate>(category);
            return categoryDto;
        }

        public Category? GetOneCategory(int categoryId, bool trackChanges)
        {
            var category = _manager.Category.GetOneCategory(categoryId, trackChanges);
            if (category is null)
                throw new Exception("Cateory not found ");
            return category;
        }

        public void UpdateOneCategory(CategoryDtoForUpdate categoryDto)
        {
            var entity = _mapper.Map<Category>(categoryDto);
            _manager.Category.UpdateOneCategory(entity);
            _manager.Save();
        }
    }
}
