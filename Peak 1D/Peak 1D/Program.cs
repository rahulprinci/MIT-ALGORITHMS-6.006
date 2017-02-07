using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peak_1D
{
    class Peak
    {
        int size;
        int[] arr;
        
        int mid1,max1;
        public void insert(int x)
        {
            arr= new int[x];
            for (int i = 0; i < x; i++)
            {
                arr[i] = i;
            }
        }
        

        public void peak(int mid, int max)
        {
            if( mid+1 >max || mid-1< 0)
            {
                Console.WriteLine("The peak is {0}", arr[mid]);
                Console.ReadKey();
            }
            else if ((arr[mid] >= arr[mid + 1] && arr[mid] >= arr[mid - 1]))
            {
                Console.WriteLine("The peak is {0}", arr[mid]);
                Console.ReadKey();
            }
            else if (arr[mid + 1] >= arr[mid] && arr[mid + 1] >= arr[mid - 1])
            {
                mid = mid + 1;
                peak(mid,max);
            }
            else
            {
                mid = mid - 1;
                peak(mid,max);
            }
        }
        class FindMid
        {
            public int mid(int x)
            {
                if (x % 2 == 0)
                {
                    return x / 2;
                }
                else 
                {
                    return (x + 1) / 2;
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Peak p1 = new Peak();
                Console.WriteLine("Enter Size of Array:");
                p1.size=Convert.ToInt32(Console.ReadLine());
                p1.insert(p1.size);
                FindMid fm = new FindMid();
                p1.max1 = p1.arr.Length - 1 ;
                p1.mid1 = fm.mid(p1.max1);
                //without divide and conquer algorithm
                //p1.mid1 = 1;
                
                p1.peak(p1.mid1,p1.max1);
            }
        }
    }
}
