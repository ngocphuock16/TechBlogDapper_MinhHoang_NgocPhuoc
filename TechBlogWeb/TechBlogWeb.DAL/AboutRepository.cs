using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.DAL.Interface;
using TechBlogWeb.Domain.Request.About;
using TechBlogWeb.Domain.Response.About;

namespace TechBlogWeb.DAL
{
    public class AboutRepository : BaseRepository, IAboutRepository
    {
        public async Task<IEnumerable<About>> Gets()
        {
            return await SqlMapper.QueryAsync<About>(cnn: connect,
                                              sql: "sp_GetAbout",
                                              commandType: CommandType.StoredProcedure);
        }

        public async Task<UpdateAboutResult> UpdateAbout(UpdateAboutRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Title", request.Title);
                parameters.Add("@ShortContent", request.ShortContent);
                parameters.Add("@Content", request.Content);
                parameters.Add("@ImageUrl", request.ImageUrl);
                return await SqlMapper.QueryFirstOrDefaultAsync<UpdateAboutResult>(cnn: connect,
                                                    sql: "sp_UpdateAbout",
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
