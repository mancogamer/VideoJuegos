using Microsoft.AspNetCore.Mvc;
using PracticaVideojuegos.Context;
using PracticaVideojuegos.Models;


namespace PracticaVideojuegos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Video_controller : ControllerBase
    {

        private readonly ILogger<Video_controller> _logger;
        private readonly Aplicacion_contexto _aplicacionContexto;
        public Video_controller(
            ILogger<Video_controller> logger,
            Aplicacion_contexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Videojuego videojuego)
        {
            _aplicacionContexto.videojuegos.Add(videojuego);
            _aplicacionContexto.SaveChanges();
            return Ok(videojuego);
        }

        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacionContexto.videojuegos.ToList());

        }
        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] Videojuego videojuego)
        {
            _aplicacionContexto.videojuegos.Update(videojuego);
            _aplicacionContexto.SaveChanges();
            return Ok(videojuego);
        }
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int IDvideojuego)
        {
            _aplicacionContexto.videojuegos.Remove(
                _aplicacionContexto.videojuegos.ToList()
                .Where(x => x.id_videoJuego == IDvideojuego)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(IDvideojuego);
        }
    }
}