using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("(11)92343-6786", "Nokia g50", "123456", 128); 
nokia.Ligar();
nokia.InstalarAplicativo("Google Maps");

Console.WriteLine("\n-------------------------------------------------------------------------\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone("(11)95493-4278", "Iphone g50", "654321", 256);
iphone.ReceberLigacao(); 
iphone.InstalarAplicativo("Waze");