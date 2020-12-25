using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.DAL.Interface;
using TechBlogWeb.Domain.Request.Home;
using TechBlogWeb.Domain.Response.Home;

namespace TechBlogWeb.DAL
{
    public class HomeRepository : BaseRepository, IHomeRepository
    {
        public async Task<IEnumerable<Home>> Gets()
        {
            return await SqlMapper.QueryAsync<Home>(cnn: connect,
                                              sql: "sp_GetHome",
                                              commandType: CommandType.StoredProcedure);
        }

        public async Task<UpdateHomeResult> UpdateHome(UpdateHomeRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Title", request.Title);
                parameters.Add("@Content", request.Content);
                return await SqlMapper.QueryFirstOrDefaultAsync<UpdateHomeResult>(cnn: connect,
                                                    sql: "sp_UpdateHome",
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
