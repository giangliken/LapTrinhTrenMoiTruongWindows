using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class Program
    {
        static List<Student> danhSachSinhVien = new List<Student>();
        static void Main(string[] args)
        {
            // Them sinh vien vao danh sach
            Student st1 = new Student(1234, "Nguyen Truong Giang", 21);
            danhSachSinhVien.Add(st1);
            Student st2 = new Student(1235, "Pham Tien Dong", 10);
            danhSachSinhVien.Add(st2);
            Student st3 = new Student(1236, "Vo Tan Tai", 15);
            danhSachSinhVien.Add(st3);
            Student st4 = new Student(1237, "Duong Minh Tien", 18);
            danhSachSinhVien.Add(st4);
            Student st5 = new Student(1238, "AHo Xuan Nguyen", 40);
            danhSachSinhVien.Add(st5);

            // Menu
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("==== MENU QUAN LY SINH VIEN ====");
                Console.WriteLine("1. Xuat danh sach sinh vien");
                Console.WriteLine("2. Xuat danh sach sinh vien tuoi tu 15 den 18");
                Console.WriteLine("3. Xuat danh sach sinh vien co ten bat dau bang chu A");
                Console.WriteLine("4. Tinh tong tuoi cua danh sach sinh vien");
                Console.WriteLine("5. Xuat sinh vien co tuoi lon nhat");
                Console.WriteLine("6. Xuat danh sach sinh vien tang dan theo tuoi");
                Console.WriteLine("0. Thoat");
                Console.Write("Nhap lua chon cua ban: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        xuatDanhSachSinhVien();
                        break;
                    case 2:
                        xuatDanhSachSinhVienTuoi1518();
                        break;
                    case 3:
                        xuatDanhSachSinhVienTenChuA();
                        break;
                    case 4:
                        Console.WriteLine("Tong tuoi cua danh sach sinh vien: " + tinhTongTuoiSinhVien());
                        break;
                    case 5:
                        xuatDanhSachSinhVienTuoiMax();
                        break;
                    case 6:
                        xuatDanhSachTangTheoTuoi();
                        break;
                    case 0:
                        Console.WriteLine("Thoat chuong trinh.");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le, vui long thu lai.");
                        break;
                }

                if (choice != 0)
                {
                    Console.WriteLine("Nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                }

            } while (choice != 0);
            Console.ReadKey();

        }

        static public void xuatDanhSachSinhVien()
        {
            var sinhVienQuery = from sv in danhSachSinhVien
                                select sv;

            Console.WriteLine("Danh sach sinh vien:");
            foreach (var sv in sinhVienQuery)
            {
                Console.WriteLine($"ID: {sv.ID1}, Ten: {sv.Name1}, Tuoi: {sv.Age1}");
            }
        }

        static public void xuatDanhSachSinhVienTuoi1518()
        {
            var sinhVienQuery = from sv in danhSachSinhVien
                                where sv.Age1 >= 15 && sv.Age1 <= 18
                                select sv;

            Console.WriteLine("Danh sach sinh vien:");
            foreach (var sv in sinhVienQuery)
            {
                Console.WriteLine($"ID: {sv.ID1}, Ten: {sv.Name1}, Tuoi: {sv.Age1}");
            }
        }

        static public void xuatDanhSachSinhVienTenChuA()
        {
            var sinhVienQuery = from sv in danhSachSinhVien
                                where sv.Name1.StartsWith("A")
                                select sv;

            Console.WriteLine("Danh sach sinh vien:");
            foreach (var sv in sinhVienQuery)
            {
                Console.WriteLine($"ID: {sv.ID1}, Ten: {sv.Name1}, Tuoi: {sv.Age1}");
            }
        }

        static public int tinhTongTuoiSinhVien()
        {
            int tongTuoi = danhSachSinhVien.Sum(sv => sv.Age1);
            return tongTuoi;
        }

        static public void xuatDanhSachSinhVienTuoiMax()
        {
            int maxTuoi = danhSachSinhVien.Max(sv => sv.Age1);

            var sinhVienQuery = from sv in danhSachSinhVien
                                where sv.Age1 == maxTuoi
                                select sv;

            Console.WriteLine("Danh sach sinh vien co tuoi lon nhat:");
            foreach (var sv in sinhVienQuery)
            {
                Console.WriteLine($"ID: {sv.ID1}, Ten: {sv.Name1}, Tuoi: {sv.Age1}");
            }
        }


        static public void xuatDanhSachTangTheoTuoi()
        {

            var sinhVienQuery = from sv in danhSachSinhVien
                                orderby sv.Age1
                                select sv;

            Console.WriteLine("Danh sach sinh vien");
            foreach (var sv in sinhVienQuery)
            {
                Console.WriteLine($"ID: {sv.ID1}, Ten: {sv.Name1}, Tuoi: {sv.Age1}");
            }
        }

    }
}
