//Написать программу масштабирования фигуры

double[] massiv_coordinat_s_mashtabom(string[] num, double k)
{
    double[] mas = new double[num.Length];
    for (int ind = 0; ind < num.Length; ind++)
    {
        mas[ind] = (double.Parse(num[ind])) * k;
    }
    return mas;
}

void Pechat_Massiva(double[] massiv)
{
    for (int i = 0; i < massiv.Length; i+=2)
    {
        Console.Write($"({massiv[i]}, {massiv[i+1]})  ");
    }
}

Console.Write("Введите координаты точек фигуры через запятую ',': ");
string[] num = (Console.ReadLine() ?? "0").Split(',');
Console.Write("Введите коэфициент масштабирования: ");
double k = double.Parse(Console.ReadLine() ?? "0");
double[] mash_koor = massiv_coordinat_s_mashtabom(num, k);
Pechat_Massiva(mash_koor);