using InventorySystem.DataAcces.Data;
using InventorySystem.DataAcces.Repository.IRepository;
using InventorySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.DataAcces.Repository
{
    public class BodegaRepository :Repository<Bodega>, IBodegaRepository
    {

        private readonly ApplicationDbContext _db;

        public BodegaRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public void Actualizar(Bodega bodega)
        {
            var bodegaDb = _db.Bodega.FirstOrDefault(b => b.Id == bodega.Id);
            if (bodegaDb != null) {
                bodegaDb.Nombre = bodega.Nombre;
                bodegaDb.Descripcion = bodega.Descripcion;
                bodegaDb.Estado = bodega.Estado;
                _db.SaveChanges();
            }

        }
    }
}
