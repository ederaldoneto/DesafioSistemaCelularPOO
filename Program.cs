using DesafioPOO.Models;

class Programa
{
    static void Main(string[] args)
    {
        // Criando instâncias de Nokia e iPhone
        Nokia nokia = new Nokia("123456789", "Nokia 6.3", "IMEI1234567890", "64GB");
        IPhone iPhone = new IPhone("987654321", "iPhone 13", "IMEI0987654321", "256GB");

        // Chamando os métodos para o celular Nokia
        Console.WriteLine("Usando o Nokia:");
        nokia.Ligar(); // Simula a ação de ligar o Nokia
        nokia.ReceberLigacao(); // Simula o recebimento de uma ligação no Nokia
        nokia.InstalarAplicativo("WhatsApp"); // Simula a instalação de um aplicativo no Nokia

        // Separando os testes para os smartphones
        Console.WriteLine();

        // Chamando os métodos para o iPhone
        Console.WriteLine("Usando o iPhone:");
        iPhone.Ligar(); // Simula a ação de ligar o iPhone
        iPhone.ReceberLigacao(); // Simula o recebimento de uma ligação no iPhone
        iPhone.InstalarAplicativo("Instagram"); // Simula a instalação de um aplicativo no iPhone
    }
}