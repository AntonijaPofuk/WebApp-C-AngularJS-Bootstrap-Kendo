using CRUDWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWebApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcStudentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcStudentContext>>()))
            {
                // Look for any Students. If there are any students in DB, no new rows are added.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(
                    new Student
                    {
                        Name = "Harry",
                        Rating = "A",
                        Age = 12
                    },

                    new Student
                    {
                        Name = "Lenny",
                        Rating = "C",
                        Age = 13
                    },

                    new Student
                    {
                        Name = "Barry",
                        Rating = "A",
                        Age = 15
                    },

                    new Student
                    {
                        Name = "Haarry",
                        Rating = "B",
                        Age = 17
                    }
                );
                context.SaveChanges();
            }
        }
    }
}