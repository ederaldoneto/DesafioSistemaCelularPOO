namespace DesafioPOO.Models
{
    public class IPhone : Smartphone
    {
        public IPhone(string numero, string modelo, string imei, string memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone - {Modelo}");
        }
    }
}