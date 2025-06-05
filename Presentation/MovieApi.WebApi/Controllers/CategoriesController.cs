using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieApi.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers;
using MovieApi.Application.Features.CQRSDesignPattern.Queries.CategoryQueries;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly GetCategoryQueryHandler _getCategoryCommandHandler;
        private readonly GetCategoryByIdQueryHandler _getCategoryByIdCommandHandler;
        private readonly CreateCategoryCommandHandler _createCategoryCommandHandler;
        private readonly RemoveCategoryCommandHandler _removeCategoryCommandHandler;
        private readonly UpdateCategoryCommandHandler _updateCategoryCommandHandler;
        public CategoriesController(GetCategoryQueryHandler getCategoryCommandHandler, GetCategoryByIdQueryHandler getCategoryByIdCommandHandler, CreateCategoryCommandHandler createCategoryCommandHandler, RemoveCategoryCommandHandler removeCategoryCommandHandler, UpdateCategoryCommandHandler updateCategoryCommandHandler)
        {
            _getCategoryCommandHandler = getCategoryCommandHandler;
            _getCategoryByIdCommandHandler = getCategoryByIdCommandHandler;
            _createCategoryCommandHandler = createCategoryCommandHandler;
            _removeCategoryCommandHandler = removeCategoryCommandHandler;
            _updateCategoryCommandHandler = updateCategoryCommandHandler;
        }
        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _getCategoryCommandHandler.Handle();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
        {
            await _createCategoryCommandHandler.Handle(command);
            return Ok("Kategori Eklendi!");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _removeCategoryCommandHandler.Handle(new RemoveCategoryCommand(id));
            return Ok("Kategori Silindi!");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
        {
            await _updateCategoryCommandHandler.Handle(command);
            return Ok("Kategori Güncellendi!");
        }
        [HttpGet("GetCategory")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var value = await _getCategoryByIdCommandHandler.Handle(new GetCategoryByIdQuery(id));
            return Ok(value);
        }

    }
}
