namespace StudentInfoSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        FacultyId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.FacultyId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Speciality = c.String(),
                        Degree = c.String(),
                        FacultyNumber = c.String(),
                        Course = c.Int(nullable: false),
                        Stream = c.Int(nullable: false),
                        Group = c.Int(nullable: false),
                        Photo = c.Binary(),
                        StudentStatusId = c.Int(nullable: false),
                        FacultyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Faculties", t => t.FacultyId, cascadeDelete: true)
                .ForeignKey("dbo.StudentStatus", t => t.StudentStatusId, cascadeDelete: true)
                .Index(t => t.StudentStatusId)
                .Index(t => t.FacultyId);
            
            CreateTable(
                "dbo.StudentStatus",
                c => new
                    {
                        StudentStatusId = c.Int(nullable: false, identity: true),
                        StatusDescription = c.String(),
                    })
                .PrimaryKey(t => t.StudentStatusId);
            
            CreateTable(
                "dbo.LogAttempts",
                c => new
                    {
                        LogAttemptId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Time = c.DateTime(nullable: false),
                        StatusCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LogAttemptId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        FacultyNumber = c.String(),
                        Role = c.Int(nullable: false),
                        ActiveUntil = c.DateTime(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "StudentStatusId", "dbo.StudentStatus");
            DropForeignKey("dbo.Students", "FacultyId", "dbo.Faculties");
            DropIndex("dbo.Students", new[] { "FacultyId" });
            DropIndex("dbo.Students", new[] { "StudentStatusId" });
            DropTable("dbo.Users");
            DropTable("dbo.LogAttempts");
            DropTable("dbo.StudentStatus");
            DropTable("dbo.Students");
            DropTable("dbo.Faculties");
        }
    }
}
