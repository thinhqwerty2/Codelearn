using System;
namespace OOP
{
  public class Date
  {
    public int day { set; get; }
    public int month { set; get; }
    public int year { set; get; }
    public Date(int day, int month, int year)
    {
      this.day = day;
      this.month = month;
      this.year = year;
    }
    public Date()
    {

    }
    public static void NhapDate(Date date)
    {
      date = new Date();
      Console.WriteLine("Nhap ngay:");
      date.day = int.Parse(Console.ReadLine());
      Console.WriteLine("Nhap month:");
      date.month = int.Parse(Console.ReadLine());
      Console.WriteLine("Nhap year:");
      date.year = int.Parse(Console.ReadLine());
    }
    public override string ToString()
    {
      return string.Format($"{day}//{month}//{year}");
    }



  }
  public class Vemaybay
  {
    public string tenchuyen { set; get; }
    public Date ngaybay { set; get; }
    public double giave { set; get; }
    public Vemaybay(string tenchuyen, Date ngaybay, double giave)
    {
      this.tenchuyen = tenchuyen;
      this.ngaybay = ngaybay;
      this.giave = giave;
    }
    public Vemaybay()
    {

    }
    public static void NhapVe(Vemaybay[] ve)
    {
      for (int i = 0; i < ve.Length; i++)
      {
        ve[i] = new Vemaybay();
        Console.WriteLine("Nhap ten chuyen");
        ve[i].tenchuyen = Console.ReadLine();
        Console.WriteLine("Nhap ngay bay");
        Date.NhapDate(ve[i].ngaybay);
        Console.WriteLine("Nhap gia ve");
        ve[i].giave = double.Parse(Console.ReadLine());
      }

    }
    public override string ToString()
    {
      return string.Format("Ten chuyen: {0}\nNgay bay: {1}\nGia ve: {2}", this.tenchuyen, this.ngaybay, this.giave);
    }

  }
  public class Nguoi
  {
    public string hoten { set; get; }
    public string gioitinh { set; get; }
    public int tuoi { set; get; }
    public Nguoi()
    { }
    public Nguoi(string hoten, string gioitinh, int tuoi)
    {
      this.hoten = hoten;
      this.gioitinh = gioitinh;
      this.tuoi = tuoi;
    }
    public static void Nhap(Nguoi nguoi)
    {
      Console.WriteLine("Nhap ho ten:");
      nguoi.hoten = Console.ReadLine();
      Console.WriteLine("Nhap gioi tinh:");
      nguoi.gioitinh = Console.ReadLine();
      Console.WriteLine("Nhap tuoi:");
      nguoi.tuoi = int.Parse(Console.ReadLine());
    }
    public override string ToString()
    {
      return string.Format($"Ho ten: {this.hoten}\nGioi tinh: {this.gioitinh}\nTuoi: {this.tuoi}");
    }

  }
  public class Hanhkhach : Nguoi
  {
    public Vemaybay[] ve { set; get; }
    public int soluongve { set; get; }
    public Hanhkhach()
    { }
    public Hanhkhach(string hoten, string gioitinh, int tuoi, Vemaybay[] ve, int soluongve) : base(hoten, gioitinh, tuoi)
    {
      this.ve = ve;
      this.soluongve = soluongve;
    }
    public override string ToString()
    {
      return base.ToString() + this.ve.ToString() + soluongve;
    }
    public double tongtien()
    {
      double s = 0;
      for (int i = 0; i < this.ve.Length; i++)
      {
        s += this.ve[i].giave;
      }
      return s;

    }
    public static void NhapHK(Hanhkhach hanhkhach)
    {
      Nguoi.Nhap(hanhkhach);
      Console.WriteLine("Nhap so luong ve");
      hanhkhach.soluongve = int.Parse(Console.ReadLine());
      for (int i = 0; i < hanhkhach.soluongve; i++)
      {
        Console.WriteLine("Nhap thong tin ve");
        hanhkhach.ve = new Vemaybay[hanhkhach.soluongve];
        Vemaybay.NhapVe(hanhkhach.ve);
      }

    }
  }
}