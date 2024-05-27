using InventorySystem.DataAcces.Data;
using InventorySystem.DataAcces.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.DataAcces.Repository
{
    public class UnidadTrabajo : IUnidadTrabajo
    {
        private readonly ApplicationDbContext _db;
        public IBodegaRepository Bodega { get; set; }

        public UnidadTrabajo(ApplicationDbContext db)
        {
            _db = db;
        }

        public IBodegaRepository Bodega => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task Guardar()
        {
            throw new NotImplementedException();
        }
    }
}
