namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f359ba78-646e-44cf-8e84-a5489ba63e05', N'guest@vidly.com', 0, N'APQRnyrB4q6xhnt3TT0TPUFZ0F2Miw0JKIAdCEKk7yPfeXEsn6wSeUwP7mIIhkEuDA==', N'3484bee4-62c6-4859-9911-287e1c3fdbcb', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ffe65652-093a-4922-95b0-af9978970cfb', N'admin@vidly.com', 0, N'ABEB91Y+Q493aOSCSVbvIEleFVVsx/Qa05Q+WKrke0U7UY+NrnSvVVZy/F0fweoQRw==', N'16c63583-aaac-4753-aa7d-5ab9b6512a54', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2c45fef6-e01b-4de7-bbdf-e220aa64eaf1', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ffe65652-093a-4922-95b0-af9978970cfb', N'2c45fef6-e01b-4de7-bbdf-e220aa64eaf1')

");
        }
        
        public override void Down()
        {
        }
    }
}
