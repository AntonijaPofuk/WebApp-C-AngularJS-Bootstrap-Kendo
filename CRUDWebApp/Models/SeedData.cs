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
                        Age = 12
                    },

                    new Student
                    {
                        Name = "Lenny",
                        Age = 13
                    },

                    new Student
                    {
                        Name = "Barry",
                        Age = 15
                    },

                    new Student
                    {
                        Name = "Haarry",
                        Age = 17
                    }
                );
                context.SaveChanges();
            }
        }
    }
}