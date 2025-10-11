using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Journaling.Models;

public partial class Cancion : ObservableObject
{
    [ObservableProperty]
    private string titulo = string.Empty;

    [ObservableProperty]
    private string artista = string.Empty;

    [ObservableProperty]
    private string album = string.Empty;

    [ObservableProperty]
    private double calificacion;

    [ObservableProperty]
    private DateTime fecha = DateTime.Today;

    [ObservableProperty]
    private string anotaciones = string.Empty;

    //[ObservableProperty]
    //private string caratula = string.Empty;
}