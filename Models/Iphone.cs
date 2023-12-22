namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        List<string> listaDeApps = new List<string>();
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero,modelo,imei,memoria)
        {
            
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(string nomeApp)
        {
           listaDeApps.Add(nomeApp);
           Console.WriteLine($"Os apps instalados  no neste celular são:");
        foreach (string totalApps in listaDeApps)
            Console.WriteLine(totalApps);
        }
    }
}