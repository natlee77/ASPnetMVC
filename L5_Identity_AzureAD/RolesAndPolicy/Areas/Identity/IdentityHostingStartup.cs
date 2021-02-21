using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RolesAndPolicy.Data;

[assembly: HostingStartup(typeof(RolesAndPolicy.Areas.Identity.IdentityHostingStartup))]
namespace RolesAndPolicy.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {

               // services.AddAuthentication<>//som in startUpp.cs---kan göra hear
            });
        }
    }
}