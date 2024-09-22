using NotesApp.Domain.Entities;
using NotesApp.Domain.ViewModels;

namespace NotesApp.API.Mappings;

public static class NoteMappings
{
    public static NotesResponse MapToNotesResponse(this Note note)
    {
        return new NotesResponse()
        {
            Id = note.Id,
            Title = note.Title!,
            Description = note.Description!
        };
    }
}