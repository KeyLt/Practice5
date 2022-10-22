//Написать программу копирования массива
void Zapolnenie_Massiva(int[] massiv)
{
    Random Znach = new Random();
    for (int ind = 0; ind < massiv.Length; ind++)
    {
        massiv[ind] = Znach.Next(-9, 10);
    }
}
void Pechat_Massiva(int[] massiv)
{
    foreach (var item in massiv)
    {
        Console.Write($"{item} ");
    }
}
int[] Kopirovanie_massiva(int[] masiv)
{
    int[] Kopmas = new int [masiv.Length];
    for (int ind = 0; ind < masiv.Length; ind++)
    {
        Kopmas[ind] = masiv[ind];
    }
    return Kopmas;
}
Console.Write("Введите длинну массива: ");
int dlinna = int.Parse(Console.ReadLine()?? "0");
int[] Array = new int[dlinna];
Zapolnenie_Massiva(Array);
Console.Write("Начальный массив: ");
Pechat_Massiva(Array);
Console.Write("Скопированный массив: ");
int[] Array_copy = Kopirovanie_massiva(Array);
Pechat_Massiva(Array_copy);