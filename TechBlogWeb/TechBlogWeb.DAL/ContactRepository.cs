using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using TechBlogWeb.DAL.Interface;
using TechBlogWeb.Domain.Request.Contact;
using TechBlogWeb.Domain.Response.Contact;

namespace TechBlogWeb.DAL
{
    public class ContactRepository : BaseRepository, IContactRepository
    {
        public async Task<IEnumerable<Contact>> Gets()
        {
            return await SqlMapper.QueryAsync<Contact>(cnn: connect,
                                               sql: "sp_GetContact",
                                               commandType: CommandType.StoredProcedure);
        }

        public async Task<UpdateContactResult> UpdateContact(UpdateContactRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Address", request.Address);
                parameters.Add("@Phone", request.Phone);
                parameters.Add("@Email", request.Email);
                return await SqlMapper.QueryFirstOrDefaultAsync<UpdateContactResult>(cnn: connect,
                                                    sql: "sp_UpdateContact",
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
