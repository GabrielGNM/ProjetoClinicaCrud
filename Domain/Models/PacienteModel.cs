using System.Text.Json.Serialization;

namespace Domain.Models;

public sealed record PacienteModel
{
    [JsonPropertyName("nome")]
    [JsonRequired]
    public string? Nome { get; set; }

    [JsonPropertyName("idade")]
    [JsonRequired]
    public int Idade { get; set; }

    [JsonPropertyName("peso")]
    public decimal? Peso { get; set; }

    [JsonPropertyName("altura")]
    public int? Altura { get; set; }

    [JsonPropertyName("dataDeNascimento")]
    [JsonRequired]
    public DateTime DatadeNascimento { get; set; }

    [JsonPropertyName("telefone")]
    public long? Telefone { get; set; }

    [JsonPropertyName("sexo")]
    [JsonRequired]
    public string? Sexo { get; set; }

    [JsonPropertyName("responsavelLegal")]
    public string? ResponsavelLegal { get; set; }

    [JsonPropertyName("endereco")]
    public string? Endereco { get; set; }

}
