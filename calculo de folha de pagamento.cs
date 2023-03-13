

double Tot_folha = 0;
double Tot_pecas = 0;
double Media_m = 0;
double Media_f = 0;
double Cont_m = 0;
double Cont_f = 0;
double SM = 724.00;

double Cont = 0;
double Salario_maior = 0;
double Num_maior = 0;

for (int i = 0; i < 15; i = i + 1)
{
    double Num_Op;
    double Pecas_Op;
    double Salario_Op;

    string Sexo_Op;



    Console.WriteLine("\nQual o sexo do Operário? \nMasculino(M) ou Feminino(F):");
#pragma warning disable CS8600
    Sexo_Op = Console.ReadLine();
    if(Sexo_Op != "M" && Sexo_Op != "F" && Sexo_Op != "f" && Sexo_Op != "m")
    {
        Console.WriteLine("Digitação Inválida!");
        Console.WriteLine("Digite Novamente");
        Console.ReadKey();
        Console.Clear();
    }

    while (Sexo_Op != "F" && Sexo_Op != "f" && Sexo_Op != "M" && Sexo_Op != "m") 
    {
        Console.WriteLine("Qual o sexo do Operário? \nMasculino(M) ou Feminino(F):");
        Sexo_Op = Console.ReadLine();

        if (Sexo_Op != "F" && Sexo_Op != "M" && Sexo_Op != "f" && Sexo_Op != "m")
        {
            Console.WriteLine("Digitação Inválida!");
            Console.WriteLine("Digite Novamente");
            Console.ReadKey();
            Console.Clear();

        }

    }
    
   
    Console.WriteLine("Quantidade de Peças Fabricadas: ");
#pragma warning disable CS8604
    Pecas_Op = int.Parse(s: Console.ReadLine());

    if (Pecas_Op <= 30)
    {
        Salario_Op = SM;
        Num_Op = 1;
    }
    else
    {
        if (Pecas_Op > 30 && Pecas_Op <= 35)
        {
            Salario_Op = SM + ((Pecas_Op - 30) * 3 / 100 * SM);
            Num_Op = 2;
        }
        else
        {
            Salario_Op = SM + ((Pecas_Op - 30) * 5 / 100 * SM);
            Num_Op = 3;
        }

    }
    Console.WriteLine("\nNúmero do Operário: " + Num_Op);
    Console.WriteLine("O Salario do Operário: " + Salario_Op);

    Tot_folha = Tot_folha + Salario_Op;
    Tot_pecas = Tot_pecas + Pecas_Op;

    if (Sexo_Op == "M" | Sexo_Op == "m")
    {
        Media_m = Media_m + Pecas_Op;
        Cont_m = Cont_m + 1;
        Cont = Cont + 1;
    }
    else
    {
        Media_f = Media_f + Pecas_Op;
        Cont_f = Cont_f + 1;
        Cont = Cont + 1;
    }



    if (Cont == 1)
    {
        Salario_maior = Salario_Op;
        Num_maior = Num_Op;
    }
    else
    {
        if (Salario_Op > Salario_maior)
        {
            Salario_maior = Salario_Op;
            Num_maior = Num_Op;
        }
    }

}

if (Cont_m == 0)
{
    Media_m = 0;
}
else
{
    Media_m = Media_m / Cont_m;
}

if (Cont_f == 0)
{
    Media_f = 0;
}
else
{
    Media_f = Media_f / Cont_f;
}

Console.WriteLine("\nO Total da Folha de Pagamento da Fábrica: " + Tot_folha);
Console.WriteLine("O Número Total de Peças Frabricadas no Mês: " + Tot_pecas);
Console.WriteLine("Média de Peças Fabricados por Operários Masculinos: " + Media_m);
Console.WriteLine("Média de Peças Fabricados por Operários Feminos: " + Media_f);
Console.WriteLine("O Número do Opeário(a) com o Maior Salário: " + Num_maior);

Console.ReadKey();


