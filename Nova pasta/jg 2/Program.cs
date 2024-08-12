bool resposta()
{
   iniciopergunta:
   string resposta = Console.ReadLine();

   if(resposta == "s")
   {
        return true;
   }
   else if(resposta == "n")
   {
        return false;
   }
   else
   {
        Console.WriteLine("se liga otario so s ou n");
        goto iniciopergunta;
   }
}

Console.WriteLine("quer jogar um jogo? s/n");
if(resposta() == false)
{
    goto finaljogo;
}
iniciojogo:

int menor = 0;
int maior = 100;
bool jogando = true;
int numtentativas = 10;

Random rand = new Random();
int sorteado = rand.Next(menor, maior + 1);
Console.WriteLine($"pensei em um numero entre {menor} e {maior}. tente adivinhar");

while(jogando)
{
    Console.WriteLine($"tentativa {numtentativas}:");
    int numdigitado = int.Parse(Console.ReadLine());
        if(numdigitado < sorteado)
        {
            Console.WriteLine("ta frio");
            numtentativas--;

        }
        else if(numdigitado > sorteado)
        {
            Console.WriteLine("ta quente");
            numtentativas--;
        }
        else
        {
            Console.WriteLine("parabens pia");
            jogando = false;
        }
    if(numtentativas == 0 )
    {
        Console.WriteLine($"se fudeu o numero era {sorteado}");
        jogando = false;
    }
}

Console.WriteLine("vai denovo? s/n");
if(resposta()== true)
{
    goto iniciojogo;
}
finaljogo:
Console.WriteLine("que se foda então");

















