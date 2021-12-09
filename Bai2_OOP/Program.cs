using System;
using System.Collections.Generic;

namespace Bai2_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            QLTL quanLyTaiLieu = new QLTL();
            while (true)
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY TAI LIEU");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Them tai lieu.                                **");
                Console.WriteLine("**  2. Tim kiem tai lieu theo ma.                    **");
                Console.WriteLine("**  3. Hien thi danh sach tai lieu.                  **");
                Console.WriteLine("**  4. Xoa 1 tai lieu theo ma.                       **");
                Console.WriteLine("**  0. Thoat                                         **");
                Console.WriteLine("*******************************************************");
                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n1. Them tai lieu.");
                        Console.WriteLine("**  1. Them Sach.                                  **");
                        Console.WriteLine("**  2. Them Tap chi.                               **");
                        Console.WriteLine("**  3. Them Bao.                                   **");
                        Console.Write("Nhap tuy chon: ");
                        int select1 = Convert.ToInt32(Console.ReadLine());
                        switch (select1)
                        {
                            case 1:
                                quanLyTaiLieu.NhapSach();
                                Console.WriteLine("\nThem tai lieu Sach thanh cong");
                                break;
                            case 2:
                                quanLyTaiLieu.NhapTapChi();
                                Console.WriteLine("\nThem tai lieu Sach thanh cong");
                                break;
                            case 3:
                                quanLyTaiLieu.NhapBao();
                                Console.WriteLine("\nThem tai lieu Sach thanh cong");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("\n4. Tim kiem tai lieu theo ma.");
                        Console.WriteLine("**  1. Tim kiem Sach.                     **");
                        Console.WriteLine("**  2. Tim kiem Tai lieu.                 **");
                        Console.WriteLine("**  3. TTim kiem Bao.                     **");
                        Console.Write("Nhap tuy chon: ");
                        int select2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nNhap ma tai lieu de tim kiem: ");
                        string name = Convert.ToString(Console.ReadLine());
                        switch (select2)
                        {
                            case 1:
                                List<Sach> searchResult1 = quanLyTaiLieu.timSachTheoMaTaiLieu(name);
                                quanLyTaiLieu.XuatSach(searchResult1);
                                break;
                            case 2:
                                List<TapChi> searchResult2 = quanLyTaiLieu.timTapChiTheoMaTaiLieu(name);
                                quanLyTaiLieu.XuatTapChi(searchResult2);
                                break;
                            case 3:
                                List<Bao> searchResult3 = quanLyTaiLieu.timBaoTheoMaTaiLieu(name);
                                quanLyTaiLieu.XuatBao(searchResult3);
                                break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("\n1. Hien thi danh sach tai lieu.");
                        Console.WriteLine("**  1.Sach.                                  **");
                        Console.WriteLine("**  2.Tap chi.                               **");
                        Console.WriteLine("**  3.Bao.                                   **");
                        Console.WriteLine("**  4.Tat ca.                                **");
                        Console.Write("Nhap tuy chon: ");
                        int select3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n7. Hien thi danh sach can bo.");
                        switch (select3)
                        {
                            case 1:
                                Console.WriteLine("**********        Danh sach sanh       ********");
                                quanLyTaiLieu.XuatSach(quanLyTaiLieu.getListSach());
                                break;
                            case 2:
                                Console.WriteLine("**********       Danh sach tap chi     ********");
                                quanLyTaiLieu.XuatTapChi(quanLyTaiLieu.getListTapChi());
                                break;
                            case 3:
                                Console.WriteLine("**********         Danh sach bao       ********");
                                quanLyTaiLieu.XuatBao(quanLyTaiLieu.getListBao());
                                break;
                            case 4:
                                Console.WriteLine("**********        Danh sach sanh       ********");
                                quanLyTaiLieu.XuatSach(quanLyTaiLieu.getListSach());
                                Console.WriteLine("**********       Danh sach tap chi     ********");
                                quanLyTaiLieu.XuatTapChi(quanLyTaiLieu.getListTapChi());
                                Console.WriteLine("**********         Danh sach bao       ********");
                                quanLyTaiLieu.XuatBao(quanLyTaiLieu.getListBao());
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("\n4. The loai muon xoa.");
                        Console.WriteLine("**  1.Sach                      **");
                        Console.WriteLine("**  2.Tap chi.                  **");
                        Console.WriteLine("**  3.Bao.                      **");
                        Console.Write("Nhap tuy chon: ");
                        int select4 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nNhap ma tai lieu muon xoa: ");
                        string name2 = Convert.ToString(Console.ReadLine());
                        switch (select4)
                        {
                            case 1:
                                if (quanLyTaiLieu.DeleteByIdSach(name2))
                                {
                                    Console.WriteLine("\nSach co ma {0} da bi xoa.", name2);
                                }
                                break;
                            case 2:
                                if (quanLyTaiLieu.DeleteByIdTapChi(name2))
                                {
                                    Console.WriteLine("\nTap chi co ma {0} da bi xoa.", name2);
                                }
                                break;
                            case 3:
                                if (quanLyTaiLieu.DeleteByIdBao(name2))
                                {
                                    Console.WriteLine("\nBao co ma {0} da bi xoa.", name2);
                                }
                                break;
                        }
                        break;
                    case 0:
                        Console.WriteLine("\nBan da chon thoat chuong trinh!");
                        return;
                    default:
                        Console.WriteLine("\nKhong co chuc nang nay!");
                        Console.WriteLine("\nHay chon chuc nang trong hop menu.");
                        break;
                }
            }

        }
    }
}
