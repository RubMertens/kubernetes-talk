using System;
using Microsoft.Extensions.Configuration;

namespace Color.Web
{
    public class ColorService
    {
        private readonly IConfiguration _configuration;

        public ColorService(IConfiguration configuration)
        {
            _configuration = configuration;

            var rn = new Random();
            var colors = configuration.GetSection("Colors").Get<string[]>();

            Color = colors[rn.Next(colors.Length - 1)];
        }
        
        
        public string Color { get; }
    }
}