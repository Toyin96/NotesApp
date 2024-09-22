using System.ComponentModel.DataAnnotations.Schema;

namespace NotesApp.Domain.Entities;

public class Note() : BaseEntity<Guid>(Guid.NewGuid())
{
    public string? Title { get; private set; }
    public string? Description { get; private set; }
    public User? User { get; set; }
    [ForeignKey("User")]
    public Guid? UserId { get; set; }

    public Note CreateNote(string title, string description)
    {
        Title = title;  
        Description = description;
        
        return this;
    }
}