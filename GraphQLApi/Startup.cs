using Graph.Query;
using Graph.Scheme;
using Graph.Type;
using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository.IRepository;
using Repository.Repository;

namespace GraphQLApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            _ = services.AddSingleton<IVeiculoRepository, VeiculoRepository>()
                        .AddSingleton<ICondutorRepository, CondutorRepository>()
                        .AddSingleton<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService))
                        .AddSingleton<VeiculoQuery>()
                        .AddSingleton<CondutorQuery>()
                        .AddSingleton<AppScheme>()
                        .AddSingleton<VeiculoType>()
                        .AddSingleton<CondutorType>()
                        .AddAuthorization();
            _ = services.AddGraphQL(o => o.ExposeExceptions = true).AddGraphTypes(ServiceLifetime.Singleton);
            _ = services.Configure<IISServerOptions>(o => o.AllowSynchronousIO = true);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                _ = app.UseDeveloperExceptionPage();
            }

            _ = app.UseHttpsRedirection()
                .UseRouting()
                .UseAuthorization();

            _ = app.UseGraphQL<AppScheme>()
                   .UseGraphQLPlayground(new GraphQLPlaygroundOptions());
        }
    }
}
