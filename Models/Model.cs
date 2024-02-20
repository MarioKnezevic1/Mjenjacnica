using System.ComponentModel.DataAnnotations;
namespace Mjenjačnica.Models
{
    public class Model
    {
            public int Id { get; set; }
            
            public string KonvertirajU { get; set; }
            public string KonvertirajIz { get; set; }
           
            public double Tecaj {  get; set; }
    }
}
