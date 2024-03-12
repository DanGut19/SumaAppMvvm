using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SumaAppMvvm.ViewModels
{
    internal partial class MainPageViewModels : ObservableObject
    {
        [ObservableProperty]
        private double _numero1;

        [ObservableProperty]
        private double _numero2;

        [ObservableProperty]
        private double _resultado;

        [RelayCommand]
        private void Calcular() 
        {
            try
            {
                Suma r = new Suma();
                r.Numero1 = Numero1;
                r.Numero2 = Numero2;

                Resultado = r.Calcular();
            }
            catch (Exception ex) {
                MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert("ERROR", ex.Message, "Aceptar"));
                ////DisplayAlert("Error", ex.Message, "Aceptar");
            }
        }

        [RelayCommand]
        private void Limpiar()
        {
            Numero1 = 0;
            Numero2 = 0;
            Resultado = 0;
        }

        [ObservableProperty]
        private int count;

        [RelayCommand]
        public void Incrementar() 
        {
            count++;
        }
    }
}
