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
            // Sketch for Designer
            new()
            {
                Id = Guid.NewGuid(),
                CourseId = "0be85b35-ba14-417b-ba04-2a1c0bd0d509",
                Question = "What is included in this course?",
                Answer = "This course includes video lessons, assignments, quizzes and downloadable resources.",
                SortOrder = 1,
                CreatedAt = DateTime.UtcNow
            },
            new()
            {
                Id = Guid.NewGuid(),
                CourseId = "0be85b35-ba14-417b-ba04-2a1c0bd0d509",
                Question = "Do I get lifetime access?",
                Answer = "Yes, once you enroll you can access the course material at any time.",
                SortOrder = 2,
                CreatedAt = DateTime.UtcNow
            },
            new()
            {
                Id = Guid.NewGuid(),
                CourseId = "0be85b35-ba14-417b-ba04-2a1c0bd0d509",
                Question = "Is there a certificate after completion?",
                Answer = "Yes, you will receive a certificate when you complete all required course sections.",
                SortOrder = 3,
                CreatedAt = DateTime.UtcNow
            },
            // Artificial Intelligence
            new()
            {
                Id = Guid.NewGuid(),
                CourseId = "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa",
                Question = "What is included in this course?",
                Answer = "This course includes video lessons, assignments, quizzes and downloadable resources.",
                SortOrder = 1,
                CreatedAt = DateTime.UtcNow
            },
            new()
            {
                Id = Guid.NewGuid(),
                CourseId = "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa",
                Question = "Do I get lifetime access?",
                Answer = "Yes, once you enroll you can access the course material at any time.",
                SortOrder = 2,
                CreatedAt = DateTime.UtcNow
            },
            new()
            {
                Id = Guid.NewGuid(),
                CourseId = "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa",
                Question = "Is there a certificate after completion?",
                Answer = "Yes, you will receive a certificate when you complete all required course sections.",
                SortOrder = 3,
                CreatedAt = DateTime.UtcNow
            },
            // Full stack Developer
            new()
            {
                Id = Guid.NewGuid(),
                CourseId = "7a875d05-b4fb-4b27-bc50-b776aaef14d4",
                Question = "What is included in this course?",
                Answer = "This course includes video lessons, assignments, quizzes and downloadable resources.",
                SortOrder = 1,
                CreatedAt = DateTime.UtcNow
            },
            new()
            {
                Id = Guid.NewGuid(),
                CourseId = "7a875d05-b4fb-4b27-bc50-b776aaef14d4",
                Question = "Do I get lifetime access?",
                Answer = "Yes, once you enroll you can access the course material at any time.",
                SortOrder = 2,
                CreatedAt = DateTime.UtcNow
            },
            new()
            {
                Id = Guid.NewGuid(),
                CourseId = "7a875d05-b4fb-4b27-bc50-b776aaef14d4",
                Question = "Is there a certificate after completion?",
                Answer = "Yes, you will receive a certificate when you complete all required course sections.",
                SortOrder = 3,
                CreatedAt = DateTime.UtcNow
            },
            // Digital Marketing
            new()
            {
                Id = Guid.NewGuid(),
                CourseId = "bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb",
                Question = "What is included in this course?",
                Answer = "This course includes video lessons, assignments, quizzes and downloadable resources.",
                SortOrder = 1,
                CreatedAt = DateTime.UtcNow
            },
            new()
            {
                Id = Guid.NewGuid(),
                CourseId = "bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb",
                Question = "Do I get lifetime access?",
                Answer = "Yes, once you enroll you can access the course material at any time.",
                SortOrder = 2,
                CreatedAt = DateTime.UtcNow
            },
            new()
            {
                Id = Guid.NewGuid(),
                CourseId = "bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb",
                Question = "Is there a certificate after completion?",
                Answer = "Yes, you will receive a certificate when you complete all required course sections.",
                SortOrder = 3,
                CreatedAt = DateTime.UtcNow
            },
            // Data Science & Analytics
            new()
            {
                Id = Guid.NewGuid(),
                CourseId = "882d1c96-b77f-46cc-994c-d12bbd16a0de",
                Question = "What is included in this course?",
                Answer = "This course includes video lessons, assignments, quizzes and downloadable resources.",
                SortOrder = 1,
                CreatedAt = DateTime.UtcNow
            },
            new()
            {
                Id = Guid.NewGuid(),
                CourseId = "882d1c96-b77f-46cc-994c-d12bbd16a0de",
                Question = "Do I get lifetime access?",
                Answer = "Yes, once you enroll you can access the course material at any time.",
                SortOrder = 2,
                CreatedAt = DateTime.UtcNow
            },
            new()
            {
                Id = Guid.NewGuid(),
                CourseId = "882d1c96-b77f-46cc-994c-d12bbd16a0de",
                Question = "Is there a certificate after completion?",
                Answer = "Yes, you will receive a certificate when you complete all required course sections.",
                SortOrder = 3,
                CreatedAt = DateTime.UtcNow
            },
            // UI/UX Design for Beginner
            new()
            {
                Id = Guid.NewGuid(),
                CourseId = "d9da7d05-0605-4ef3-8fc2-ec0a1ff90cc1",
                Question = "What is included in this course?",
                Answer = "This course includes video lessons, assignments, quizzes and downloadable resources.",
                SortOrder = 1,
                CreatedAt = DateTime.UtcNow
            },
            new()
            {
                Id = Guid.NewGuid(),
                CourseId = "d9da7d05-0605-4ef3-8fc2-ec0a1ff90cc1",
                Question = "Do I get lifetime access?",
                Answer = "Yes, once you enroll you can access the course material at any time.",
                SortOrder = 2,
                CreatedAt = DateTime.UtcNow
            },
            new()
            {
                Id = Guid.NewGuid(),
                CourseId = "d9da7d05-0605-4ef3-8fc2-ec0a1ff90cc1",
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