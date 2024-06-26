using Fiap.Web.LiveOn.Models;

namespace Fiap.Web.LiveOn.Repository
{
    public class AcidentesRepository : ITrafegoRepository
    {

        public IList<Trafego> FindAll()
        {
            return new List<Trafego>();   
        }

    }
}
