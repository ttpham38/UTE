using BaiTapBuoi4.models;
using BaiTapBuoi4.repositories;

class Program
{
    /**
     *  Viết chương trình quản lý các cuốn sách trong thư viện. Biết rằng mỗi cuốn sách cần luôn trữ thông tin sau:
        -	Mã sách: Kiểu chuỗi gồm 6 ký tự tối đa.
        -	Tựa sách: Kiểu chuỗi, dài tối đa 30 ký tự.
        -	Năm xuất bản: Kiểu số nguyên lớn hơn 1900.
        -	Giá: Kiểu số nguyên có tối đa 6 chữ số.
        Yêu cầu:
        -	Khai báo CTDL cho bài toán.
        -	Các chức năng cần có của ứng dụng:
        1.	Viết hàm xhập, xuất danh sách các cuốn sách trong thư viện.
        2.	Tìm kiếm một cuốn sách có tựa là x có xuất hiện trong danh sách hay không (sử dụng giải thuật tìm kiếm tuần tự) sau đó sửa giá của cuốn sách đó thành y.
        3.	Tìm kiếm một cuốn sách có mã sách là x (sử dụng giải thuật tìm kiếm nhị phân) sau đó xóa cuốn sách đó ra khỏi danh sách.
        4.	Sắp xếp danh sách các cuốn sách tăng dần theo mã sách dùng giải thuật selectionSort.
        5.	Sắp xếp danh sách cuốn sách giảm dần theo năm xuất bản dùng giải thuật InsertionSort.
        6.	Sắp xếp danh sách tăng dần theo tựa sách dùng giải thuật BubbleSort.
        7.	Sắp xếp danh sách giảm dần theo giá dùng giải thuật QuickSort.
     */
    
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
                    BookRepository.AddBok(books);
                    break;
                case 2:
                    Console.WriteLine("Ban chon Menu 2");
                    BookRepository.PrintBooks(books);
                    break;
                case 3:
                    Console.WriteLine("Ban chon Menu 3");
                    BookRepository.SearchBookByTenSach(books);
                    break;
                case 4:
                    Console.WriteLine("Ban chon Menu 4");
                    BookRepository.SearchBookByMaSach(books);
                    break;
                case 5:
                    Console.WriteLine("Ban chon Menu 5");
                    BookRepository.SortBooksByMaSach(books);
                    break;
                case 6:
                    Console.WriteLine("Ban chon Menu 6");
                    BookRepository.SortBooksByNamXuatBan(books);
                    break;
                case 7:
                    Console.WriteLine("Ban chon Menu 7");
                    BookRepository.SortBooksByTenSach(books);
                    break;
                case 8:
                    Console.WriteLine("Ban chon Menu 8");
                    BookRepository.SortBooksByGia(books);
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
        Console.WriteLine("***** Chuong trinh quan ly Thu Vien XXX *****");
        Console.WriteLine("* 1. Them sach ");
        Console.WriteLine("* 2. Xem danh sach sach ");
        Console.WriteLine("* 3. Tim Sach (theo Tua Sach) va cap nhat gia");
        Console.WriteLine("* 4. Tim sach (theo Ma Sach) va xoa khoi danh sach");
        Console.WriteLine("* 5. Sap xep danh sach tang dan theo ma");
        Console.WriteLine("* 6. Sap xep danh sach giam dan theo nam xuat ban");
        Console.WriteLine("* 7. Sap xep danh sach tang dan theo tua sach");
        Console.WriteLine("* 8. Sap xep danh sach giam dan theo gia");
        Console.WriteLine("* 0. Thoat");
        Console.WriteLine("-- Moi Ban Chon Menu (Phim Bam) --");
    }
}