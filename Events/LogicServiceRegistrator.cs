using Events.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Events
{
    public static class LogicServiceRegistrator
    {
        public static IServiceCollection RegisterLogicServices(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<IEventService, EventService>();

            return serviceCollection;
        }
    }
}
