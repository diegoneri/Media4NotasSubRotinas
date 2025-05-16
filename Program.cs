double notaUm, notaDois, notaTres, notaQuatro, media;
string resultado;

ExibeBoasVindas();

notaUm = SolicitaNota(1);
notaDois = SolicitaNota(2);
notaTres = SolicitaNota(3);
notaQuatro = SolicitaNota(4);
if (!ValidaNotas(N1: notaUm, N2: notaDois, N3: notaTres, N4: notaQuatro))
{
    Console.WriteLine("Digite somente notas entre 0 e 10.");
    Environment.Exit(0);
}

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