using Microsoft.EntityFrameworkCore;
using Qa517.Users;
using Volo.Abp;

namespace Qa517.EntityFrameworkCore
{
    public static class Qa517DbContextModelCreatingExtensions
    {
        public static void ConfigureQa517(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(Qa517Consts.DbTablePrefix + "YourEntities", Qa517Consts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});


            builder.Entity<AppUserSqlView>(eb =>
            {
                eb.HasKey(x => new {x.Name, x.Email});
                eb.ToView("View_AppUserView");
            });
        }
    }
}
