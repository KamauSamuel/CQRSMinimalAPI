using BooksMinimalWebAPI.Entities;
using BooksMinimalWebAPI.Repositories;

namespace BooksMinimalWebAPI.Endpoints
{
    public static class Books
    {
        public static void AddBooksEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("Vitabu", (BooksReadRepositorycs repository) =>
            {
                return Results.Ok(repository.Get());
            });

            app.MapGet("Vitabu/{id}", (Guid id, BooksReadRepositorycs repository) =>
            {
                return Results.Ok(repository.GetById(id));
            });

            app.MapPost("Vitabu", (Book book, BooksWriteRepository repository) =>
            {
                repository.Add(book);
                return Results.Ok();
            });

            app.MapPut("Vitabu", (Book book, BooksWriteRepository repository) =>
            {
                repository.Update(book);
                return Results.NoContent();
            });

            app.MapDelete("Vitabu/{id}", (Guid id, BooksWriteRepository repository) =>
            {
                repository.Delete(id);
                return Results.NoContent();
            });
        }
    }
}
