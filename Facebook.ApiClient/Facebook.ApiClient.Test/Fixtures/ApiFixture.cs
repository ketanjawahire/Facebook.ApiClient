using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace Facebook.ApiClient.Test.Fixtures
{
    public class ApiFixture
    {
        public ApiEngine.ApiClient GetApiClient(IConfiguration configuration)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            return new ApiEngine.ApiClient(configuration["ACCESS_KEY"], configuration["VERSION"]);
        }
    }
}
