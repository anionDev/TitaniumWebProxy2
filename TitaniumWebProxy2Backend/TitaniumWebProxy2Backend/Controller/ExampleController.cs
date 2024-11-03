using TitaniumWebProxy2Backend.Core.Constants;
using GRYLibrary.Core.APIServer.Settings.Configuration;
using GRYLibrary.Core.Logging.GeneralPurposeLogger;
using Microsoft.AspNetCore.Mvc;

namespace TitaniumWebProxy2Backend.Core.Controller
{
    [ApiController]
    [Route(ExampleController.ControllerRoute)]
    public class ExampleController : ControllerBase
    {
        public const string ControllerRoute = $"{ServerConfiguration.APIRoutePrefix}/v{GeneralConstants.CodeUnitMajorVersion}/{nameof(ExampleController)}";
        private readonly IGeneralLogger _Logger;
        public ExampleController(IGeneralLogger logger)
        {
            this._Logger = logger;
        }

    }
}
