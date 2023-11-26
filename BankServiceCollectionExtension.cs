using MiniPaymentAPI.Services;
using MiniPaymentAPI.Services.Contracts;

namespace MiniPaymentAPI
{
    public static class ServiceCollectionExtension
    {
        public static void AddBankServices(this IServiceCollection services)
        {
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IBankService, AkbankService>();
            services.AddScoped<IBankService, GarantiService>();
            services.AddScoped<IBankService, YapiKrediService>();
        }
    }
}
