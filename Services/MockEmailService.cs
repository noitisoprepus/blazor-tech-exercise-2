namespace BlazorTestProject.Services;

public class MockEmailService : IEmailService
{
    private static readonly List<string> ExistingEmails =
    [
        "user@test.com",
        "demo@example.com"
    ];
    
    public async Task<bool> ExistsAsync(string email)
    {
        await Task.Delay(200);
        return ExistingEmails.Contains(email.ToLower());
    }
}