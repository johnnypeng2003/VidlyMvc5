namespace VidlyMVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT[dbo].[AspNetRoles]([Id], [Name]) VALUES(N'c8a7002e-0660-4e15-8e54-8012d95fd556', N'CanManageMovie')
            INSERT[dbo].[AspNetUsers]
                ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'081ebed3-869c-400c-aa91-a1f0746f5556', N'admin@vidly.com', 0, N'AOm3VTIjXit6W+0s4P8bgUNUDosWGxgTPyGm/ub13yow0tLMek+PniRsQhCO9j2XAg==', N'31940740-71d4-4d8f-8645-d316316b6bd7', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT[dbo].[AspNetUsers]
                ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'9e75160b-fd0e-408d-922d-732264043cbc', N'guest@vidly.com', 0, N'AKQl+/LZQa3yTRVkDKzNwAE94cA6qgJO2fuKAAiWIMu4YPt1Fska77Fy1fmBYKdu/Q==', N'ca8ef72b-194b-489c-bf8a-5325187216da', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            INSERT[dbo].[AspNetUserRoles]
                ([UserId], [RoleId]) VALUES(N'081ebed3-869c-400c-aa91-a1f0746f5556', N'c8a7002e-0660-4e15-8e54-8012d95fd556')
");
    }
        
        public override void Down()
        {
        }
    }
}
