using Microsoft.AspNetCore.Mvc;
using PracticaVideojuegos.Context;
using PracticaVideojuegos.Models;


namespace PracticaVideojuegos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Usuario_controller : ControllerBase
    {

        private readonly ILogger<Usuario_controller> _logger;
        private readonly Aplicacion_contexto _aplicacionContexto;
        public Usuario_controller(
            ILogger<Usuario_controller> logger,
            Aplicacion_contexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Usuario usuario)
        {
            _aplicacionContexto.usuarios.Add(usuario);
            _aplicacionContexto.SaveChanges();
            return Ok(usuario);
        }

        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacionContexto.usuarios.ToList());

        }
        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] Usuario usuario)
        {
            _aplicacionContexto.usuarios.Update(usuario);
            _aplicacionContexto.SaveChanges();
            return Ok(usuario);
        }
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int IDusuario)
        {
            _aplicacionContexto.usuarios.Remove(
                _aplicacionContexto.usuarios.ToList()
                .Where(x => x.id_usuario == IDusuario)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(IDusuario);
        }
    }
}