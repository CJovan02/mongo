using MongoDB.Bson;

namespace EMerx.Entities;

public class Review : BaseEntity
{
    public ObjectId UserId { get; set; }
    public ObjectId ProductId { get; set; }
    public int Rating { get; set; }
    public string? Description { get; set; }
}