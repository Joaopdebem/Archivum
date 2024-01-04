using Dapper.Contrib.Extensions;

namespace Archivum.Models;

[Table("[Collection]")]

public class Collection
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public int TypeId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int Chapter { get; set; }
    public int Rating { get; set; }
    public char IsFinished { get; set; }
    public char IsFavorite { get; set; }
    public string? Slug { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
}