namespace EstimationTrajet.Models
{
    public class CampagneViewModel
    {
        public string AdressEntreprise { get; set; }
        public string CleApi { get; set; }
        public IFormFile CSV { get; set; }
        public string FileUpload() {
            return "dz";
        }
    }
    
}
