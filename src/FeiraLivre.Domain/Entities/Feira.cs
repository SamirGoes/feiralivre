using FeiraLivre.Domain.Core.Entities;

namespace FeiraLivre.Domain.Entities
{
    public class Feira : Entity
    {
        public long Longitude { get; set; }

        public long Latitude { get; set; }

        public long SetCens { get; set; }

        public long Areap { get; set; }

        public int CodDist { get; set; }

        public string Distrito { get; set; }

        public int CodSubprefitura { get; set; }

        public string SubPrefeitura { get; set; }

        public string NomeFeira { get; set; }

        public string Registro { get; set; }
    }
}