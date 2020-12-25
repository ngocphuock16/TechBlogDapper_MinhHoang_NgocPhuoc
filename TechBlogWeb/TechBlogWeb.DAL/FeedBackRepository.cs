using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.DAL.Interface;
using TechBlogWeb.Domain.Request.FeedBack;
using TechBlogWeb.Domain.Response.FeedBack;

namespace TechBlogWeb.DAL
{
    public class FeedBackRepository : BaseRepository, IFeedBackRepository
    {
        public async Task<CreateFeedBackResult> CreateFeedBack(CreateFeedBackRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Name", request.Name);
                parameters.Add("@Comment", request.Comment);
                parameters.Add("@Email", request.Email);
                return await SqlMapper.QueryFirstOrDefaultAsync<CreateFeedBackResult>(cnn: connect,
                                                    sql: "sp_CreateSupport",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<DeleteFeedBackResult> DeleteFeedBack(int FeedBackId)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Feedback", FeedBackId);
                return await SqlMapper.QueryFirstOrDefaultAsync<DeleteFeedBackResult>(cnn: connect,
                                                    sql: "sp_DeleteFeedBack",
                                                    param: parameters,
                                                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<FeedBack>> Gets()
        {
            return await SqlMapper.QueryAsync<FeedBack>(cnn: connect,
                                               sql: "sp_GetFeedBack",
                                               commandType: CommandType.StoredProcedure);
        }
    }
}
