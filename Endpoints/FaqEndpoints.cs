using Microsoft.EntityFrameworkCore;
using Shiko.FaqService.Data;
using Shiko.FaqService.Models;

namespace Shiko.FaqService.Endpoints;

public static class FaqEndpoints
{
    public static void MapFaqEndpoints(this WebApplication app)
    {
        app.MapGet("/api/faqs/course/{courseId}", async (string courseId, AppDbContext db) =>
        {
            var faqs = await db.FaqItems
                .Where(faq => faq.CourseId == courseId)
                .OrderBy(faq => faq.SortOrder)
                .ToListAsync();

            return Results.Ok(faqs);
        });

        app.MapGet("/api/faqs/{id:guid}", async (Guid id, AppDbContext db) =>
        {
            var faq = await db.FaqItems.FindAsync(id);

            return faq is null
                ? Results.NotFound()
                : Results.Ok(faq);
        });

        app.MapPost("/api/faqs", async (FaqItem faq, AppDbContext db) =>
        {
            faq.Id = Guid.NewGuid();
            faq.CreatedAt = DateTime.UtcNow;

            db.FaqItems.Add(faq);
            await db.SaveChangesAsync();

            return Results.Created($"/api/faqs/{faq.Id}", faq);
        });

        app.MapPut("/api/faqs/{id:guid}", async (Guid id, FaqItem updatedFaq, AppDbContext db) =>
        {
            var faq = await db.FaqItems.FindAsync(id);

            if (faq is null)
            {
                return Results.NotFound();
            }

            faq.CourseId = updatedFaq.CourseId;
            faq.Question = updatedFaq.Question;
            faq.Answer = updatedFaq.Answer;
            faq.SortOrder = updatedFaq.SortOrder;
            faq.UpdatedAt = DateTime.UtcNow;

            await db.SaveChangesAsync();

            return Results.Ok(faq);
        });

        app.MapDelete("/api/faqs/{id:guid}", async (Guid id, AppDbContext db) =>
        {
            var faq = await db.FaqItems.FindAsync(id);

            if (faq is null)
            {
                return Results.NotFound();
            }

            db.FaqItems.Remove(faq);
            await db.SaveChangesAsync();

            return Results.NoContent();
        });
    }
}