using System.ComponentModel.DataAnnotations;
namespace Mjenjačnica.Models
{
    public class Evidencija
    {
        public int Id { get; set; }

        public string KonvertirajU { get; set; }
        public string KonvertirajIz { get; set; }
        public double Tecaj { get; set; }
        public double IznosU { get; set; }
        public double IznosIz { get; set; }
        public DateTime Vrijeme { get; set; }
    }
}
