using Kashyapas.SeasonsOfServerless.Service;
using Kashyapas.SeasonsOfServerless.Services;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Kashyapas.SeasonsOfServerless.Startup))]

namespace Kashyapas.SeasonsOfServerless
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<IRecipeGenerator, TurkeyRecipeGenerator>();
        }
    }
}
