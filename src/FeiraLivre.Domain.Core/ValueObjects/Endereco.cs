namespace FeiraLivre.Domain.Core.ValueObjects
{
    public class Endereco : ValueObject<Endereco>
    {
        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string Referencia { get; set; }

        protected override bool EqualsCore(Endereco other)
        {
            throw new NotImplementedException();
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }
    }
}