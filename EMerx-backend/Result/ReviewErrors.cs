using MongoDB.Bson;

namespace EMerx_backend.Result;

public static class ReviewErrors
{
    public static Error NotFound(ObjectId id) => new(StatusCodes.NotFound, $"Review with id {id} not found.");
}