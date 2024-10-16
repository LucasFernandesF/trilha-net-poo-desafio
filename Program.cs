using DesafioPOO.Models;

// Realizando os testes com as classes Nokia e Iphone
Iphone celular1 = new Iphone("3199999-9999", "IPHONE 14 PRO MAX", "123456", 128);


celular1.Ligar();
celular1.ReceberLigacao();
celular1.InstalarAplicativo("WhatsApp");

Console.WriteLine("----------------------------");

Iphone celular2 = new Iphone("3199999-9999", "NOKIA C21", "654321", 32);

celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativo("Instagram");