using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
    
        public static void diziyedegerat()
        {
           

           
            Random uretec = new Random();
           
            for(int i=0;i<dizi.Length;i++)
            {
                dizi[i] = uretec.Next(20,50);
            }
        }
        public static int[] dizi = new int[10];
        public void QuickSort(int[] dizi, int baslangic, int bitis)
        {
            int i;
            if (baslangic < bitis)
            {
                i = partition(dizi, baslangic, bitis);
                QuickSort(dizi, baslangic, i - 1);
                QuickSort(dizi, i + 1, bitis);
            }
        }
        public int partition(int[] A, int baslangic, int bitis)
        {
            int gecici;
            int x = A[bitis];
            int i = baslangic - 1;
            for (int j = baslangic ; j <= bitis - 1; j++)
{
                if (A[j] <= x)
                {
                    i++;
                    gecici = A[i];
                    A[i] = A[j];
                    A[j] = gecici;
                }
            }
            gecici = A[i + 1];
            A[i + 1] = A[bitis];
            A[bitis] = gecici;
            return i + 1;
        }

        static void Main(string[] args)
        {
           
            diziyedegerat();
            Console.WriteLine("işlem biti");
            QuickSort(dizi,0,dizi.Length);
            

            for (int i=0;i<dizi.Length;i++)
            {
                Console.WriteLine(dizi[i]);
            }
            Console.ReadLine();
        }








    }
}
