using LibModelsContext.Helpers;
using LibModelsContext.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibModelsContext.DataDB.Configuration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasData(
                new UserRole
                {
                    Id = 1,
                    Name = UserRolesHelper.Administrator,
                    NormalizedName = UserRolesHelper.Administrator.ToUpper()
                },
                new UserRole
                {
                    Id = 2,
                    Name = UserRolesHelper.HumanResourceManager,
                    NormalizedName = UserRolesHelper.HumanResourceManager.ToUpper()
                },
                new UserRole
                {
                    Id = 3,
                    Name = UserRolesHelper.NormalUser,
                    NormalizedName = UserRolesHelper.NormalUser.ToUpper()
                },
                new UserRole
                {
                    Id = 4,
                    Name = UserRolesHelper.UnregisteredUser,
                    NormalizedName = UserRolesHelper.UnregisteredUser.ToUpper()
                });
        }
    }
}
