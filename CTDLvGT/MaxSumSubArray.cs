using System;
namespace CTDLvGT
{
  public class MaxSumSubArray
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
    //si la tong day con lon nhat cua day a1,a2,...ai
    //Do day con lon nhat cua day nay hoac la chua ai hoac la ko chua ai nen no chi la 1 trong 2 day
    //1.a1,a2,...a(i-1) (1)
    //2.a1,a2,...ai va ket thuc tai ai (2)
    //si=max(s(i-1),ei) i=2,...n
    //ei la tong day con lon nhat cua day (2) 
    //ei=max(ai,e(i-1)+ai) i=2,...n
    //e1=a1

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
}