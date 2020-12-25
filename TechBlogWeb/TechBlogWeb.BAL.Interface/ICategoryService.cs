using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.Domain.Request.Category;
using TechBlogWeb.Domain.Response.Category;

namespace TechBlogWeb.BAL.Interface
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> Gets();
        Task<CreateCategoryResult> CreateCategory(CreateCategoryRequest request);

        Task<UpdateCategoryResult> UpdateCatgory(UpdateCategoryRequest request);
        Task<DeleteCategoryResult> DeleteCategory(int catId);
    }
}
