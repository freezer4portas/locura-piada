/*
void Mensage(string msg)
{
    Console.WriteLine(msg);
}

Mensage("ola");

void Nomeidade(string nome, int idade)
{
    Mensage($"{nome} tem {idade} anos");
}
Nomeidade("fulano" ,16);

void Calcularidade(string nome, int ano)
{
    int idade = 2024 - ano;
        Nomeidade(nome, idade);
}
Calcularidade("fulaninho", 2014);

int maiorentre(int a, int b)
{
    if (a >= b)
    {
        return a;
    }
    else
    {
        return b;
    }
}

Console.WriteLine(maiorentre(200,99));
Console.WriteLine(maiorentre(30,99));
Console.WriteLine(maiorentre(20,30));
*/
 

 void soma(float a, float b)
 {
    float resultado = a + b;
    Console.WriteLine($"{a} + {b} = {resultado}");
 }

void subtraçao(float a, float b)
 {
    float resultado = a - b;
    Console.WriteLine($"{a} + {b} = {resultado}");
 }

void multiplicaçao(float a, float b)
 {
    float resultado = a * b;
    Console.WriteLine($"{a} + {b} = {resultado}");
 }

void divisao(float a, float b)
 {
    if (b == 0){
        Console.WriteLine("calma la paizão");
        return;
    }
    
    float resultado = a / b;
    Console.WriteLine($"{a} + {b} = {resultado}");
 };





float a;
float b;
 //variaveis globais

 void digiteaeb()
 {
    Console.WriteLine("DIGITE A:");
    a = float.Parse(Console.ReadLine());
    Console.WriteLine("DIGITE B:");
    b = float.Parse(Console.ReadLine());
 }

Console.WriteLine("===filho da púta===");
Console.WriteLine("| 1-soma          |");
Console.WriteLine("| 2-subtracao     |");
Console.WriteLine("| 3-multiolicaçao |");
Console.WriteLine("| 4-divisao       |");
Console.WriteLine("| tmn velho broxa |");

int opcao = int.Parse(Console.ReadLine());

if(opcao == 1)
{
    Console.WriteLine("soma');
    digiteaeb();
    soma(a,b);
}
else if(opcao == 2)
{
    Console.WriteLine("subtraçao");
    digiteaeb();
    subtraçao(a,b);
}
else if(opcao == 3)
{
    Console.WriteLine("multiplicaçao");
    digiteaeb();
    multiplicaçao(a,b);
}
else if(opcao == 4)
{
    Console.WriteLine("divisao");
    digiteaeb();
    divisao(a,b);
}
else if(opcao == 5)
{
    Console.WriteLine("saindo");
}
else{
    Console.WriteLine("opção invalida");
}