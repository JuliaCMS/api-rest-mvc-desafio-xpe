namespace mvc_rest_api.Models.Entities
{
    public class Cliente
    {
        public  int Id { get; set; }
        public required string Nome { get; set; }
        public  string? Telefone { get; set; }
        public string? Email { get; set; }
    }
}
