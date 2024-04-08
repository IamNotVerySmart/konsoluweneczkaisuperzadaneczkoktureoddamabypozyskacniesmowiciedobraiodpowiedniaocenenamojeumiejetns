int[] tablica = new int[101];
Random random = new Random();
for (int i = 0; i < tablica.Length; i++)
{
    tablica[i] = random.Next(0, 101);
}
Console.WriteLine("Podaj szukaną wartość: ");
int a = int.Parse(Console.ReadLine());
tablica[tablica.Length - 1] = a;
int indeks = 0;
for (int i = 0; i < tablica.Length; i++)
{
    if (tablica[i] == a)
    {
        indeks = i;
        break;
    }
}
Console.WriteLine("Liczba szukana znaleziona na indeksie: " + indeks);
foreach (int i in tablica)
{
    Console.Write(i + ", ");
}