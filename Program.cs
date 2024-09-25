using DesafioPOO.Models;

Console.WriteLine("Iphone");
Iphone I1 = new Iphone("15444688", "Iphone 15", "555", 264);
I1.Ligar();
I1.InstalarAplicativo("oneDrive");

Console.WriteLine("Nokia");
Nokia N1 = new Nokia("22235648", "Nokia 7", "666655", 128);
N1.ReceberLigacao();
N1.InstalarAplicativo("WhatsApp");



// TODO: Realizar os testes com as classes Nokia e Iphone;