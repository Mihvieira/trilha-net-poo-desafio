using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "1234", modelo: "1", imei: "0000", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("facebook");

Console.WriteLine("\nSmartphone Iphone");
Smartphone iphone = new Iphone(numero: "45678", modelo: "2", imei: "111", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("facebook");