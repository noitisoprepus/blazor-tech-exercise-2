namespace BlazorTestProject.Services;

public interface IEmailService
{
    Task<bool> ExistsAsync(string email);
}