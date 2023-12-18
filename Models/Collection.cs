namespace Archivum.Models;

public class Collection
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public int TypeId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int Chapter { get; set; }
    public int Rating { get; set; }
    public bool IsFinished { get; set; }
    public bool IsFavorite { get; set; }
    public string? Slug { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
}