using Shiko.FaqService.Models;

namespace Shiko.FaqService.Data;

public static class FakeFaqData
{
    public static List<FaqItem> Faqs { get; } =
    [
        new FaqItem
        {
            Id = Guid.NewGuid(),
            CourseId = "course-1",
            Question = "What is included in this course?",
            Answer = "This course includes video lessons, assignments, quizzes and downloadable resources.",
            SortOrder = 1
        },
        new FaqItem
        {
            Id = Guid.NewGuid(),
            CourseId = "course-1",
            Question = "Do I get lifetime access?",
            Answer = "Yes, once you enroll you can access the course material at any time.",
            SortOrder = 2
        },
        new FaqItem
        {
            Id = Guid.NewGuid(),
            CourseId = "course-1",
            Question = "Is there a certificate after completion?",
            Answer = "Yes, you will receive a certificate when you complete all required course sections.",
            SortOrder = 3
        }
    ];
}