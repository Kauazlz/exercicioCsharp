// Nivel Facil
// Ex01
/*
float temp;
Console.Write("Informe a temperatura: ");
temp = float.Parse(Console.ReadLine());

if (temp < 15){
    Console.Write("Está um tempo frio");
} else{
    Console.Write("O tempo está agradável");
}
*/

// Ex02 
/*
int num;
Console.Write("Informe um número: ");
num = int.Parse(Console.ReadLine());

if (num > 100){
    Console.Write($"O valor {num} é maior que 100");
} else if (num == 100){
    Console.Write("O valor é igual a 100");
} else {
    Console.Write($"O valor {num} é menor que 100");
}
*/

// Ex03
/*
string senha;
Console.Write("Digite a sua senha: ");
senha = Console.ReadLine();
if (senha == "123"){
    Console.Write("Acesso liberado");
} else{
    Console.Write("Usuário não foi encontrado");    
}
*/

// Ex04
/*
int num;
Console.Write("Digite um número: ");
num = int.Parse(Console.ReadLine());

if (num < 0){
    Console.Write("Número invalido");
} else if (num == 0){
    Console.Write($"O {num} número nulo");
} else {
    Console.Write($"O {num} é valido, obrigado");
}
*/

// Ex05
/*
int idade;
Console.Write("Informe sua idade: ");
idade = int.Parse(Console.ReadLine());

string resp = (idade >= 16) ? "Cadastro permitido" : "Cadastro não permitido";
Console.Write(resp);
*/

// Ex06
/*
Console.Write("Por favor digite um número: ");
int opcao = int.Parse(Console.ReadLine());

switch (opcao) {
    case 1:
    Console.Write("Manhã");
    break;

    case 2:
    Console.Write("Tarde");
    break;

    case 3:
    Console.Write("Noite");
    break;

    default:
    Console.Write("Opção invalida");
    break;

}
*/

// Ex07
/*
Console.Write("-=-=-=-=-=-=-=-=-=-=-=-=-\n");
Console.Write(" 1 -------- Novo Jogo\n");
Console.Write(" 2 -------- Carregar jogo\n");
Console.Write(" 3 -------- Sair\n");
Console.Write("-=-=-=-=-=-=-=-=-=-=-=-=-\n");
Console.Write("O que deseja fazer: ");
int opcao = int.Parse(Console.ReadLine());

switch (opcao) {
    case 1:
        Console.Write("Bora criar o jogo");
        break;

    case 2:
        Console.Write("Carregando o jogo....");
        break;

    case 3:
        Console.Write("saindo....");
        break;

    default:
        Console.Write("Opção invalida!");
        break;
}
*/

// Nivel medio
// Ex01
/*
int idade;
Console.Write("Olá, por gentileza digite sua idade: ");
idade = int.Parse(Console.ReadLine());

if (idade <= 12){
    Console.Write($"Com {idade} anos você ainda é considerada uma criança");
} else if (idade > 13 && idade <= 17 ){
    Console.Write($"Com {idade} anos você já é um adolescente");
} else{
    Console.Write($"Você já é um adulto com {idade} anos");
}
*/

// Ex02
/*
int n1, n2;
Console.Write("Digite o primeiro valor: ");
n1 = int.Parse(Console.ReadLine());
Console.Write("Digite o outro: ");
n2 = int.Parse(Console.ReadLine());

int resultado = n1 > n2 ? n1 : n2; // Ternario para validação do maior número 

Console.Write($"Ao analisar os valores o maior foi o {resultado}");
*/

// Ex03
/*
int idade;
string convite; //  bool convite

Console.Write("Olá, informe sua idade, por favor: ");
idade = int.Parse(Console.ReadLine());
Console.Write("Você possui o convite da festa? ");
convite = (Console.ReadLine()); // convite = bool.Parse

if (convite == "Sim" || convite == "sim" || idade >= 18){ // se fosse bool seria convite == true 
    Console.Write("Você pode entrar, boa festa");
} else{
    Console.Write("Infelizmente você não possui permissão para entrar na festa");
}
*/


// Ex 04
int numero;
Console.Write("Insira um número");
numero = int.Parse(Console.ReadLine());

if (numero >=0 && numero <= 10){
    Console.Write("Número valido");
}








