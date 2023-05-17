using DesafioPOO.Models;

internal class Program
{
	private static void Main(string[] args)
	{
		// DONE: Realizar os testes com as classes Nokia e Iphone
		Console.WriteLine("Teste Nokia:");
		Smartphone nokia = new Nokia("123654", "Modelo X", "1122334455", 32);
		nokia.Ligar();
		nokia.ReceberLigacao();
		nokia.InstalarAplicativo("Telegram");

		Console.WriteLine("=============================================");

		Console.WriteLine("Teste iPhone:");
		Smartphone iphone = new Iphone("890123", "Modelo Lite", "2244331166", 128);
		iphone.Ligar();
		iphone.ReceberLigacao();
		iphone.InstalarAplicativo("iFood");
	}
}