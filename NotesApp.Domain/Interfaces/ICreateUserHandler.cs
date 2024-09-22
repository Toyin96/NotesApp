using NotesApp.Domain.ViewModels;

namespace NotesApp.Domain.Interfaces;

public interface ICreateUserHandler
{
    Task<UserResponse> HandleAsync(CreateUserRequest request);
}