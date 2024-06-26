using System.Collections.ObjectModel;

namespace Fiap.Web.LiveOn.Models
{
    public class Teste
    {

        public IList<Trafego> GetData()
        {
            var colletion = new LinkedList<Trafego>();

            return new List<Trafego>(colletion);
        }


    }
}
