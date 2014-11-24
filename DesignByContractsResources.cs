using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using MFramework.Common.Core.Resource;
using MFramework.Common.Core.Resource.Containers;

using MFramework.Common.Core.Resource.ResourceTypes;

namespace MFramework.Common.DesignByContracts
{
    internal class DesignByContractsResources
    {
        private DesignByContractsResources() {}
        public static IResource<string> ArgumentNullExceptionMessage =
            ResourceManager<Resx<Resx.ResxConfigurationOnAssemblyDefault<DesignByContractsResources>>>.Register(new ResourceString("ArgumentNullException"));
    }
}
