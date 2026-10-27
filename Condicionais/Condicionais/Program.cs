/*Console.Write("Digite uma nota de 0 a 10: ");
string entrada = Console.ReadLine();
double nota;

// double.TryParse(entrada, out nota); muda de string para double


/* jeito que eu havia feito a validação 
if (double.TryParse(entrada, out nota)){ 
     if (nota >= 0 && nota <= 10){
        Console.Write("Número valido");
    } else {
        Console.Write("Número fora da faixa solicitada (0 a 10)");
    }
} else {
    Console.Write("Entrada invalida: Digite um número");
}
*/

/*
 if (!double.TryParse(entrada, out nota)){
    Console.Write("Entrada invalida, tente novamente digitando um número!");
}

if (nota < 0 || nota > 10)
{
    Console.Write("Nota fora da faixa (0 a 10)");
}
else if (nota >= 9)
{
    Console.Write("Conceito A");
}
else if (nota >= 7)
{
    Console.Write("Conceito B");
}
else if (nota >= 5)
{
    Console.Write("Conceito C");
}
else
{
    Console.WriteLine("Conceito D");
}
*/

/* Leia a idade, se é estudante (s/n), o dia da semana (1 = domingo ... 7 = sábado e se a sessão é 3D (s/n). calcule o preço 

1. Preço base : R$40,00,
2. Meia-entrada (%50%) se a idade for menor que 12, maior ou igual a 60, ou se for estudante 
3. Ás terças (dia3), mais de 20% de desconto sobre o valor já calculado.
4. Sessao 3D: soma R$ 8,00 depois dos descontos.
5. idade fora de 0 a 120 ->"idade invalida". Dia fora de 1 a 7 -> "Dia invalido"

*/

using System.Collections.Concurrent;
using System.ComponentModel.Design;

int idade, diasSemana;
char sessao, estudante;

Console.Write("Bem vindo ao cinema Alegria");
Console.Write("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
Console.Write("Por favor digite sua idade: ");
idade = int.Parse(Console.ReadLine());
Console.Write("Você é estudante? ");
estudante = char.Parse(Console.ReadLine());
Console.Write("Qual o dia da semana\nConsidere\n 1 -- Domingo \n 2 -- Segunda \n 3 -- Terça \n 4 -- Quarta \n 5 -- Quinta \n 6 -- Quinta \n 7 -- Sábado\n");
Console.Write("Qual dia:  ");
diasSemana = int.Parse(Console.ReadLine());
Console.Write("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
Console.Write("Sua sessão será em 3D? ");
sessao = char.Parse(Console.ReadLine());

double preco = 40f; // preço base
int meia = 20; // meia para idade < 12, >= 60 ou se for estudante
int desc; 

if (idade < 12 || idade >= 60 || estudante == 's' || estudante == 'S'){
    Console.Write($"Por conta dos requisitos você pagará meia entrada que é {meia} reais\n");
      if (diasSemana == 3){
        desc = meia - (meia * 20) / 100;
            Console.Write($"De terça feira temos um desconto total de 20% ");
                if (sessao == 's' || sessao == 'S'){
                    Console.Write($"valor total a pagar: {desc + 8}");
                }
       } else {
        Console.Write("Durante as terças feiras temos uma promoção, porém você não se encaixa ");
       }
} else if (sessao == 's' || sessao == 'S' && diasSemana == 3){
    desc = (meia + meia  * 20) / 100;
    Console.Write($"Você pagará o total de {desc + 8 }");
} else if (sessao== 'n' || sessao == 'N' && diasSemana == 3){
    Console.Write($"Você pagará o total de {preco - (preco *20/100) }");
}
