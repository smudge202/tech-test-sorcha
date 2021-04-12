using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Speik.TechnicalTest
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddLotteryNumberGenerator(this IServiceCollection services) =>
            services.AddLotteryNumberGenerator(_ => { });
        
        public static IServiceCollection AddLotteryNumberGenerator(this IServiceCollection services,
            Action<LotteryOptions> configure)
        {
            services.AddOptions();
            services.Configure(configure);
            services.AddTransient(p => p.GetRequiredService<IOptions<LotteryOptions>>().Value);
            services.AddTransient<ILotteryNumberGenerator, LotteryNumberGenerator>();
            services.AddTransient<IRandomNumberGenerator, CryptoRandomNumberGenerator>();
            return services;
        }
    }
}