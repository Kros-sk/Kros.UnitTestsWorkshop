namespace Kros.UnitTestsWorkshop.EShop;

public class Client
{
    public Guid Id { get; set; }

    public string? TitleBeforeName { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Email { get; set; }

    public string? Address { get; set; }
}