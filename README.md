# Catálogo de Videojuegos - El Nexo

Este proyecto es una aplicación web interactiva desarrollada en **ASP.NET Core MVC** que permite visualizar una colección de videojuegos con un diseño moderno, futurista y responsivo.

## Características

- **Diseño Moderno:** Interfaz con estética "Dark Mode" y acentos neón (cian y morado).
- **Catálogo Dinámico:** Visualización de tarjetas de juegos con imágenes de portada oficiales.
- **Arquitectura Limpia:** Implementación siguiendo el patrón Modelo-Vista-Controlador (MVC).
- **Responsive:** Adaptable a diferentes tamaños de pantalla gracias a Bootstrap 5.
- **Interactividad:** Efectos visuales de "hover" y transiciones fluidas.

## Tecnologías Utilizadas

- **Backend:** C# / .NET
- **Frontend:** HTML5, CSS3 (Razor Pages)
- **Framework CSS:** Bootstrap 5
- **Tipografía:** Orbitron (Google Fonts)
- **Herramientas:** Visual Studio 2022, Git

## Clausula de IA

Yo, Dylan Vazquez Sorianno, declaro que SI he utilizado herramientas de Inteligencia Artificial para la elaboración de este trabajo académico. Afirmo que el unic uso de la IA fue para motivos de personalizacion de mi oagina creada.

## Estructura del Proyecto

```text
/Catalogo
├── Controllers/
│   └── CatalogoController.cs    # Lógica de datos
├── Views/
│   ├── Catalogo/
│   │   └── Index.cshtml         # Vista del catálogo
│   └── Shared/
│       └── _Layout.cshtml       # Estructura base
├── wwwroot/

│   └── css/
│       └── site.css             # Estilos personalizados
└── Program.cs                   # Configuración principal
