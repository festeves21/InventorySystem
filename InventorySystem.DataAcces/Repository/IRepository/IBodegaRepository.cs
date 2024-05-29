using InventorySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.DataAcces.Repository.IRepository
{
    public interface IBodegaRepository : IRepository<Bodega>
    {

        void Actualizar(Bodega bodega);
    }
}
