using Encapsulamento;

Console.WriteLine("Hello, World!");

ContaCorrente contaCorrente = new(789,
                                  1.55m,
                                  new (nome: "Zé", 
                                       cpf: "135.456.785-10", 
                                       rg: "756.444.554-01", 
                                       endereco: "Av Tn. Baldiney de Almeida 201"));

Console.WriteLine($"Saldo:{contaCorrente.Saldo:C}");
contaCorrente.Sacar(0.55m);
Console.WriteLine($"Saldo Novo:{contaCorrente.Saldo:C}");
