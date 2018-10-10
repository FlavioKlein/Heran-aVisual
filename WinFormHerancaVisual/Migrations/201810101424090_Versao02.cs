namespace WinFormHerancaVisual.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Versao02 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GrupoProduto",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DataCadastro = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GrupoProduto");
        }
    }
}
