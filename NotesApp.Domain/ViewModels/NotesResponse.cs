namespace NotesApp.Domain.ViewModels;

public class NotesResponse
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
}