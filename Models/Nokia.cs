
namespace DesafioPOO.Models
{
    // Done: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) 
        {
        }

        // Done: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Nokia");
        }
    }
}