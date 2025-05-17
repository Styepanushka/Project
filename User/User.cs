namespace Project.User;

public class User
{
    public string Name { get; }
    public string Password { get; }

    public User(string name, string password)
    {
        Name = name;
        Password = password;
    }

    public override bool Equals(object obj)
    {
        if (obj is not User other)
            return false;

        return string.Equals(Name, other.Name, StringComparison.OrdinalIgnoreCase) &&
               Password == other.Password;
    }

    public override int GetHashCode()
    {
        // Используем хэш-код с учётом регистра имени и пароля
        return HashCode.Combine(Name.ToLowerInvariant(), Password);
    }

    public override string ToString()
    {
        return $"{Name};{Password}";
    }
}
