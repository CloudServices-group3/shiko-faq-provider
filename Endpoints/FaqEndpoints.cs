using Shiko.FaqService.Data;
using Shiko.FaqService.Models;

namespace Shiko.FaqService.Endpoints;

public static class FaqEndpoints
{
    public static void MapFaqEndpoints(this WebApplication app)
    {
        app.MapGet("/api/faqs/course/{courseId}", (string courseId) =>
        {
            var faqs = FakeFaqData.Faqs
                .Where(faq => faq.CourseId == courseId)
                .OrderBy(faq => faq.SortOrder)
                .ToList();

            return Results.Ok(faqs);
        });

        app.MapGet("/api/faqs/{id:guid}", (Guid id) =>
        {
            var faq = FakeFaqData.Faqs.FirstOrDefault(faq => faq.Id == id);

            return faq is null
                ? Results.NotFound()
                : Results.Ok(faq);
        });

        app.MapPost("/api/faqs", (FaqItem faq) =>
        {
            faq.Id = Guid.NewGuid();
            faq.CreatedAt = DateTime.UtcNow;

            FakeFaqData.Faqs.Add(faq);

            return Results.Created($"/api/faqs/{faq.Id}", faq);
        });

        app.MapPut("/api/faqs/{id:guid}", (Guid id, FaqItem updatedFaq) =>
        {
            var faq = FakeFaqData.Faqs.FirstOrDefault(faq => faq.Id == id);

            if (faq is null)
            {
                return Results.NotFound();
            }

            faq.CourseId = updatedFaq.CourseId;
            faq.Question = updatedFaq.Question;
            faq.Answer = updatedFaq.Answer;
            faq.SortOrder = updatedFaq.SortOrder;
            faq.UpdatedAt = DateTime.UtcNow;

            return Results.Ok(faq);
        });

        app.MapDelete("/api/faqs/{id:guid}", (Guid id) =>
        {
            var faq = FakeFaqData.Faqs.FirstOrDefault(faq => faq.Id == id);

            if (faq is null)
            {
                return Results.NotFound();
            }

            FakeFaqData.Faqs.Remove(faq);

            return Results.NoContent();
        });
    }
}