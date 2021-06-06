namespace P.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        questionId = c.Int(nullable: false),
                        answerContent = c.String(),
                        isTrue = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.questionId, cascadeDelete: true)
                .Index(t => t.questionId);
            
            CreateTable(
                "dbo.ApplicationUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false),
                        Password = c.String(),
                        isTeacher = c.Boolean(nullable: false),
                        SchoolNumber = c.String(maxLength: 30),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Exam_Id = c.Int(),
                        Course_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Exams", t => t.Exam_Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .Index(t => t.Exam_Id)
                .Index(t => t.Course_Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        CourseCode = c.String(nullable: false, maxLength: 30),
                        TeacherId = c.Int(nullable: false),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUsers", t => t.Student_Id)
                .ForeignKey("dbo.ApplicationUsers", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                        examCode = c.String(),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GradeNo = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        Exam_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Exams", t => t.Exam_Id)
                .ForeignKey("dbo.ApplicationUsers", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.Exam_Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExamId = c.Int(nullable: false),
                        Type = c.String(maxLength: 20),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Exams", t => t.ExamId, cascadeDelete: true)
                .Index(t => t.ExamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "TeacherId", "dbo.ApplicationUsers");
            DropForeignKey("dbo.Grades", "StudentId", "dbo.ApplicationUsers");
            DropForeignKey("dbo.Courses", "Student_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.ApplicationUsers", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Exams", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.ApplicationUsers", "Exam_Id", "dbo.Exams");
            DropForeignKey("dbo.Questions", "ExamId", "dbo.Exams");
            DropForeignKey("dbo.Answers", "questionId", "dbo.Questions");
            DropForeignKey("dbo.Grades", "Exam_Id", "dbo.Exams");
            DropIndex("dbo.Questions", new[] { "ExamId" });
            DropIndex("dbo.Grades", new[] { "Exam_Id" });
            DropIndex("dbo.Grades", new[] { "StudentId" });
            DropIndex("dbo.Exams", new[] { "CourseId" });
            DropIndex("dbo.Courses", new[] { "Student_Id" });
            DropIndex("dbo.Courses", new[] { "TeacherId" });
            DropIndex("dbo.ApplicationUsers", new[] { "Course_Id" });
            DropIndex("dbo.ApplicationUsers", new[] { "Exam_Id" });
            DropIndex("dbo.Answers", new[] { "questionId" });
            DropTable("dbo.Questions");
            DropTable("dbo.Grades");
            DropTable("dbo.Exams");
            DropTable("dbo.Courses");
            DropTable("dbo.ApplicationUsers");
            DropTable("dbo.Answers");
        }
    }
}
