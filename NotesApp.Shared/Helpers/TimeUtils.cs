namespace NotesApp.Shared.Helpers;

public static class TimeUtils
{
    public static DateTime NigerianTimeNow => DateTime.UtcNow.AddHours(1);
}