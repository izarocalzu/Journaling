using System;

namespace Journaling.Models;

public class Cancion
{
    public string Titulo { get; set; } = string.Empty;
    public string Artista { get; set; } = string.Empty;
    public string Album { get; set; } = string.Empty;
    public string Nota { get; set; } = string.Empty;
    public DateTime Fecha { get; set; } = DateTime.Today;
    public string Caratula { get; set; } = string.Empty;
}