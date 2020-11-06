﻿using Microsoft.EntityFrameworkCore;
using Qa517.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;

namespace Qa517.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See Qa517MigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class Qa517DbContext : AbpDbContext<Qa517DbContext>
    {
        public DbSet<AppUser> Users { get; set; }

        public DbSet<AppUserSqlView> UserSqlView { get; set; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside Qa517DbContextModelCreatingExtensions.ConfigureQa517
         */

        public Qa517DbContext(DbContextOptions<Qa517DbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users"); //Sharing the same table "AbpUsers" with the IdentityUser

                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                /* Configure mappings for your additional properties
                 * Also see the Qa517EfCoreEntityExtensionMappings class
                 */
            });

            /* Configure your own tables/entities inside the ConfigureQa517 method */

            builder.ConfigureQa517();
        }
    }
}
