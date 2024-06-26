using Fiap.Web.LiveOn.Controllers;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.LiveOn.Models
{
    public class Trafego
    {
        private readonly Trafego trafego;

        public int AvenidaId { get; set; }
        public string Acidentes { get; set; }

        public int AcidentesId { get; set; }

        [NotMapped]
        public Acidentes acidentes { get; set; }
        public int Congestionamentos { get; set; }
        public string FarolQuebrado { get; set; }


        public Trafego()
        {
                
        }


        public Trafego(int TrafegoId, string Acidentes, int Congestionamentos, string FarolQuebrado)
        {
            AcidentesId = AcidentesId;
            Acidentes = Acidentes;
            Congestionamentos = Congestionamentos;
            FarolQuebrado = FarolQuebrado;
        }

        public Trafego(int TrafegoId, string Acidentes, Trafego trafego, int Congestionamentos, string FarolQuebrado, Trafego trafegos)
        {
            TrafegoId = TrafegoId;
            Acidentes = Acidentes;
            Congestionamentos = Congestionamentos;
            FarolQuebrado = FarolQuebrado;
      }
    }



    public class Acidentes
    {
    }
}
