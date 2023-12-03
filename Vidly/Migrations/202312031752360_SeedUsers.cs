namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'193de18e-cdae-4400-a196-663d48c4ed1d', N'guest@vidly.com', 0, N'AKNgMomi+KdsS1HmQRUs8VDuQv4CqhxtZUM0OHEfROw6Ql3D1YS5UmDeowAqa/UREw==', N'd00b9ffb-8fc8-4742-aed4-11d709d2d14d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'94878ba9-8045-4baf-a76d-d21d5a353002', N'admin@vidly.com', 0, N'ANxUkZTtGq4mVRYiujUSGbYXANjnUI/vQT0Kp6aWbVqbW8JHF8SWxvLXLJckWd0LQg==', N'82744c85-d485-4779-bc58-145419c41d72', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c148e320-7088-4eed-abbb-ad34700cc994', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'94878ba9-8045-4baf-a76d-d21d5a353002', N'c148e320-7088-4eed-abbb-ad34700cc994')

");
        }
        
        public override void Down()
        {
            
        }
    }
}
