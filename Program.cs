double notaUm, notaDois, notaTres, notaQuatro, media;
string resultado;

ExibeBoasVindas();

notaUm = SolicitaNota(1);
notaDois = SolicitaNota(2);
notaTres = SolicitaNota(3);
notaQuatro = SolicitaNota(4);

bool saoNotasValidas = ValidaNotas(N1: notaUm, N2: notaDois, N3: notaTres, N4: notaQuatro);
if (!saoNotasValidas)
{
    Console.WriteLine("Digite somente notas entre 0 e 10.");
    Environment.Exit(0);
}

media = (notaUm + notaDois + notaTres + notaQuatro) / 4;

resultado = DefineResultado(media);

// Exibir o resultado em uma subrotina
// Exibir cores do resultado de acordo com o valor
// aprovado = verde / reprovado = vermelho / em recuperação = amarelo
Console.WriteLine($"Você ficou com média {media:N1}. Resultado: {resultado}");

void ExibeBoasVindas()
{
    Console.WriteLine("-- Média --\n");
    Console.WriteLine("Digite as suas notas abaixo.");
}

double SolicitaNota(int ordemNota)
{
    Console.Write($"Nota {ordemNota}: ");
    return Convert.ToDouble(Console.ReadLine());
}

bool ValidaNotas(double N1, double N2, double N3, double N4)
{
    bool notaUmEhValida = ValidaNota(N1);
    bool notaDoisEhValida = ValidaNota(N2);
    bool notaTresEhValida = ValidaNota(N3);   
    bool notaQuatroEhValida = ValidaNota(N4);

    return notaUmEhValida && notaDoisEhValida &&
           notaTresEhValida && notaQuatroEhValida;
}

bool ValidaNota(double nota)
{
    return nota >= 0 && nota <= 10;
    //false quando houver alguma nota < 0 ou nota > 10
}

string DefineResultado(double media)
{
    //return media < 5 ? "Reprovado" : "Aprovado";
    // if (media < 5)
    // {
    //     return "Reprovado";
    // }
    // else
    // {
    //     return "Aprovado";
    // }    
    return media < 5 ? "Reprovado" : 
           media < 6 ? "Em Recuperação" : 
           "Aprovado";
    // if (media < 5)
    // {
    //     return "Reprovado";
    // }
    // else if (media < 6)
    // {
    //     return "Em recuperação";
    // }
    // else
    // {
    //     return "Aprovado";
    // }     
}