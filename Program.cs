using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadZaVj5
{
    /*
     Definirajte klasu Search sa sljedećim članicama:
• metoda
int BinarySearch(int[] arr, int x) koja će koristeći algoritam binarnog
pretraživanja vratiti indeks varijable x u nizu arr, a ako je ne pronañe vratit će -1.
Definirajte objekt tipa Search, deklarirajte i definirajte niz arr tipa int u kojem će biti prvih 100
neparnih brojeva, te uz pomoće metode BinarySearch pronañite indeks člana s vrijednosti 75.
    
      */
    class Search
    {
       public int BinarySearch(int [] arr, int x)
        {
           
            return Array.BinarySearch(arr, x);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Search search = new Search();
            int[] arr = new int[100];
            int s = 1;
            int r = 75;
            for(int i = 0; i < 100; i++)
            {
                arr[i] = s;
                s = s + 2;
            }
            Console.WriteLine(search.BinarySearch(arr, r));
            Console.WriteLine(arr[37]);
            Console.ReadKey();
        }
    }
}
