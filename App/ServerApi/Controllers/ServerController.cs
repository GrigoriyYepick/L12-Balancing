using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Reflection;

namespace ServerApi.Controllers
{
    [ApiController]
    public sealed class ServerController : ControllerBase
    {
        private const string DefaultResponse = "something went wrong";
        private readonly ILogger<ServerController> _logger;

        public ServerController(ILogger<ServerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/")]
        public string Get()
        {
            var outputPath = Path.GetDirectoryName(new Uri(Assembly.GetAssembly(typeof(ServerController)).CodeBase).AbsolutePath);
            var filePath = Path.Combine(outputPath, "server.txt");

            string response = DefaultResponse;

            if (System.IO.File.Exists(filePath))
            {
                response = System.IO.File.ReadAllText(filePath);
            }

            return response;
        }
    }
}
