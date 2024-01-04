using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Iniciando o iPhone...");
Iphone smart1 = new Iphone(numero: "9999-9999", modelo: "XR 7", imei: "12345612", memoria: 111222);
smart1.Ligar();
smart1.ReceberLigacao();
smart1.InstalarAplicativo("Disney+");

Console.WriteLine("----------------------------------");

Console.WriteLine("Iniciando o Nokia...");
Nokia smart2 = new Nokia(numero: "8888-8888", modelo: "G11", imei: "98765423", memoria: 222333);
smart2.ReceberLigacao();
smart2.Ligar();
smart2.InstalarAplicativo("Netflix");
