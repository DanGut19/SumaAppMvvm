namespace SumaAppMvvm.ViewModels
{
    internal class Suma
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }

        public double Calcular() 
        {
            return Numero1 + Numero2;
        }
    }
}
