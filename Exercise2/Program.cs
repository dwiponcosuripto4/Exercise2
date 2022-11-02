using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        int[] arr = new int[98];
        private int[] a = new int[98];
        int n;
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array:");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 elements");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" Enter array elements");
            Console.WriteLine(" ....................");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        public void ArrayA()//first method
        {
            for (int i = 0; 1 < n - 1; i++)//
            {
                int min = i;
                //
                //
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[min]) //
                    {
                        //
                        int temp;
                        temp = a[j];
                        a[j] = a[min];
                        a[min] = temp;
                    }
                }
            }
        }
        public void ArrayB()
        {
            char ch;
            do
            {
                Console.Write
                    ("\nEnter element want you to search :");
                int item = Convert.ToInt32(Console.ReadLine());

                int i = 0;
                int k = n - 1;
                int mid = (i + k) / 2;
                int j = mid + 1;
                int ctr = 1;

                while ((item != arr[mid]) && (i <= k))
                {
                    if (arr[i] <= arr[j])
                        i = j + 1;
                    else
                        k = j + 1;

                    mid = (i + k) / 2;
                    ctr++;
                }
                {
                    if (arr[j] > arr[k])
                        k = j + 1;
                    else
                        k = k + 1;
                    mid = (i + k) / 2;
                    ctr++;
                }
                {
                    if (arr[i] > arr[mid])
                        k = i + 1;
                    else
                        k = k + 1;
                    mid = (i + k) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + "found at position" + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + "not found in the array\n");
                Console.WriteLine("\nNumber of comparison :" + ctr);

                Console.Write("\nContinue search (y/n):");
                ch = char.Parse(Console.ReadLine().ToUpper());
            } while ((ch == 'y'));
        }
        static void Main(string[] args)
        {
            Program myList = new Program();
            int pilihanmenu;
            char ch;
            do
            {
                do
                {
                    Console.WriteLine("Menu Option");
                    Console.WriteLine("==============");
                    Console.WriteLine("1. ArrayA");
                    Console.WriteLine("2. ArrayB");
                    Console.WriteLine("3. Exit");
                    Console.Write("Enter your choice (1, 2, 3) : ");
                    pilihanmenu = Convert.ToInt32(Console.ReadLine());
                    switch (pilihanmenu)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("................");
                            Console.WriteLine("ArrayA");
                            Console.WriteLine("................");
                            myList.input();
                            myList.ArrayA();
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("................");
                            Console.WriteLine("ArrayB");
                            Console.WriteLine("................");
                            myList.input();
                            myList.ArrayB();
                            break;
                        case 3:
                            Console.WriteLine("exit.");
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                    Console.WriteLine("\nPilih Menu Lagi? (y/n) : ");
                    ch = char.Parse(Console.ReadLine().ToLower());
                    Console.Clear();
                } while (ch == 'y');

                // to exit from the console
                Console.WriteLine("\n\nPress Return to exit. ");
                Console.ReadLine();
            } while (pilihanmenu != 3);
        }
    }
}
