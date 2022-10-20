
using DesafioPOO.Models;


// Etapa pronta do --->  TODO: Realizar os testes com as classes Nokia e Iphone

// inicializando a classe Nokia
Nokia n = new Nokia("9999", "nsnns", "111", 2323);

n.InstalarAplicativo("nokia");
n.Ligar();


// instanciando a class Iphone
Iphone ip = new Iphone("2222", "Modiphone", "34Ip", 88989);

ip.InstalarAplicativo("Iphone");
ip.ReceberLigacao();
