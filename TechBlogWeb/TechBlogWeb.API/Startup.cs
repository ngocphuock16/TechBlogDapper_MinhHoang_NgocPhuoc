using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TechBlogWeb.BAL;
using TechBlogWeb.BAL.Interface;
using TechBlogWeb.DAL;
using TechBlogWeb.DAL.Interface;

namespace TechBlogWeb.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<ISupportService, SupportService>();
            services.AddScoped<ISupportRepository, SupportRepository>();
            services.AddScoped<IFeedBackService, FeedBackService>();
            services.AddScoped<IFeedBackRepository, FeedBackRepository>();
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<IHomeService, HomeService>();
            services.AddScoped<IHomeRepository, HomeRepository>();
            services.AddScoped<IHomeFutureService, HomeFutureService>();
            services.AddScoped<IHomeFutureRepository, HomeFutureRepository>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IContactRepository, ContactRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseSwagger();
       //swagger
            
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "TechBlog API");
            });
            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
