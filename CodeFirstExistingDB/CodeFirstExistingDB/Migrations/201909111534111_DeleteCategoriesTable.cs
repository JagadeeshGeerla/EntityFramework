namespace CodeFirstExistingDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCategoriesTable : DbMigration
    {
        public override void Up()
        {
            //OPTION 1
           // Sql("SELECT * INTO CategoriesBackup from Categories");

            //OR OPTION 2
            ////////
            CreateTable(
               "dbo.CategoriesBk",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   Name = c.String(),
               })
               .PrimaryKey(t => t.Id);

            Sql("INSERT INTO CategoriesBk(Name) SELECT Name FROM Categories");
            ///////

            DropTable("dbo.Categories");
        }
        
        public override void Down()
        {            
            //OPTION 1
           // Sql("SELECT * INTO Categories from CategoriesBackup");

            //OR OPTION 2
            //////// 
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            Sql("INSERT INTO Categories(Name) SELECT Name FROM CategoriesBk");
            ///////



           // DropTable("dbo.CategoriesBackup");
            DropTable("dbo.CategoriesBk");
        }
    }
}
