using CORE.MotoMastersMD.Interfaces;
using INFRAESTRUCTURE.MotoMastersMD.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace API.MotoMastersMD.Resolvers
{
    public static class MotoMasters_Dependencies
    {
        public static void ResolveDependenciesMMs(this IServiceCollection services)
        {
            services.AddTransient<IAppts, ApptsRepo>();
            services.AddTransient<IApptsStatus, ApptsStatusRepo>();
            services.AddTransient<ICategories, CategoriesRepo>();
            services.AddTransient<IClients, ClientsRepo>();
            services.AddTransient<IPData, PDataRepo>();
            services.AddTransient<IProducts, ProductsRepo>();
            services.AddTransient<IServices, ServicesRepo>();
            services.AddTransient<IServicesGiven, ServicesGivenRepo>();
            services.AddTransient<ISoldProducts, SoldProductsRepo>();
            services.AddTransient<IUsers, UsersRepo>();
            services.AddTransient<IUsersType, UsersTypeRepo>();
        }
    }
}
