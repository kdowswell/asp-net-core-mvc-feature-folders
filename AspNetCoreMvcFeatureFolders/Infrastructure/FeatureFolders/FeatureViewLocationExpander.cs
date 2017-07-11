using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Razor;

namespace AspNetCoreMvcFeatureFolders.Infrastructure.FeatureFolders
{
    public class FeatureViewLocationExpander : IViewLocationExpander
    {
        public void PopulateValues(ViewLocationExpanderContext context)
        {

        }

        public IEnumerable<string> ExpandViewLocations(
            ViewLocationExpanderContext context,
            IEnumerable<string> viewLocations)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            if (viewLocations == null)
            {
                throw new ArgumentNullException(nameof(viewLocations));
            }

            // {0} - Action Name
            // {1} - Controller Name
            // {2} - Area name

            //Features
            yield return "/Features/{1}/{0}.cshtml";
            yield return "/Features/{1}/Views/{0}.cshtml";

            //Feature Features
            yield return "/Features/{2}/{1}/{0}.cshtml";
            yield return "/Features/{2}/{1}/Views/{0}.cshtml";
            yield return "/Features/{2}/Shared/{0}.cshtml";

            //Shared
            yield return "/Features/Shared/{0}.cshtml";
        }
    }
}
