using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.DAL.Interface;
using TechBlogWeb.Domain.Request.HomeFuture;
using TechBlogWeb.Domain.Response.HomeFuture;

namespace TechBlogWeb.DAL
{
    public class HomeFutureRepository : BaseRepository, IHomeFutureRepository
    {
        public async Task<IEnumerable<HomeFuture>> Gets()
        {
            return await SqlMapper.QueryAsync<HomeFuture>(cnn: connect,
                                              sql: "sp_GetHomeFuture",
                                              commandType: CommandType.StoredProcedure);
        }

        public async Task<UpdateHomeFutureResult> UpdateHomeFuture(UpdateHomeFutureRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@HFId", request.HFId);
                parameters.Add("@HFTitle", request.HFTitle);
                parameters.Add("@HFContent", request.HFContent);
                return await SqlMapper.QueryFirstOrDefaultAsync<UpdateHomeFutureResult>(cnn: connect,
                                                    sql: "sp_UpdateHomeFuture",
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
