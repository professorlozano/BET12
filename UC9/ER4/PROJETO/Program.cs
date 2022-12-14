
using PROJETO.Classes;


PessoaJuridica metodoPj = new PessoaJuridica();
PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.nome = "Nome PJ";
novaPj.cnpj = "00.000.000/0001-00";
novaPj.razaoSocial = "Razao Social Pj";
novaPj.rendimento = 8000.5f;

novoEndPj.Logradouro = "Rua Niteroi";
novoEndPj.numero = 180;
novoEndPj.complemento = "Senai de Informática";
novoEndPj.endComercial = true;

novaPj.endereco = novoEndPj;

Console.WriteLine(@$"
Nome: {novaPj.nome}
Razao Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
Rendimento: {novaPj.rendimento}
Logradouro: {novaPj.endereco.Logradouro}
Numero: {novaPj.endereco.numero}
Complemento: {novaPj.endereco.complemento}
Endereço Comercial? {novaPj.endereco.endComercial}
CNPJ é valido? {metodoPj.ValidarCnpj(novaPj.cnpj)}

");



/*
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

*/





