using InventorySystem.DataAcces.Repository.IRepository;
using InventorySystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BodegaController : Controller
    {

        private readonly IUnidadTrabajo _unidadTrabajo;

        public BodegaController(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }
        
        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> Upsert(int? id) {

            Bodega bodega = new Bodega();
            if (id == null) {
                //Crear nueva Bodega
                bodega.Estado = true;
                return View(bodega);
            }
            bodega = await _unidadTrabajo.Bodega.Obtener(id.GetValueOrDefault());
            if (bodega == null) {
                return NotFound();
            }
            return View(bodega);
        }

        #region Api

        [HttpGet]
        public async Task<IActionResult> ObtenerTodos() {
            
            var todos = await _unidadTrabajo.Bodega.ObtenerTodos();
            return Json( new { data = todos });
        }

        #endregion
    }
}
