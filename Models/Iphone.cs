namespace DesafioPOO.Models
{
	// DONE: Herdar da classe "Smartphone"
	public class Iphone : Smartphone
	{
		public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }

		// DONE: Sobrescrever o método "InstalarAplicativo"
		public override void InstalarAplicativo(string nomeApp)
		{
			Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no iPhone");
		}

		public override string ToString()
		{
			return (
				"iPhone specs:\n" +
				$"Numero: {Numero}\n" +
				$"Modelo: {Modelo}\n" +
				$"IMEI: {Imei}\n" +
				$"Memoria: {Memoria} Gb\n"
				);
		}
	}
}