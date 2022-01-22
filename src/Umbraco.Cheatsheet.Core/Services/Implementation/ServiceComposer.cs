using Umbraco.Core;
using Umbraco.Core.Composing;

namespace Umbraco.Cheatsheet.Core.Services.Implementation
{
    public class ServiceComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<IDataService, DataService>(Lifetime.Singleton);
        }
    }
}
