using System;
namespace MutlakKareAlma
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***Kullanicidan n tane sayinin 67'den küçük yada büyük olduğuna bakan. Küçük olanlarin farklarinin toplamini, büyük ise de farklarin mutlak karelerini alarak toplayip ekrana yazdirma***");
            Console.WriteLine("__________________________________________________________________________________");
            Console.Write("n tane deger giriniz: ");

            while (true)
            {
                try
                {
                    string inputs = Console.ReadLine();
                    string[] arrInputs = inputs.Split(' ');
                    int[] arrNum = new int[arrInputs.Length];

                    int toplamFark = 0;
                    double abs = 0;

                    for (int i = 0; i < arrInputs.Length; i++)
                    {
                        int current = int.Parse(arrInputs[i]);
                        arrNum[i] = current;
                        if (arrNum[i] <= 67)
                        {
                            toplamFark += 67 - arrNum[i];
                        }
                        else if (arrNum[i] >= 67)
                        {
                            abs += Math.Pow(Convert.ToDouble(arrNum[i] - 67), 2);
                        }
                    }

                    Console.WriteLine("Farklarin toplami: " + toplamFark);
                    Console.Write("Farklarin mutlak karelerin toplami: " + abs);

                }
                catch (FormatException)
                {
                    Console.WriteLine("Gecerli bir sayi girisi yapmadiniz. Lutfen tekrar deneyin");
                }
            }
        }
    }
}