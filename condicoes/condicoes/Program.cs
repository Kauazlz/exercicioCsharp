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
int idade;
Console.Write("Informe sua idade: ");
idade = int.Parse(Console.ReadLine());

string resp = (idade >= 16) ? "Cadastro permitido" : "Cadastro não permitido";
Console.Write(resp);