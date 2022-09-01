internal class Program
{
    private static void Main(string[] args)
    {
        //While
        Console.WriteLine("**** While ****");
        // 1 deb baslayarak console dan girilen sayiya kadar (sayi dahil) ortalama hesaplayip console a yazdıran program.
        Console.Write("Lutfen bir sayi giriniz: ");
        int sayi =int.Parse(Console.ReadLine());
        int sayac =1;
        int toplam = 0;
        while (sayac <= sayi)
        {
            toplam+=sayac;
            sayac++;
        }
        Console.WriteLine(toplam/sayi);

        // 'a' dan 'z' ye kadar tum harfleri console a yazdir.
        char character = 'a';
        while(character<'z')
        {
            Console.WriteLine(character);
            character++;
        }

        //Foreach
        Console.WriteLine("**** Foreach ****");

        string[] arabalar = {"BMW","Ford","Toyota","Opel"};
        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }
    }
}