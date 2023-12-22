namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        List<string> listaDeApps = new List<string>();
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero,modelo,imei,memoria)
        {

        }

        // TODO: Sobrescrever o método "InstalarAplicativo" 
        public override void InstalarAplicativo(string nomeApp)
        {
           
           listaDeApps.Add(nomeApp);
           Console.WriteLine("Os apps instalados neste celular são:");
        foreach (string totalApps in listaDeApps)
            Console.WriteLine(totalApps);
        }
    }
}