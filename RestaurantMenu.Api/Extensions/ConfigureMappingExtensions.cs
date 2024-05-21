using Mapster;
#if MAPSTERDEBUG
using System.Linq.Expressions;
#endif

namespace RestaurantMenu.Api.Extensions
{
    public static class ConfigureMappingExtensions
    {
        private static readonly Lazy<IList<IRegister>> MapsterInit = new(() =>
        {
#if MAPSTERDEBUG
            TypeAdapterConfig.GlobalSettings.Compiler = exp => exp.CompileWithDebugInfo();
#endif
            TypeAdapterConfig.GlobalSettings.Default.Settings.NameMatchingStrategy = NameMatchingStrategy.IgnoreCase;
            TypeAdapterConfig.GlobalSettings.Default.PreserveReference(true);
            return TypeAdapterConfig.GlobalSettings.Scan(typeof(ConfigureMappingExtensions).Assembly);
        });

        public static IServiceCollection ConfigureApiMapping(this IServiceCollection services)
        {
            var _ = MapsterInit.Value;
            return services;
        }
    }
}