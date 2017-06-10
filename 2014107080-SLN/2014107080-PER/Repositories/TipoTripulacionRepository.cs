using _2014107080_ENT;
using _2014107080_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014107080_PER.Repositories
{
    public class TipoTripulacionRepository : Repository<TipoTripulacion>, ITipoTripulacionRepository
    {
        public TipoTripulacionRepository(DbContext context) : base(context)
        {
        }
    }
}
