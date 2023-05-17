using DesafioPOO.Models;

internal class Program
{
	private static void Main(string[] args)
	{
		Console.Clear();

		// DONE: Realizar os testes com as classes Nokia e Iphone
		Console.WriteLine("Teste Nokia:\n");
		Smartphone nokia = new Nokia("123654", "Modelo X", "1122334455", 32);
		Console.WriteLine(nokia.ToString());
		nokia.Ligar();
		nokia.ReceberLigacao();
		nokia.InstalarAplicativo("Telegram");

		Console.WriteLine("=============================================");

		Console.WriteLine("Teste iPhone:\n");
		Smartphone iphone = new Iphone("890123", "Modelo Lite", "2244331166", 128);
		Console.WriteLine(iphone.ToString());
		iphone.Ligar();
		iphone.ReceberLigacao();
		iphone.InstalarAplicativo("iFood");
	}
}