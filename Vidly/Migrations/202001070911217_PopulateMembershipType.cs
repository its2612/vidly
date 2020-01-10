namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into MembershipTypes(Id,SinupFree,DurationInMonths,DiscountRate) values(1,0,0,0)");
            Sql("Insert into MembershipTypes(Id,SinupFree,DurationInMonths,DiscountRate) values(1,0,0,0)");
            Sql("Insert into MembershipTypes(Id,SinupFree,DurationInMonths,DiscountRate) values(1,0,0,0)");
        }
        
        public override void Down()
        {
        }
    }
}
