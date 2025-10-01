using System;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Journaling.Models;

namespace Journaling.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string mensaje  = string.Empty;
    public string Titulo { get; } = "SONGS JOURNAL";
    public string Saludo { get; } = "Agrega tus canciones favoritas";
    public string Lanzamiento { get; } = "Fecha de\nLanzamiento";
    
    [ObservableProperty] private Cancion cancion = new();
    
    [ObservableProperty] private bool anotaciones = false;
    
    [ObservableProperty] private bool modoCrear = true;
    
    [ObservableProperty] private bool modoEditar = false;
    
    [ObservableProperty] private Cancion cancionSeleccionada = new();
    
    [ObservableProperty] private ObservableCollection<Cancion> canciones = new();

    public MainWindowViewModel()
    {
        CargarCanciones();
    }

    private void CargarCanciones()
    {
        var cancion1 = new Cancion();
        cancion1.Titulo = "Panorama";
        cancion1.Artista = "IZ*ONE";
        cancion1.Album = "One-reeler / Act IV - EP";
        cancion1.Fecha = new DateTime(2020,12,07);
        cancion1.Nota = "8.2";
        cancion1.Caratula = "avares://Journaling/Assets/Images/panorama.jpeg";
        Canciones.Add(cancion1);
        
        var cancion2 = new Cancion();
        cancion2.Titulo = "bury a friend";
        cancion2.Artista = "Billie Eilish";
        cancion2.Album = "WHEN WE ALL FALL ASLEEP, WHERE DO WE GO?";
        cancion2.Fecha = new DateTime(2019,01,30);
        cancion2.Nota = "7";
        Canciones.Add(cancion2);
        
        var cancion3 = new Cancion();
        cancion3.Titulo = "Taste";
        cancion3.Artista = "Sabrina Carpenter";
        cancion3.Album = "Short n' Sweet (Deluxe)";
        cancion3.Fecha = new DateTime(2024,08,23);
        cancion3.Nota = "6.7";
        Canciones.Add(cancion3);
        
    }
    
    [RelayCommand]
    public void MostrarCancion()
    {
        if (string.IsNullOrWhiteSpace(Cancion.Titulo))
        {
            Mensaje = "Debes introducir el título";
        }
        else
        {
            Mensaje = String.Empty;
            var nuevaCancion = new Cancion
            {
                Titulo = Cancion.Titulo,
                Artista = Cancion.Artista,
                Album = Cancion.Album,
                Nota = Cancion.Nota,
                Fecha = Cancion.Fecha
            };
            Canciones.Add(nuevaCancion);
            Cancion = new Cancion();
            Anotaciones = false;
        }
    }

    [RelayCommand]
    public void MostrarAnotaciones()
    {
        Anotaciones = !Anotaciones;
    }
    
    [RelayCommand]
    public void CargarCancionSeleccionada()
    {
        Cancion = CancionSeleccionada;
        ModoCrear = false;
        ModoEditar = true;
    }

    [RelayCommand]
    public void EditarCancion()
    {
        Cancion = CancionSeleccionada;
    }

    [RelayCommand]
    public void CancelarEdicion()
    {
        Cancion = new Cancion();
        ModoEditar = false;
        ModoCrear = true;
    }
}