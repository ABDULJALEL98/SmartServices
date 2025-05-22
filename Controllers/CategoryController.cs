using Microsoft.AspNetCore.Mvc;
using SmartServices.Dtos;
using SmartServices.Models;
using SmartServices.Services.Contracts;

namespace SmartServices.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IServiceManager _manager;

        public CategoryController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            
            var categoryDto = new CategoryDtoForInsertion
            {
                CategoryId = 1,
                CategoryName = "One"
            };

            _manager.CategoryService.CreateCategory(categoryDto);
            return View( );
        }
    }
}
