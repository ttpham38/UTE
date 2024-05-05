// See https://aka.ms/new-console-template for more information

using BaiTap3.Model;


class Program
{
    static void Main(string[] args)
    {
        int menu;
        List<Books> books = new List<Books>();
        Menu();
        menu = Convert.ToInt32(Console.ReadLine());
        while (menu != 0)
            
        {
            switch (menu)
            {
                case 1:
                    Console.WriteLine("Ban chon Menu 1");
                    ThemSach(books);
                    break;
                case 2:
                    Console.WriteLine("Ban chon Menu 2");
                    PrintBooks(books);
                    break;
                case 3:
                    Console.WriteLine("Ban chon Menu 3");
                    SearchBookByMaSach(books);
                    break;
                case 4:
                    Console.WriteLine("Ban chon Menu 4");
                    SearchBookByTenSach(books);
                    break;
                case 5:
                    Console.WriteLine("Ban chon Menu 5");
                    PrintBooksWithMaxPrice(books);
                    break;
                default:
                    Console.WriteLine("Ban chon Menu khong hop le");
                    break;
            }
            Menu();
            menu = Convert.ToInt32(Console.ReadLine());
        }
        
    }

    static void Menu()
    {
        Console.WriteLine("\n");
        Console.WriteLine("***** Chuong trinh quan ly Thu Vien XXX *****!");
        Console.WriteLine("-- Moi Ban Chon Menu (Phim Bam) --");
        Console.WriteLine("* 1. Them Sach ");
        Console.WriteLine("* 2. Xem Danh Sach Sach ");
        Console.WriteLine("* 3. Tim Sach (theo Ma Sach)");
        Console.WriteLine("* 4. Tim sach (theo Ten Sach)");
        Console.WriteLine("* 5. Tim sach co gia cao nhat");
        Console.WriteLine("* 0. Thoat");
        Console.WriteLine("---------------------------------------");
    }
    
    static List<Books> ThemSach(List<Books> books)
    {
        Console.WriteLine("Nhap Ma Sach: ");
        string maSach = Console.ReadLine();
        Console.WriteLine("Nhap Ten Sach: ");
        string tenSach = Console.ReadLine();
        Console.WriteLine("Nhap Gia: ");
        int gia = Convert.ToInt32(Console.ReadLine());
        books.Add(new Books(maSach, tenSach, gia));
        return books;
    }
    
    static void PrintBooks(List<Books> books)
    {
        Console.WriteLine("Sach trong thu vien: ");
        foreach (var book in books)
        {
            Console.WriteLine($"Ma Sach: {book.MaSach}, Ten Sach: {book.TenSach}, Gia: {book.Gia}");
        }
        Console.WriteLine("-----------------");
    }
    
    static void SearchBookByMaSach(List<Books> books)
    {
        Console.WriteLine("Nhap Ma Sach can tim: ");
        string maSach = Console.ReadLine();
        var book = books.Find(b => b.MaSach == maSach);
        if (book != null)
        {
            Console.WriteLine($"Ma Sach: {book.MaSach}, Ten Sach: {book.TenSach}, Gia: {book.Gia}");
        }
        else
        {
            Console.WriteLine("Khong tim thay sach");
        }
    }
    
    static void SearchBookByTenSach(List<Books> books)
    {
        Console.WriteLine("Nhap Ten Sach can tim: ");
        string tenSach = Console.ReadLine();
        var book = books.Find(b => b.TenSach == tenSach);
        if (book != null)
        {
            Console.WriteLine($"Ma Sach: {book.MaSach}, Ten Sach: {book.TenSach}, Gia: {book.Gia}");
        }
        else
        {
            Console.WriteLine("Khong tim thay sach");
        }
    }
    
    static void PrintBooksWithMaxPrice(List<Books> books)
    {
        var maxPrice = books.Max(b => b.Gia);
        foreach (var book in books)
        {
            if (book.Gia == maxPrice)
            {
                Console.WriteLine($"Sach co gia cao nhat: Ma Sach: {book.MaSach}, Ten Sach: {book.TenSach}, Gia: {book.Gia}");
            }
        }
    }
    
}


