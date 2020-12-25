using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.DAL.Interface;
using TechBlogWeb.Domain.Request.Blog;
using TechBlogWeb.Domain.Response.Blog;

namespace TechBlogWeb.DAL
{
    public class BlogRepository : BaseRepository, IBlogRepository
    {
        public async Task<CreateBlogResult> CreateBlog(CreateBlogRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ImageUrl", request.ImageUrl);
                parameters.Add("@PublishDate", request.PublishDate);
                parameters.Add("@Title", request.Title);
                parameters.Add("@ShortContent", request.ShortContent);
                parameters.Add("@FullContent", request.FullContent);
                parameters.Add("@CategoryId", request.CategoryId);
                return await SqlMapper.QueryFirstOrDefaultAsync<CreateBlogResult>(cnn: connect,
                                                    sql: "sp_CreateBlog",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<DeleteBlogResult> DeleteBlog(int BlogId)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BlogId", BlogId);
                return await SqlMapper.QueryFirstOrDefaultAsync<DeleteBlogResult>(cnn: connect,
                                                    sql: "sp_DeleteBlog",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Blog>> Gets()
        {
            return await SqlMapper.QueryAsync<Blog>(cnn: connect,
                                               sql: "sp_GetBlogCate",
                                               commandType: CommandType.StoredProcedure);
        }

        public async Task<UpdateBlogResult> UpdateBlog(UpdateBlogRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@BlogId", request.BlogId);
                parameters.Add("@ImageUrl", request.ImageUrl);
                parameters.Add("@PublishDate", request.PublishDate);
                parameters.Add("@Title", request.Title);
                parameters.Add("@ShortContent", request.ShortContent);
                parameters.Add("@FullContent", request.FullContent);
                parameters.Add("@CategoryId", request.CategoryId);
                return await SqlMapper.QueryFirstOrDefaultAsync<UpdateBlogResult>(cnn: connect,
                                                    sql: "sp_UpdateBlog",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;

            }
        }
    }
}
