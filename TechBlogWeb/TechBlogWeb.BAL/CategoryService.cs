using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.BAL.Interface;
using TechBlogWeb.DAL.Interface;
using TechBlogWeb.Domain.Request.Category;
using TechBlogWeb.Domain.Response.Category;

namespace TechBlogWeb.BAL
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public async Task<CreateCategoryResult> CreateCategory(CreateCategoryRequest request)
        {
            return await categoryRepository.CreateCategory(request);
        }

       

        public async Task<DeleteCategoryResult> DeleteCategory(int catId)
        {
            return await categoryRepository.DeleteCategory(catId);
        }

        public async Task<IEnumerable<Category>> Gets()
        {
            return await categoryRepository.Gets();
        }

        public async Task<UpdateCategoryResult> UpdateCatgory(UpdateCategoryRequest request)
        {
            return await categoryRepository.UpdateCategory(request);
        }
    }
}
