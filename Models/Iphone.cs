namespace DesafioPOO.Models
{
    // etapa pronta do -- > TODO: Herdar da classe "Smartphone"
    public class Iphone  : Smartphone
    {
          public Iphone(string numero, string modelo, string imei, int memoria) : base (numero, modelo,imei,memoria)
        {

        }
        //  etapa pronta do -- >  TODO: Sobrescrever o método "InstalarAplicativo"

         public override void InstalarAplicativo(string nomeApp)
        {
                   Console.WriteLine();  
             Console.WriteLine( $"Vamos instalar o {nomeApp}: {Numero}");
             Console.WriteLine( "***** = = = =  ******" );
             Console.WriteLine( $"---EMAI: {Imei}");
             Console.WriteLine( $"---MODELO: {Modelo}");
             Console.WriteLine( $"---EMEI: {Memoria}");
             Console.WriteLine( $"---------------------....");
        
        }
    }
}
