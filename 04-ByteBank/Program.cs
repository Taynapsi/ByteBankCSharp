// See https://aka.ms/new-console-template for more information

ContaCorrente contaDoBruno = new ContaCorrente();

contaDoBruno.titular = "Bruno";
Console.WriteLine(contaDoBruno.saldo);


bool resultadoSaque = contaDoBruno.Sacar(500);

Console.WriteLine(contaDoBruno.saldo);
Console.WriteLine(resultadoSaque);

contaDoBruno.Depositar(500);
Console.WriteLine(contaDoBruno.saldo);

ContaCorrente contaDaGabriela = new ContaCorrente();

contaDaGabriela.titular = "Gabriela";

bool resultadoTransferencia = contaDoBruno.Transferir(2000, contaDaGabriela);

Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

Console.WriteLine("Resultado transferência: " + resultadoTransferencia);

contaDaGabriela.Transferir(100, contaDoBruno);
Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

Console.WriteLine("Resultado transferência: " + resultadoTransferencia);

Console.ReadLine();
