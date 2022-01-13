// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

ContaCorrente contaDaGabriela = new ContaCorrente();
contaDaGabriela.titular = "Gabriela";
contaDaGabriela.agencia = 863;
contaDaGabriela.numero = 863452;

ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
contaDaGabrielaCosta.titular = "Gabriela";
contaDaGabrielaCosta.agencia = 863;
contaDaGabrielaCosta.numero = 863452;


contaDaGabriela.saldo -= 100;

