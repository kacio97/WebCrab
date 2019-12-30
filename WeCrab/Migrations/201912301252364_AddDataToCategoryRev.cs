namespace WeCrab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToCategoryRev : DbMigration
    {
        public override void Up()
        {
            Sql("set IDENTITY_INSERT Categories on");
            Sql("insert into Categories (Id, Name) values (1, 'Komedia')");
            Sql("insert into Categories (Id, Name) values (2, 'Dramat')");
            Sql("insert into Categories (Id, Name) values (3, 'Kreskówka')");
            Sql("insert into Categories (Id, Name) values (4, 'Przygodowy')");
            Sql("insert into Categories (Id, Name) values (5, 'Naukowy')");
        }
        
        public override void Down()
        {
        }
    }
}
