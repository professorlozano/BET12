
using ER3.Classes;

PessoaFisica obj_PF = new PessoaFisica();
Endereco novoEnd = new Endereco();
PessoaFisica metodoPf = new PessoaFisica();


obj_PF.nome = "Luiz";
obj_PF.dataNascimento = "01/01/2000";
obj_PF.cpf = "30430430404";
obj_PF.rendimento = 1500.00f;

novoEnd.Logradouro = "Rua Niteroi";
novoEnd.numero = 180;
novoEnd.complemento = "Escola Senai Paulo Skaf";
novoEnd.endComercial = true;

obj_PF.endereco = novoEnd;

Console.WriteLine(@$"
Nome: {obj_PF.nome}
Data de Nascimento: {obj_PF.dataNascimento}
CPF: {obj_PF.cpf}
Rendimento: {obj_PF.rendimento}
Logradouro: {obj_PF.endereco.Logradouro}
Numero: {obj_PF.endereco.numero}
Complemento: {obj_PF.endereco.complemento}
Endereço Comercial? {obj_PF.endereco.endComercial}
Maior de Idade? {metodoPf.ValidarDataNascimento(obj_PF.dataNascimento)}
");




