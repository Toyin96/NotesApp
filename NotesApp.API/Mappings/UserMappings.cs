using NotesApp.Domain.Entities;
using NotesApp.Domain.ViewModels;

namespace NotesApp.API.Mappings;

public static class UserMappings
{
    public static UserResponse MapToResponse(this User user)
    {
        return new UserResponse()
        {
            Id = user.Id,
            FirstName = user.FirstName!,
            LastName = user.LastName!,
            Email = user.Email!,
            Notes = user.Notes.Select(NoteMappings.MapToNotesResponse),
        };
    }
}