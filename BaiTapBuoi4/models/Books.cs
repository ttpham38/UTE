namespace BaiTapBuoi4.models;

public class Books
{
    public string MaSach { get; set; }
    public string TenSach { get; set; }
    public int NamXuatBan { get; set; }
    public int Gia { get; set; }

    public Books(string maSach, string tenSach, int namXuatBan, int gia)
    {
        MaSach = maSach;
        TenSach = tenSach;
        NamXuatBan = namXuatBan;
        Gia = gia;
    }
    
    public override string ToString()
    {
        return $"MaSach: {MaSach}, TenSach: {TenSach}, NamXuatBan: {NamXuatBan}, Gia: {Gia}";
    }
}