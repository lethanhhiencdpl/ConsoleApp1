using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SoNguyen_ChiaHetCho3();
            //BangCuuChuong_1n();
            TongGiaiThua_1n();
            //SoChinhPhuong();
            //SoNgayTrongThang();
            //TinhTongS();
            //TinhTongSoLe();
            //SoNguyenTo();
            //VeTamGiac();
            //VeTamGiacDeu();
            //VeTamGiacXoayNguoc();
            //Day_Fibonacci();
        }
        //Bài 1: Viết chương trình nhập vào số nguyên và kiểm tra xem số đó có chia hết cho 3 hay không.Hiển thị kết quả ra màn hình.
        static void SoNguyen_ChiaHetCho3()
        {
            Console.Write("Moi nhap so nguyen n = ");
            int n = int.Parse(Console.ReadLine());

            //Cách 1:
            //if (n % 3 == 0) //DK chia het cho 3
            //{
            //    Console.WriteLine("Gia tri vua nhap vao chia het cho 3");
            //}
            //else
            //{
            //    Console.WriteLine("Gia tri vua nhap vao khong chia het cho 3");
            //}

            //Cách 2
            Console.WriteLine( n%3==0 ? "Gia tri vua nhap vao lon hon 0 va chia het cho 3" : "Gia tri vua nhap vao nho hon 0 va k chia het cho 3");
            Console.ReadKey();
        }

        //Bài 2: Nhập vào số nguyên dương n, hiển thị bảng cửu chương từ 1 đến n ra màn hình.
        static void BangCuuChuong_1n()
        {
            Console.Write("Moi nhap so nguyen duong n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("{0}*{1}={2} ",i,j,i*j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        //Bài 3: Nhập vào số nguyên dương từ n từ bàn phím, tính tổng giai thừa từ 1 đến n và hiển thị kết quả ra màn hình
        static void TongGiaiThua_1n()
        {
            Console.Write("Moi nhap so nguyen duong n = ");
            int n = int.Parse(Console.ReadLine());

            int S_n = 0;
            for (int i = 1; i <= n; i++)
            {
                S_n += i;
            }
            Console.Write("Tong giai thua tu 1 den {0} la: {1}",n, S_n);
            Console.ReadKey();
        }

        //Bài 4: Viết chương trình nhập vào số nguyên từ bàn phím, kiểm tra xem số đó có phải là số chính phương hay không.Hiển thị kết quả đạt được ra màn hình.
        static void SoChinhPhuong()
        {
            Console.Write("Moi nhap so nguyen n = ");
            int n = int.Parse(Console.ReadLine());

            bool SoCP=false;
            for(int i = 1;i <= n; i++)
            {
                if (i*i==n)
                {
                    SoCP = true;
                    break;

                }
            }
            Console.WriteLine(SoCP==true ? "N la so chinh phuong" : "N khong phai la so chinh phuong");
            Console.ReadKey();
        }

        //Bài 5: Viết chương trình nhập vào tháng bất kỳ từ bàn phím, hiển thị số ngày có trong tháng ra màn hình.
        static void SoNgayTrongThang()
        {
            Console.Write("Moi nhap thang = ");
            int n = int.Parse(Console.ReadLine());

            if (n == 2) Console.Write("Co 28 hoac 29 ngay");
            if (n == 4 || n == 6 || n == 9 || n == 12) Console.Write("Co 30 ngay");
            if (n == 1 || n == 3 || n == 5 || n == 7 || n == 8 || n == 11) Console.Write("Co 31 ngay");

            Console.ReadKey();
        }

        //Bài 6: Viết chương trình nhập vào số nguyên n, tính tổng S theo kết quả ra màn hình. 𝑆 = 1 + 22 + 33 + 44 + ⋯ + 𝑛𝑛
        static void TinhTongS()
        {
            Console.Write("Moi nhap so nguyen n = ");
            int n = int.Parse(Console.ReadLine());

            int S = 0;
            for (int i = 1; i <= n; i++)
            {
                S +=Convert.ToInt16( Math.Pow(i, i));
            }
            Console.Write("Tong S la: {0}", S);
            Console.ReadKey();
        }
        //Bài 7: Viết chương trình nhập vào số nguyên n, tính tổng các số lẽ từ 1 đến n và hiển thị kết quả ra màn hình
        static void TinhTongSoLe()
        {
            Console.Write("Moi nhap so nguyen n = ");
            int n = int.Parse(Console.ReadLine());

            int S = 0;
            for (int i = 1; i <= n; i += 2)
            {
                    S += i;
            }
            Console.Write("Tong S la: {0}", S);
            Console.ReadKey();
        }

        //Bài 8: Nhập vào số nguyên dương n, hiển thị ra màn hình các số nguyên tố từ 1 đến n
        static void SoNguyenTo()
        {
            Console.Write("Moi nhap so nguyen duong n = ");
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i <= n; i++)
            {
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("{0}", i);
                }

                // Đặt lại giá trị của isPrime
                isPrime = true;
            }          
            Console.ReadKey();
        }


        //Bài 9: Viết chương trình nhập vào số hàng n, vẽ tam giác * với số hàng tương ứng.
        //Ví dụ, nhập vào 10 hàng, thì ta sẽ được 1 tam giác như hình bên dưới.
        //Có thể thử vẽ thêm với hình tam giác đều, tam giác xoay ngược.
        // Vẽ tam giác cân

        static void VeTamGiac()
        {
            Console.Write("Moi nhap so nguyen duong n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void VeTamGiacDeu()
        {
            Console.Write("Moi nhap so nguyen duong n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void VeTamGiacXoayNguoc()
        {
            Console.Write("Moi nhap so nguyen duong n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }


        //Bài 10: Nhập vào số nguyên dương n, tính toán và hiển thị dãy Fibonacci ra màn hình.

        static void Day_Fibonacci()
        {
            Console.Write("Moi nhap so nguyen duong n = ");
            int n = int.Parse(Console.ReadLine());

            // Khởi tạo hai biến đầu tiên của dãy Fibonacci
            int a = 0;
            int b = 1;

            // Hiển thị dãy Fibonacci
            Console.Write("Day Fibonacci la: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", a);

                // Tính toán số Fibonacci tiếp theo
                int c = a + b;
                a = b;
                b = c;
            }
            Console.ReadKey();
        }



        //Bài 11: test GIT.

    }
}
