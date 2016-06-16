using Core.Entities;
using DataContext;
using System.Data.Entity;
using System;
using System.Reflection;
using System.Linq;

namespace DataAccess
{
    public class AppDataContext : DbContext, IAppDataContext
    {
        public AppDataContext() 
            : base("AppDataContext")
        {
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
           //.Where(type => !string.IsNullOrEmpty(type.Namespace))
           //.Where(type => type.BaseType != null && type.BaseType.IsGenericType
           //     && type.BaseType.GetGenericTypeDefinition() == typeof(BaseEntityConfiguration<>));
           // foreach (var type in typesToRegister)
           // {
           //     dynamic configurationInstance = Activator.CreateInstance(type);
           //     modelBuilder.Configurations.Add(configurationInstance);
           // }
           // base.OnModelCreating(modelBuilder);
        }
    }
}
