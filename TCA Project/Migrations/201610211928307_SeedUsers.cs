namespace TCA_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0f3d228e-af88-4e21-b93a-aa50e52a6ca6', N'admin@email.com', 0, N'AJ4J6b0t30//aV9M5fFRUhM6Bu+oDWBjYYC9g8UAe/AktURvTc1vsE1twyVwlB6SoA==', N'2f92dd3b-f147-4e92-a50e-49e5dca684b8', NULL, 0, 0, NULL, 1, 0, N'admin@email.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'153a375b-521f-41e3-bb55-a2e03a8b03a8', N'jkdrohman@gmail.com', 0, N'AOLPH8dc7OU3id8EMEOgUxE9OcujH7+iDLs+JJS9j42h4uFm7B1VyF/BHM+eaCYpAA==', N'eb9da5ae-4a5e-4f32-a713-fd7ed1fced38', NULL, 0, 0, NULL, 1, 0, N'jkdrohman@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e607910c-d0bc-48e0-9c83-dce5852e7a72', N'CanManage')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0f3d228e-af88-4e21-b93a-aa50e52a6ca6', N'e607910c-d0bc-48e0-9c83-dce5852e7a72')

");
        }
        
        public override void Down()
        {
        }
    }
}
