using DAL;
using DAL.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Poyecto_Gestor_Biblioteca_Web_Los_Rapidos.Controllers
{
    public class ControladorAdministrar : Controller
    {
        private readonly GestorBibliotecaDbContext  _context;

        public ControladorAdministrar(GestorBibliotecaDbContext context)
        {
            _context = context;
        }
        public IActionResult ListaUsuarios()
        {
            var usuarios = _context.Usuarios.ToList();
            return View("~/Views/ListaUsuarios.cshtml",usuarios);
        }

        public ActionResult Modificar(int userId)
        {
            // Aquí deberías obtener el usuario con el ID proporcionado desde tu base de datos u otro origen de datos
            Usuarios usuario = ObtenerUsuarioPorId(userId);

            return View("~/Views/ModificarUsuario.cshtml",usuario);
        }

        private Usuarios ObtenerUsuarioPorId(int userId)
        {
            // Implementación simulada, deberías reemplazarla con la lógica real
            return _context.Usuarios.Find(userId);
        }

        [HttpPost]
        public IActionResult EditarUsuario(Usuarios usuario)
        {
            DateTime dateTime = DateTime.Now;
            usuario.fch_alta_usuario = dateTime.ToUniversalTime();
            // Aquí puedes utilizar el objeto 'usuario' recibido desde la vista
            if (ModelState.IsValid)
            {
                // Lógica para actualizar el usuario en la base de datos
                _context.Entry(usuario).State = EntityState.Modified;
                _context.SaveChanges();

                return RedirectToAction("ListaUsuarios");
            }

            return View("~/Views/Home/Login.cshtml",usuario);
        }

    }
}

