using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace DockerTest
{
    public static class PrepDB
    {
        public static void PrepPopulation(IApplicationBuilder application)
        {
            using (var serviceScope = application.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<DataContext>());
            }
        } 

        public static void SeedData(DataContext context)
        {
            System.Console.WriteLine("Appling Migrations");

            context.Database.Migrate();

            System.Console.WriteLine("Adding data - seeding...");
            context.TestModelItems.AddRange(
                new TestModel() {Name = "asd1", Description ="asd1"},
                new TestModel() {Name = "asd2", Description ="asd2"}, 
                new TestModel() {Name = "asd3", Description ="asd3"}, 
                new TestModel() {Name = "asd4", Description ="asd4"} 
            );
        }
    }
}