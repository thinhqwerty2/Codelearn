using System;
using System.Collections.Generic;
namespace Algorithm
{
    #region Example
    public class ExMaxSumSubArray
    {
        static double sum = 0;
        static double maxsum = -99999999;
        static int[] vtri = new int[2];
        private static void BruteForce(double[] arr)
        //Duyet toan bo cac day con va tinh tong cac day con do
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    sum = 0;
                    for (int k = i; k < j; k++)
                    {
                        sum += arr[k];
                    }
                    if (sum > maxsum) { maxsum = sum; vtri[0] = i; vtri[1] = j; };
                }
            }
            Console.WriteLine($"MaxSumSubArray={maxsum}, vi tri tu {vtri[0] + 1} den {vtri[1] + 1}");
        }
        private static void BruteForce2(double[] arr)
        //Duyet toan bo nhung cai tien phep tinh tong
        {
            maxsum = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                sum = 0;
                for (int j = i; j < arr.Length - 1; j++)
                {
                    sum += arr[j];
                    if (sum > maxsum)
                    { maxsum = sum; vtri[0] = i; vtri[1] = j; }
                }
            }
            Console.WriteLine($"MaxSumSubArray={maxsum}, vi tri tu {vtri[0] + 1} den {vtri[1] + 1}");
        }
        private static void Recursion(double[] arr)
        //Dung de qui de giam so phep tinh
        {
            MaxSub(arr, 0, arr.Length - 1);
            Console.WriteLine($"MaxSumSubArray={maxsum}, vi tri tu {vtri[0] + 1} den {vtri[1] + 1}");
        }
        private static double MaxSub(double[] arr, int start, int end)
        //Tong day con lon nhat tu vi tri start den vi tri end
        {
            if (start == end) return arr[start];
            else
            {
                int m = (start + end) / 2;
                double wL = MaxSub(arr, start, m);
                double wR = MaxSub(arr, m + 1, end);
                double wM = MaxL(arr, start, m) + MaxR(arr, m + 1, end);//Tong day con lon nhat di qua diem giua
                return maxsum = Math.Max(Math.Max(wL, wR), wM);
            }
        }
        private static double MaxL(double[] arr, int start, int end)
        //Tong day con lon nhat ben trai
        {
            double sumL = 0;
            double maxsumL = -9999999;
            for (int i = end; i > start; i--)
            {
                sumL += arr[i];
                if (sumL > maxsumL)
                {
                    vtri[0] = i;
                    maxsumL = sumL;
                }
            }
            return maxsumL;
        }
        private static double MaxR(double[] arr, int start, int end)
        //Tong day con lon nhat ben phai
        {
            double sumR = 0;
            double maxsumR = -9999999;
            for (int i = start; i < end; i++)
            {
                sumR += arr[i];
                if (sumR > maxsumR)
                {
                    vtri[1] = i;
                    maxsumR = sumR;
                }
            }
            return maxsumR;
        }
        public static void DynamicProgramming(double[] arr)
        //si la tong day con lon nhat cua day LeftArr,RightArr,...ai
        //Do day con lon nhat cua day nay hoac la chua ai hoac la ko chua ai nen no chi la 1 trong 2 day
        //1.LeftArr,RightArr,...a(i-1) (1)
        //2.LeftArr,RightArr,...ai va ket thuc tai ai (2)
        //si=max(s(i-1),ei) i=2,...n
        //ei la tong day con lon nhat cua day (2) 
        //ei=max(ai,e(i-1)+ai) i=2,...n
        //e1=LeftArr
        {
            double[] s = new double[arr.Length];
            double[] e = new double[arr.Length];
            s[0] = arr[0];
            e[0] = arr[0];
            for (int i = 1; i < s.Length; i++)
            {
                //ei=max(ai,e(i-1)+ai) i=2,...n
                if (arr[i] > e[i - 1] + arr[i])
                {
                    e[i] = arr[i];
                    vtri[0] = i;
                }
                else
                {
                    e[i] = e[i - 1] + arr[i];
                }
                //si=max(s(i-1),ei) i=2,...n
                if (s[i - 1] > e[i])
                {
                    s[i] = s[i - 1];
                }
                else
                {
                    s[i] = e[i];
                    vtri[1] = i;
                }
            }
            maxsum = s[s.Length - 1];
            Console.WriteLine($"MaxSumSubArray={maxsum}, vi tri tu {vtri[0] + 1} den {vtri[1] + 1}");
        }
        public static void Test()
        {
            Console.WriteLine("Nhap so phan tu day ");
            int n = int.Parse(Console.ReadLine());
            double[] arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu thu {0}: ", i + 1);
                arr[i] = double.Parse(Console.ReadLine());
            }
            //MaxSumSubArray.BruteForce(arr);
            //MaxSumSubArray.BruteForce2(arr);
            //MaxSumSubArray.Recursion(arr);
            //MaxSumSubArray.DynamicProgramming(arr);
        }
    }
    #endregion
    #region Recursion
    public class Recursion
    {
        public class factorial
        {
            public static int Start(int n)
            {
                if (n == 0 || n == 1) return 1;
                else
                    return Start(n - 1) * n;
            }
        }
    }
    #endregion
    #region Sort
    public class Sort
    {
        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public class SelectionSort
        {
            public static void Start(int[] arr)
            {
                selectionSort(arr);
            }
            private static void selectionSort(int[] arr)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    int minpos = i;
                    for (int j = i + 1; j <= arr.Length - 1; j++)
                    {
                        if (arr[j] < arr[minpos])
                        {
                            minpos = j;
                        }
                    }
                    swap(ref arr[i], ref arr[minpos]);
                }
            }
        }
        public class InsertionSort
        {
            public static void Start(int[] arr)
            {
                LinkedList<int> list = new LinkedList<int>();
                list.AddFirst(arr[0]);
                for (int i = 1; i < arr.Length; i++)
                {
                    insertionSort(list, arr[i]);
                }
                list.CopyTo(arr, 0);
            }
            private static void insertionSort(LinkedList<int> arr, int value)
            {
                LinkedListNode<int> node = arr.Last;
                LinkedListNode<int> knode = new LinkedListNode<int>(value);
                for (int i = 0; i < arr.Count; i++)
                {
                    if (knode.Value > node.Value) { arr.AddAfter(node, knode); return; }
                    else
                        node = node.Previous;
                }
                arr.AddFirst(knode);
            }
        }
        public class ShellSort
        {
            public static void Start()
            {
            }
        }
        public class MergeSort
        {
            public static void Start(int[] arr)
            {
                mergeSort(arr, 0, arr.Length - 1);
            }
            private static void mergeSort(int[] arr, int left, int right)
            {
                if (right - left == 0) return;
                {
                    int middle = (left + right) / 2;
                    mergeSort(arr, left, middle);
                    mergeSort(arr, middle + 1, right);
                    merge(arr, left, middle, right);
                }

            }
            private static void merge(int[] arr, int left, int middle, int right)
            {
                if (right - left > 2)
                {
                    List<int> rs = new List<int>();
                    int ileft = left;//chi so chay ben trai
                    int iright = middle;//chi so chay ben phai
                    for (int i = left; i <= right; i++)
                    {

                        if (ileft == middle + 1)
                        {
                            rs.Add(arr[iright]);
                            iright++;
                            continue;
                        }
                        if (iright == right + 1)
                        {
                            rs.Add(arr[left]);
                            ileft++;
                            continue;
                        }
                        if (arr[ileft] < arr[iright])
                        {
                            rs.Add(arr[ileft]); ileft++;
                        }
                        else
                        {
                            rs.Add(arr[iright]); iright++;
                        }
                        arr[i] = rs[rs.Count - 1];
                    }
                }
                else
                {
                    if (arr[left] > arr[right])
                        swap(ref arr[left], ref arr[right]);
                }
            }
        }
        public class QuickSort
        {
            public static void Start(int[] arr)
            {
                quickSort(arr, 0, arr.Length - 1);
            }
            public static void quickSort(int[] arr, int left, int right)
            {
                int Pivot;
                if (right - left < 9) InsertionSort.Start(arr);
                else
                {
                    Pivot = Partition(arr, left, right);
                    quickSort(arr, left, Pivot - 1);
                    quickSort(arr, Pivot + 1, right);
                }
            }
            private static int Partition(int[] arr, int left, int right)
            {
                int pivot = arr[left];//choose first element 
                int i = left + 1; int j = right;
                while (i <= j)
                {
                    while (arr[j] >= pivot)
                    {
                        if (j == left + 1) break;
                        j--;
                    }
                    while (arr[i] <= pivot)
                    {
                        if (i == right) break;
                        i++;
                    }
                    if (i <= j)
                    {
                        swap(ref arr[i], ref arr[j]);
                        i++;
                        j--;
                    }
                }
                swap(ref arr[left], ref arr[j]);
                return j;
            }
        }
    }
}
#endregion
