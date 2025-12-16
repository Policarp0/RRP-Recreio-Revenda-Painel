namespace Domain
{
    public class Servidor
    {
        public required string Nome { get; set; }
        public required string Endereco { get; set; }

        public Servidor(string nome, string endereco) 
        {
            Nome = nome;
            Endereco = endereco;
        }
      

    }
}
