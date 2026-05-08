using Microsoft.AspNetCore.Mvc;

public class CatalogoController : Controller
{
    public IActionResult Index()
    {
        // Simulamos una lista de videojuegos
        var juegos = new List<dynamic>
        {
            new { Id = 1, Titulo = "Elden Ring", Genero = "RPG", Dev = "FromSoftware", Desc = "Un mundo abierto épico lleno de desafíos.", Img = "https://image.api.playstation.com/vulcan/ap/rnd/202110/2000/phvVT0kkPy7uoF9Q6K5y1YF.png" },
            new { Id = 2, Titulo = "Cyberpunk 2077", Genero = "FPS/RPG", Dev = "CD Projekt Red", Desc = "Explora la megalópolis de Night City.", Img = "https://image.api.playstation.com/vulcan/ap/rnd/202311/2813/102c9a9307d10e5d0f622955f2690f05.png" },
            new { Id = 3, Titulo = "Halo Infinite", Genero = "Shooter", Dev = "343 Industries", Desc = "El regreso legendario del Jefe Maestro.", Img = "https://cdn1.epicgames.com/salesEvent/salesEvent/EGS_HaloInfinite_343Industries_S2_1200x1600-0389656157e0344400f913d804245592" },
            new { Id = 4, Titulo = "God of War Ragnarök", Genero = "Acción", Dev = "Santa Monica Studio", Desc = "Kratos y Atreus en el fin de los tiempos.", Img = "https://image.api.playstation.com/vulcan/ap/rnd/202207/1210/4E9iUIPp4i9sJ976I96sS6.png" },
            // Agrega estos después del juego Id = 4 en tu lista
new {
    Id = 5,
    Titulo = "Spider-Man 2",
    Genero = "Acción",
    Dev = "Insomniac Games",
    Desc = "Balanceate por Nueva York como Peter y Miles.",
    Img = "https://image.api.playstation.com/vulcan/ap/rnd/202306/0800/6045524317f2c69438258e72ba755e718b56d3c06e236599.png"
},
new {
    Id = 6,
    Titulo = "Starfield",
    Genero = "RPG",
    Dev = "Bethesda",
    Desc = "Explora las estrellas en este RPG espacial épico.",
    Img = "https://image.api.playstation.com/vulcan/ap/rnd/202306/1219/60caf0072b781e62c16196a604218f2f4e9124a91924844f.png"
},
new {
    Id = 7,
    Titulo = "Resident Evil 4",
    Genero = "Horror",
    Dev = "Capcom",
    Desc = "Sobrevive a la pesadilla en este remake legendario.",
    Img = "https://image.api.playstation.com/vulcan/ap/rnd/202210/0712/0Y9796vBNo99N9unl9O03Ie7.png"
},
new {
    Id = 8,
    Titulo = "Doom Eternal",
    Genero = "Shooter",
    Dev = "id Software",
    Desc = "Arrasa con las hordas del infierno sin piedad.",
    Img = "https://image.api.playstation.com/vulcan/ap/rnd/202010/0114/7IPrE6fW2jR9UvXhG6kU7D8m.png"
}
        };

        return View(juegos);
    }

    public IActionResult Detalle(int id)
    {
        // Aquí es donde mostrarías la info detallada del juego por su ID
        return View();
    }
}