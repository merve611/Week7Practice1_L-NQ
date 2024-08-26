using System;

internal class Program
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();

        //Liste oluşturuldu
        List<int> numbers = new List<int>();

        //Rastgele 10 adet sayı oluşturup listenin içine atandı
        for (int i = 0; i<10; i++)
        {
            int sayi = rnd.Next(-5,25);
            numbers.Add(sayi);
        }

        Console.WriteLine("Çift sayilar:");
        var evenNumbers = numbers.Where(num => num % 2 == 0);
        foreach (int num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("Tek Sayilar: ");
        var singleNumbers = numbers.Where(num => num % 2 == 1);
        foreach (int num in singleNumbers)
        {
            Console.WriteLine(num);

        }

        Console.WriteLine("Negatif Sayilar: ");
        var negativeNumbers = numbers.Where(num => num < 0);
        foreach (int num in negativeNumbers)
        {
            Console.WriteLine(num);

        }

        Console.WriteLine("Pozitif Sayilar: ");
        var positiveNumbers = numbers.Where(num => num > 0);
        foreach (int num in positiveNumbers)
        {
            Console.WriteLine(num);

        }

        Console.WriteLine("15'ten büyük ve 22'den küçük sayılar: ");
        var numNumbers = numbers.Where(num => num >15 && num<22);
        foreach (int num in numNumbers)
        {
            Console.WriteLine(num);

        }

        Console.WriteLine("Listedeki her bir sayının karesi : ");

        List<int> squareList = new List<int>();     //Sayıların karesi yeni bir listeye atandı
        foreach (int num in numbers)
        {
            int squareNum = num * num;
            squareList.Add(squareNum);
            Console.WriteLine(squareNum);
        }

        //Bu şekilde de yapılabilir;
        //var squareNumber = numbers.Select(num => num * num);
        //foreach (var number in squareNumber)
        //{
        //    Console.WriteLine(number);
        //}



    }
}