using System.Text.RegularExpressions;

namespace Subscription.Domain.ValueObjects;

public sealed class Email
{
    public string? Endereco { get; private set; }

    //Construtor reservado para o ValueObject
    protected Email() { }

    //Construtor público para criar uma instância de Email
    public Email(string endereco)
    {
        if (string.IsNullOrWhiteSpace(endereco))
            throw new ArgumentNullException("Email é obrigatório.");

        if (!IsValid(endereco))
            throw new ArgumentNullException("Email inválido.");

        Endereco = endereco.ToLower();
    }

    private bool IsValid(string email)
    {
        var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        return regex.IsMatch(email);
    }

    public override string ToString() => Endereco ?? string.Empty;
}