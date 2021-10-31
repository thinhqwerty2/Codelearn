using System;
namespace OOP
{
  public class VanDongVien
  {
    public string hoten { set; get; }
    public int tuoi { set; get; }
    public string monthidau { set; get; }
    public double cannang { set; get; }
    public double chieucao { set; get; }
    public VanDongVien()
    {

    }
    public VanDongVien(string hoten, string monthidau, int tuoi, double cannang, double chieucao)
    {
      this.hoten = hoten;
      this.tuoi = tuoi;
      this.monthidau = monthidau;
      this.cannang = cannang;
      this.chieucao = chieucao;
    }
    ~VanDongVien()
    {
      System.Console.WriteLine($"Huy van dong vien {this.hoten}");
    }
    public static void Nhap1VDV(VanDongVien VDV)
    {
      System.Console.WriteLine("Nhap ho ten VDV");
      VDV.hoten = Console.ReadLine();
      System.Console.WriteLine("Nhap mon thi dau VDV");
      VDV.monthidau = Console.ReadLine();
      System.Console.WriteLine("Nhap tuoi VDV");
      VDV.tuoi = int.Parse(Console.ReadLine());
      System.Console.WriteLine("Nhap can nang VDV");
      VDV.cannang = double.Parse(Console.ReadLine());
      System.Console.WriteLine("Nhap chieu cao VDV");
      VDV.chieucao = double.Parse(Console.ReadLine());
    }
    public override string ToString()
    {
      return string.Format($"Ho ten VDV: {this.hoten}\nTuoi VDV: { this.tuoi}  \nMon thi dau VDV: { this.monthidau}\nCan nang VDV: { this.cannang} \nChieu cao VDV: { this.chieucao}");
    }
    public static bool operator >(VanDongVien VDV1, VanDongVien VDV2)
    {
      if (VDV1.chieucao > VDV2.chieucao) return true;
      else
        if (VDV1.cannang > VDV2.cannang) return true;
      else
        return false;
    }
    public static bool operator <(VanDongVien VDV1, VanDongVien VDV2)
    {
      if (VDV1.chieucao < VDV2.chieucao) return true;
      else
        if (VDV1.cannang < VDV2.cannang) return true;
      else
        return false;
    }
    private static void swap(VanDongVien VDV1, VanDongVien VDV2)
    {
      VanDongVien temp = new VanDongVien();
      temp = VDV1;
      VDV1 = VDV2;
      VDV2 = temp;
    }
    public static void Sort(VanDongVien[] VDVarr)
    {
      for (int i = 0; i < VDVarr.Length - 1; i++)
      {
        int vtrimin = i;
        for (int j = i + 1; j < VDVarr.Length; j++)
        {
          if (VDVarr[j] < VDVarr[vtrimin]) vtrimin = j;
        }
        if (i != vtrimin)
          swap(VDVarr[i], VDVarr[vtrimin]);
      }
    }
  }
}