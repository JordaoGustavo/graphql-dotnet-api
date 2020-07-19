using Graph.Scheme;
using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository.IRepository;

namespace GraphQLApi
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
            _ = services.AddControllers();

            _ = services.AddSingleton<IVeiculoRepository>();
            _ = services.AddSingleton<ICondutorRepository>();

            _ = services.AddScoped<AppScheme>();
            _ = services.AddScoped<IDependencyResolver>(s =>
                        new FuncDependencyResolver(s.GetRequiredService));
            _ = services.AddGraphQL(o => o.ExposeExceptions = false).AddGraphTypes(ServiceLifetime.Scoped);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                _ = app.UseDeveloperExceptionPage();
            }
            _ = app.UseHttpsRedirection()
                   .UseRouting()
                   .UseAuthorization()
                   .UseEndpoints(endpoints => endpoints.MapControllers())
                   .UseGraphQL<AppScheme>()
                   .UseGraphQLPlayground(options: new GraphQLPlaygroundOptions());
        }
    }
}
