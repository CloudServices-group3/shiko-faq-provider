using Shiko.FaqService.Models;

namespace Shiko.FaqService.Data;

public static class DbSeeder
{
    public static async Task SeedAsync(AppDbContext db)
    {
        if (db.FaqItems.Any())
        {
            return;
        }

        var faqs = new List<FaqItem>
        {
            new()
            {
                Id = Guid.NewGuid(),
                CourseId = "course-1",
                Question = "What is included in this course?",
                Answer = "This course includes video lessons, assignments, quizzes and downloadable resources.",
                SortOrder = 1,
                CreatedAt = DateTime.UtcNow
            },
            new()
            {
                Id = Guid.NewGuid(),
                CourseId = "course-1",
                Question = "Do I get lifetime access?",
                Answer = "Yes, once you enroll you can access the course material at any time.",
                SortOrder = 2,
                CreatedAt = DateTime.UtcNow
            },
            new()
            {
                Id = Guid.NewGuid(),
                CourseId = "course-1",
                Question = "Is there a certificate after completion?",
                Answer = "Yes, you will receive a certificate when you complete all required course sections.",
                SortOrder = 3,
                CreatedAt = DateTime.UtcNow
            }
        };

        db.FaqItems.AddRange(faqs);
        await db.SaveChangesAsync();
    }
}