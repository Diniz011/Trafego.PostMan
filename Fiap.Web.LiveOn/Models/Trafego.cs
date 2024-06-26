using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.LiveOn.Models
{

    public class Trafegos
    {
        public int AvenidaId { get; set; }
        public string Acidentes { get; set; }
        public string Congestionamentos { get; set; }
        public int FarolQuebrado { get; set; }


        public Trafegos()
        {
                
        }

        public Trafegos(int avenidaId, string congestionamentos, int farolQuebrado)
        {
            AvenidaId = avenidaId;
            Congestionamentos = congestionamentos;
            FarolQuebrado = farolQuebrado;
        }
    }
}
