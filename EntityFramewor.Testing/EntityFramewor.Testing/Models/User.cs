namespace EntityFramewor.Testing.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public override string ToString() => $"Id: {Id} Name: {Name} Surname: {Surname}";
}
