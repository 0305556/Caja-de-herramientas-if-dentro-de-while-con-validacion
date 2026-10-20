double nota1 = ReadGrade("Nota 1");
double nota2 = ReadGrade("Nota 2");
double nota3 = ReadGrade("Nota 3");
double promedio = Average(nota1, nota2, nota3); PrintVerdict(promedio);
static double ReadGrade(string label)
{
    while (true)
    {
        Console.Write($"{label} (0 a 10):   ");
        if (double.TryParse(Console.ReadLine(), out double grade) && grade >= 0 && grade <= 10)
        {
            return grade;
        }
        Console.WriteLine("Entrada inválida. Escribe un número entre 0 y 10");
    }
}

static double Average(double a, double b, double c)
{
    return (a +  b + c) / 3.0;
}

static void PrintVerdict(double avg)
{
    string verdict = avg >= 6 ? "Aprobado" : "Reprobado";
    Console.WriteLine($"Promedio: {avg}");
    Console.WriteLine($"Resultado: {verdict}");
    
}