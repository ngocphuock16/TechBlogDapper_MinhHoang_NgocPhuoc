using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.DAL.Interface;
using TechBlogWeb.Domain.Request.Support;
using TechBlogWeb.Domain.Response.Support;

namespace TechBlogWeb.DAL
{
    public class SupportRepository : BaseRepository, ISupportRepository
    {
        public async Task<CreateSupportResult> CreateSupport(CreateSupportRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ContentSupport", request.ContentSupport);
                parameters.Add("@Name", request.Name);
                parameters.Add("@Email", request.Email);
                parameters.Add("@Subject", request.Subject);
                return await SqlMapper.QueryFirstOrDefaultAsync<CreateSupportResult>(cnn: connect,
                                                    sql: "sp_CreateSupport",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<DeleteSupportResult> DeleteSupport(int SupportId)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@SupportId", SupportId);
                return await SqlMapper.QueryFirstOrDefaultAsync<DeleteSupportResult>(cnn: connect,
                                                    sql: "sp_DeleteSupport",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Support>> Gets()
        {
            return await SqlMapper.QueryAsync<Support>(cnn: connect,
                                               sql: "sp_GetSupport",
                                               commandType: CommandType.StoredProcedure);
        }
    }
}
