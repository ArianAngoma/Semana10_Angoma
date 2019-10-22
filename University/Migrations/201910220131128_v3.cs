﻿namespace University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OfficeAssignments", "Activo", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OfficeAssignments", "Activo");
        }
    }
}
