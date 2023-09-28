using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456", "Modelo 1", "111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

System.Console.WriteLine();

System.Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone("4987", "Modelo 2", "222222222", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");