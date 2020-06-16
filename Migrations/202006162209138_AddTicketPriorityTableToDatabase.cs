﻿namespace BugTrackerApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTicketPriorityTableToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TicketPriorities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Tickets", "TicketPriorityId", c => c.Int(nullable: false));
            CreateIndex("dbo.Tickets", "TicketPriorityId");
            AddForeignKey("dbo.Tickets", "TicketPriorityId", "dbo.TicketPriorities", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "TicketPriorityId", "dbo.TicketPriorities");
            DropIndex("dbo.Tickets", new[] { "TicketPriorityId" });
            DropColumn("dbo.Tickets", "TicketPriorityId");
            DropTable("dbo.TicketPriorities");
        }
    }
}
