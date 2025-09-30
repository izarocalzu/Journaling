using CommunityToolkit.Mvvm.ComponentModel;
using Journaling.Models;

namespace Journaling.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Titulo { get; } = "SONGS JOURNAL";
    public string Saludo { get; } = "¡Añade tus canciones favoritas!";
    
    [ObservableProperty] private Cancion cancion = new();
}