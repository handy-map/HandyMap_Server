using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class EntitiesConfig
    {
        private IConfiguration _configuration;
        private string HandyMapEntities;
        public EntitiesConfig(IConfiguration configuration)
        {
            _configuration = configuration;

            SetConfig();
        }

        public void SetConfig()
        {
            HandyMapEntities = _configuration["HandyMapEntities"];
        }
    }
}
