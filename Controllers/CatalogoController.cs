using Microsoft.AspNetCore.Mvc;
using Catalogo.Models;

namespace Catalogo.Controllers
{
    public class CatalogoController : Controller
    {
        private static List<Item> _items = new()
        {
            new Item {
            Id = 1,
            Titulo = "Devil May Cry",
            Genero = "Hack and Slash",
            Ano = 2001,
            Consola = "PlayStation 2",
            Descripcion = "Videojuego que trata de un cazador..."
            },
            /* Continua código en la siguiente slide */
            new Item
            {
                Id = 2,
                Titulo = "Castlevania: Symphony of the Night",
                Genero = "Metroidvania",
                Ano = 1997,
                Consola = "PlayStation 2",
                Descripcion = "Videojuego que trata de un cazador..."
            },
            new Item
            {
                Id = 2,
                Titulo = "League of Legends",
                Genero = "MOBA",
                Ano = 2009,
                Consola = "PC",
                Descripcion = "Videojuego que se trata de un enfrentamiento de 5 vs 5..."
            },
            new Item
            {
                Id = 2,
                Titulo = "Minecraft",
                Genero = "Sandbox",
                Ano = 2009,
                Consola = "Multiplataforma",
                Descripcion = "Videojuego que trata de un munod cuadrado donde tu imaginacion es tu limite"
            },
            new Item
            {
                Id = 2,
                Titulo = "The Legend of Zelda: Breath of the Wild",
                Genero = "Accion-Aventura",
                Ano = 2017,
                Consola = "Nintendo Switch",
                Descripcion = "Videojuego que trata de un heroe que tiene que rescatar a una princesa de un ser malvado"
            },

    };

        // Lista — con filtro opcional por género
        public IActionResult Index(string? genero)
        {
            var resultado = string.IsNullOrEmpty(genero)
            ? _items
            : _items.Where(i => i.Genero == genero).ToList();
            ViewBag.Generos = _items.Select(i => i.Genero).Distinct().ToList();
            ViewBag.GeneroActual = genero;
            return View(resultado);
        }
        // Detalle
        public IActionResult Detalle(int id)
        {
            var item = _items.FirstOrDefault(i => i.Id == id);
            return item == null ? NotFound() : View(item);
        }

        // Formulario — GET
        public IActionResult Agregar()
        {
            return View();
        }

        // Formulario — POST
        [HttpPost]
        public IActionResult Agregar(Item item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);

            return RedirectToAction("Index");
        }
    }
}