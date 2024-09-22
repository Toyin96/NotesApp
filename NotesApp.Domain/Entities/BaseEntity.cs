using NotesApp.Shared.Helpers;

namespace NotesApp.Domain.Entities;

public class BaseEntity<T>(T id)
{
    public T Id { get; set; } = id!;
    public DateTime CreatedAt { get; init; } = TimeUtils.NigerianTimeNow;
    public DateTime UpdatedAt { get; protected set; } = TimeUtils.NigerianTimeNow;
}