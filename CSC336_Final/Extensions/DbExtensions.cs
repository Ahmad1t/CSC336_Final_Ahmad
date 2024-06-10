using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CSC336_Final.Extensions
{
    public static class DbExtensions
    {
        public static IServiceCollection AddDb(this IServiceCollection service, ConfigurationManager config)
        {
            var ConnectionString = config.GetConnectionString("DefaultConnection");


            service.AddDbContext<AirplaneSystemContext>(options =>
                  options.UseSqlServer(ConnectionString)
                  );
            return service;
        }
    }
}
