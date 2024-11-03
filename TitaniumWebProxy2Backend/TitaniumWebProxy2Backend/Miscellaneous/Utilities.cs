using GRYLibrary.Core.APIServer.ConcreteEnvironments;

namespace TitaniumWebProxy2Backend.Core.Miscellaneous
{
    internal static class Utilities
    {
        internal static GRYEnvironment GetEnvironmentTargetType()
        {
#if Development
            return Development.Instance;
#elif QualityCheck
            return QualityCheck.Instance;
#elif Productive
            return Productive.Instance;
#else
            throw new System.Collections.Generic.KeyNotFoundException("Unknown environmenttargettype.");
#endif
        }
    }
}
