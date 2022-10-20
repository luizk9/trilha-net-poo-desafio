namespace DesafioPOO.Models
{
    // etapa pronta de -- TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // construtor base do Smrtphone
        public Nokia(string numero, string modelo, string imei, int memoria) : base (numero, modelo,imei,memoria)
        {

        }

        // etapa pronta do --> TODO: Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(string nomeApp)
        {    
             Console.WriteLine( $"Vamos instalar o {nomeApp}: {Numero}");
             Console.WriteLine( "------===..........");
             Console.WriteLine( $"---EMAI: {Imei}");
             Console.WriteLine( $"---MODELO: {Modelo}");
             Console.WriteLine( $"---EMEI: {Memoria}");
             Console.WriteLine( $"---=====.............");
        }

    }
}
