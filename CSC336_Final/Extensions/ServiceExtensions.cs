using BLL.Service.Airplanes;
using BLL.Service.Flights;
using BLL.Service.Passengers;
using BLL.Service.Pilots;
using BLL.Service.Reservations;
using BLL.Service.ResWPassengerFlights;
using DAL.Models;

namespace CSC336_Final.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddService(this IServiceCollection service)
        {
            service.AddScoped<IAirplaneService, AirplaneService>();
            service.AddScoped<IPassengerSerive, PassengerService>();
            service.AddScoped<IFlightService, FlightService>();
            service.AddScoped<IPilotService, PilotService>();
            service.AddScoped<IReservationService, ReservationService>();
            service.AddScoped<IResWPassengerFlightSerive, ResWPassengerFlightService>();
            return service;
        }
    }
}
