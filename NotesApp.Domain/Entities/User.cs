using NotesApp.Domain.ViewModels;

namespace NotesApp.Domain.Entities;

public class User() : BaseEntity<Guid>(Guid.NewGuid())
{
    public string? FirstName { get; private set; }
    public string? LastName { get; private set; }
    public string? Email { get; private set; }
    public string? HashedPassword { get; private set; }
    private List<Note> _notes = [];
    public IReadOnlyCollection<Note> Notes => _notes;

    public User Create(CreateUserRequest request)
    {
        FirstName = request.FirstName;
        LastName = request.LastName;
        Email = request.Email;

        return this;
    }
    public void AddNote(Note note)
    {
        _notes.Add(note);
    }

    public void SetHashedPassword(string hashedPassword)
    {
        HashedPassword = hashedPassword;
    }
    
}   