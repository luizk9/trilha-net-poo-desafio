
using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n = new Nokia( numero: "9999", modelo: "nokia-nsnns", imei: "111", memoria: 2323);

n.InstalarAplicativo("Whatsapp");
n.Ligar();


Iphone ip = new Iphone( numero: "2222", modelo: "Modiphone", imei:  "34Ip", memoria: 88989);

ip.InstalarAplicativo("Telegram");
ip.ReceberLigacao();
