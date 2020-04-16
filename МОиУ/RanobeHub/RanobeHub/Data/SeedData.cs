using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RanobeHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RanobeHub.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationContext>>()))
            {
                if (context.Users.Any())
                {
                }

                if (!context.Roles.Any())
                {
                    context.Roles.AddRange(
                        new Role()
                        {
                            Name = "admin"
                        },
                        new Role()
                        {
                            Name = "user"
                        },
                        new Role()
                        {
                            Name = "translater"
                        }
                   );
                }


                context.Users.AddRange(
                    new User()
                    {
                        Email = "user@mail.ru",
                        Password = "123",
                        Role = context.Roles.FirstOrDefault( x => x.Name == "user")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
