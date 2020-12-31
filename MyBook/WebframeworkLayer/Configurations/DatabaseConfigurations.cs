using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebframeworkLayer.Configurations
{
    public static class DatabaseConfigurations
    {
        public static void AddDatabase(this IServiceCollection services)
        {
            services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BookDb;Data Source=.");

            });
        }

    }
}
