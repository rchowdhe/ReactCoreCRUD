using Microsoft.Extensions.DependencyInjection;
using ReactCoreCRUD.Interfaces;
using ReactCoreCRUD.Repository;
using ReactCoreCRUD.Repository.Queries;

namespace ReactCoreCRUD
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ICommandText, CommandText>();
            services.AddTransient<IUserDetailsRepository, UserDetailsRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
