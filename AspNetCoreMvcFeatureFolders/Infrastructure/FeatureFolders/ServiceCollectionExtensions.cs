using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreMvcFeatureFolders.Infrastructure.FeatureFolders
{
    public static class ServiceCollectionExtensions
    {
        public static IMvcBuilder AddFeatureFolders(this IMvcBuilder services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddRazorOptions(o =>
            {
                o.ViewLocationExpanders.Add(new FeatureViewLocationExpander());
            });

            return services;
        }
    }
}
