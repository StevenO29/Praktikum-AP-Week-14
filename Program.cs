using System;

class Praktikum_AP_Week_14
{
    static void MencetakTabelPrima(int inputAngka)
    {
        int angkaPertama = 2;
        for (int verticalTable = 0; verticalTable < inputAngka; verticalTable++)
        {
            for (int horizontalTable = 0; horizontalTable < inputAngka; horizontalTable++)
            {
                Console.Write($"{angkaPertama}".PadLeft(6));
                angkaPertama += 1;
                int cekPrima = 2;
                while (angkaPertama % cekPrima != 0)
                    cekPrima += 1;
                while (angkaPertama != cekPrima)
                {
                    angkaPertama += 1;
                    cekPrima = 2;
                    while (angkaPertama % cekPrima != 0)
                        cekPrima += 1;
                }
            }
            Console.Write("\n");
        }
    }
    static void MencetakTabelNonPrima(int inputAngka)
    {
        int angkaPertama = 1;
        for (int verticalTable = 0; verticalTable < inputAngka; verticalTable++)
        {
            for (int horizontalTable = 0; horizontalTable < inputAngka; horizontalTable++)
            {
                Console.Write($"{angkaPertama}".PadLeft(6));
                angkaPertama += 1;
                int cekPrima = 2;
                while (angkaPertama % cekPrima != 0)
                    cekPrima += 1;
                while (angkaPertama == cekPrima)
                {
                    angkaPertama += 1;
                    cekPrima = 2;
                    while (angkaPertama % cekPrima != 0)
                        cekPrima += 1;
                }
            }
            Console.Write("\n");
        }
    }
    static void Main(string[] args)
	{
		Console.Write("Input : ");
		int inputAngka = Convert.ToInt32(Console.ReadLine());
		while (inputAngka < 2)
        {
			Console.Write("Input : ");
			inputAngka = Convert.ToInt32(Console.ReadLine());
			break;
		}
        int counter = 2;
        while (inputAngka % counter != 0)
            counter += 1;
        if (inputAngka == counter)
            MencetakTabelPrima(inputAngka);
        else
            MencetakTabelNonPrima(inputAngka);
	}
}