using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace Facebook.ApiClient.Test.Fixtures
{
    public class ConfigurationFixture
    {
        public ConfigurationFixture()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();
        }

        public IConfiguration Configuration { get; }
    }
}
