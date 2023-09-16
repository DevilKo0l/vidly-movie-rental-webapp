namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Customers ON");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES (1, 'Nathan Cao', 1, 4, '1996/01/30')");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES (2, 'Trinh Nguyen', 1, 3, '1997/10/21')");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES (3, 'Chaitanya Annepu', 0, 2, null)");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES (4, 'Long Tran', 0, 1, '1992/11/17')");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES (5, 'Moussi Walid', 1, 4, null)");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES (6, 'Mohammed Mazz', 0, 2, null)");
            Sql("SET IDENTITY_INSERT Customers OFF");
        }
        
        public override void Down()
        {
        }
    }
}
