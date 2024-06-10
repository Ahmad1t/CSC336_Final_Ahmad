using DAL.Repositories.Airplanes;
using DAL.Repositories.Flights;
using DAL.Repositories.Passengers;
using DAL.Repositories.Pilots;
using DAL.Repositories.Reservations;

namespace CSC336_Final.Extensions
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepository(this IServiceCollection service)
        {
            service.AddScoped<IPassengerRepository, PassengerRepository>();
            service.AddScoped<IAirplaneRepository, AirplaneRepository>();
            service.AddScoped<IPilotRepository, PilotRepository>();
            service.AddScoped<IFlightRepository, FlightRepository>();
            service.AddScoped<IReservationRepository, ReservationRepository>();
            return service;
        }
    }
}
