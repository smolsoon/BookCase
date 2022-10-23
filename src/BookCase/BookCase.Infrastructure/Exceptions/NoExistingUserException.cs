namespace BookCase.Infrastructure.Exceptions;

public class NoExistingUserException : Exception
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public NoExistingUserException(Guid id) : base($"User with ID: '{id}' was not found.")
    {
        Id = id;
    }

    public NoExistingUserException(string email): base($"User with email: '{email}' was not found.")
    {
        Email = email;
    }
}