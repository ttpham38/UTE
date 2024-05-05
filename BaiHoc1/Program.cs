
using System;
using System.Collections.Generic;
struct MonHoc
{
    public string MaMonHoc;
    public string TenMonHoc;
    public int SoTinChi;
    public double Diem;
}

struct SinhVien
{
    public string MaSV;
    public string HoTen;
    public DateTime NgaySinh;
    public int SoMonHoc;
    public List<MonHoc> DanhSachMonHoc;
}

class Program
{
//a. Nhập danh sách n sinh viên 
    static List<SinhVien> NhapDanhSachSinhVien()
    {
        List<SinhVien> danhSachSinhVien = new List<SinhVien>();

        Console.Write("Nhập số lượng sinh viên: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            SinhVien sv = new SinhVien();

            Console.WriteLine($"Nhập thông tin sinh viên thứ {i + 1}:");
            Console.Write("Mã sinh viên: ");
            sv.MaSV = Console.ReadLine();

            Console.Write("Họ và tên: ");
            sv.HoTen = Console.ReadLine();

            Console.Write("Ngày sinh (yyyy-mm-dd): ");
            sv.NgaySinh = DateTime.Parse(Console.ReadLine());

            Console.Write("Số môn học: ");
            sv.SoMonHoc = int.Parse(Console.ReadLine());

            sv.DanhSachMonHoc = new List<MonHoc>();
            for (int j = 0; j < sv.SoMonHoc; j++)
            {
                MonHoc mh = new MonHoc();

                Console.WriteLine($"Nhập thông tin môn học thứ {j + 1}:");
                Console.Write("Mã môn học: ");
                mh.MaMonHoc = Console.ReadLine();

                Console.Write("Tên môn học: ");
                mh.TenMonHoc = Console.ReadLine();

                Console.Write("Số tín chỉ: ");
                mh.SoTinChi = int.Parse(Console.ReadLine());

                Console.Write("Điểm: ");
                mh.Diem = double.Parse(Console.ReadLine());

                sv.DanhSachMonHoc.Add(mh);
            }

            danhSachSinhVien.Add(sv);
        }

        return danhSachSinhVien;
    }
//b.Hiển thị danh sách sinh viên 
    static void HienThiDanhSachSinhVien(List<SinhVien> danhSachSinhVien)
    {
        Console.WriteLine("Danh sách sinh viên:");
        foreach (var sv in danhSachSinhVien)
        {
            Console.WriteLine($"MSSV: {sv.MaSV}");
            Console.WriteLine($"Họ tên: {sv.HoTen}");
            Console.WriteLine($"Số môn học: {sv.SoMonHoc}");
            Console.WriteLine("Danh sách môn học:");
            foreach (var mh in sv.DanhSachMonHoc)
            {
                Console.WriteLine($"  - Mã môn học: {mh.MaMonHoc}");
                Console.WriteLine($"    Tên môn học: {mh.TenMonHoc}");
                Console.WriteLine($"    Số tín chỉ: {mh.SoTinChi}");
                Console.WriteLine($"    Điểm: {mh.Diem}");
            }
            Console.WriteLine();
        }
    }
//c. Đếm số lượng SV có học bổng ( có học bổng là : dtb tích luỹ >= 7.0 ) 
    static int DemSoLuongCoHocBong(List<SinhVien> danhSachSinhVien)
    {
        int count = 0;
        foreach (var sv in danhSachSinhVien)
        {
            double diemTongKet = 0;
            foreach (var mh in sv.DanhSachMonHoc)
            {
                diemTongKet += mh.Diem;
            }
            diemTongKet /= sv.SoMonHoc;

            if (diemTongKet >= 7.0)
            {
                count++;
            }
        }
        return count;
    }
    static void Main(string[] args)
    {
        List<SinhVien> danhSachSinhVien = NhapDanhSachSinhVien();
        HienThiDanhSachSinhVien(danhSachSinhVien);
        int soLuongHocBong = DemSoLuongCoHocBong(danhSachSinhVien);
        Console.WriteLine($"Số lượng sinh viên có học bổng: {soLuongHocBong}");
    }
}

// Đề bài 
// Xây dựng cấu trúc Monhoc, Sinhvien ( C# consolve )
// Monhoc : MaMH , TenMH,SoTinChi,Diem
// Sinhvien: Masv , hoten,ngaysinh, somonhoc
//
// 1.Xây dựng các chức năng sau :
// a.Nhập danh sách n sinh viên 
// b.Hiển thị danh sách sinh viên 
//
// c. Đếm số lượng SV có học bổng ( có học bổng là : dtb tích luỹ >= 7.0 ) 
//
//     *DTB tích luỹ : ( tín chỉ 1 môn học * dtb môn 1.  tín chỉ môn 2 * dtb môn 2 + ...) 