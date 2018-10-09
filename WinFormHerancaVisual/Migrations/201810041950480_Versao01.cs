namespace WinFormHerancaVisual.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Versao01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DataCadastro = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 40),
                        Fone = c.String(),
                        Sexo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DataCadastro = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 40),
                        Quantidade = c.Double(nullable: false),
                        VlrProduto = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produto");
            DropTable("dbo.Cliente");
        }
    }
}
