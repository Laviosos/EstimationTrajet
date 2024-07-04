namespace EstimationTrajet.Models.Dev
{
    public interface Interface
    {
    }

    public class Trajet
    {
        public int Id { get; set; }
        public string AdresseEmploye { get; set; }
        public string AdressEntreprise { get; set;}
        public string CleApi { get; set; }
        public int NombreAllerRetour { get; set; }
        public string MoyenTransport { get; set; }

    }
}
