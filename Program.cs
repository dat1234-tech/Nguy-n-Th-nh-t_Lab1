using System;
// Câu 1: Nhập họ tên, năm sinh; tính tuổi gần đúng và hiển thị thông tin theo
// định dạng rõ ràng. 
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;
//Console.Write("Nhập họ tên: ");
//string name = Console.ReadLine(); 

//Console.Write("Nhập năm sinh: ");
//if (!int.TryParse(Console.ReadLine(), out int date))
//{
//    Console.WriteLine("Nhập năm sinh không hợp lệ");
//    return;
//}
//int namSinh = DateTime.Now.Year - date;

//Console.WriteLine("Họ Tên: {0}, Tuổi: {1}", name, namSinh);

//Câu 2: Nhập bán kính và chiều cao; tính diện tích xung quanh và thể tích.
//Không chấp nhận số âm hoặc bằng 0.
//Console.Write("Nhập bán kính: ");
//if (!double.TryParse(Console.ReadLine(), out double r) || r <= 0)
//{
//    Console.WriteLine("Nhập sai bán kính");
//    return;
//}
//Console.Write("Nhập chiều cao: ");
//if(!double.TryParse(Console.ReadLine(),out double h) || h <= 0)
//{
//    Console.WriteLine("Nhập sai chiều cao");
//    return;
//}

//double dienTichXQ = 2 * Math.PI * r * h;
//double theTich = Math.PI * r * r * h;
//Console.WriteLine("Sxq = {0:N2}, V = {1:N2}", dienTichXQ, theTich);

//Câu 3: Nhập điểm từ 0 đến 10 và xếp loại: Xuất sắc, Giỏi, Khá, Trung bình, Yếu.
//Console.Write("Nhập điểm của bạn: ");
//if(!double.TryParse(Console.ReadLine(), out double diem) || diem < 0 || diem > 10)
//{
//    Console.WriteLine("Nhập điểm sai!");
//    return;
//}
//else if(diem >= 9)Console.WriteLine("Xuất sắc");
//else if (diem >= 8) Console.WriteLine("Giỏi");
//else if (diem >= 6.5) Console.WriteLine("Khá");
//else if (diem >= 5) Console.WriteLine("Trung bình");
//else Console.WriteLine("Yếu");

//Câu 4: Tạo menu lặp cho phép tính tổng 1..n, in bảng cửu chương hoặc thoát chương trình.
//int chon;
//string y;
//do
//{
//    Console.WriteLine("Chọn 1 trong 3: ");
//    Console.WriteLine("1: tính tổng 1...n");
//    Console.WriteLine("2: in bảng cửu chương bất kỳ");
//    Console.WriteLine("3: Thoát");
//    int.TryParse(Console.ReadLine(), out chon);
//    switch (chon)
//    {
//        case 1:
//            Console.Write("Nhập số bất kỳ: ");
//            int.TryParse(Console.ReadLine(), out int n);
//            int tong = 0;
//            for(int i = 1;  i <= n; i ++)
//            {
//                tong = tong + i;
//            }
//            Console.WriteLine("Tổng từ 1 đến {0} là: {1}",n,tong);
//            break;
//        case 2:
//            Console.Write("Nhập số bất kỳ: ");
//            int.TryParse(Console.ReadLine(), out int m);
//            for(int i = 1; i<= 10; i++)
//            {
//                Console.WriteLine("{0} x {1} = {2}",i,m, i*m);
//            }
//            break;
//    }
//    Console.WriteLine("Muốn tiếp tục: (Y/N)");
//    y = Console.ReadLine();
//} while (y == "Y");

//Câu 5: Nhập hai số nguyên, thực hiện phép chia và xử lý lỗi định dạng, chia cho 0.
//try
//{

//    Console.Write("Nhập số nguyên a: ");
//    int a = int.Parse(Console.ReadLine());
//    Console.Write("Nhập số nguyên b: ");
//    int b = int.Parse(Console.ReadLine());
//    Console.WriteLine("Phép chia {0} / {1} = {2}",a,b,a/b);
//}
//catch (FormatException)
//{
//    Console.WriteLine("Nhập sai, phải nhập số");
//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("Không đc phép chia cho 0");
//}
//finally
//{
//    Console.WriteLine("Kết thúc phép tính");
//}

//Câu 6: Nhập a, b, c; xét đầy đủ các trường hợp và hiển thị nghiệm với 2 chữ số thập phân.
//Console.WriteLine("Nhập lần lượt a, b, c");
//double.TryParse(Console.ReadLine(), out double a);
//double.TryParse(Console.ReadLine(), out double b);
//double.TryParse(Console.ReadLine(), out double c);
//double delta = b * b - 4 * a * c;
//if(delta < 0)
//{
//    Console.WriteLine("Pt vô nghiệm");
//}
//else if (delta == 0)
//{
//    Console.WriteLine("Pt có nghiệm kép: {0:N2}",delta);
//}
//else
//{
//    Console.WriteLine("Pt có 2 nghiệm phân biệt: x1 = {0:N2}, x2 = {1:N2}", 
//        (- b + Math.Sqrt(delta)) / 2 * a, (-b - Math.Sqrt(delta)) / 2 * a );
//}

//Câu 7: Nhập n số nguyên; tính tổng, trung bình,
//số lớn nhất, số nhỏ nhất và số lượng số chẵn.
//Console.WriteLine("Nhập số lượng số nguyên bất kỳ: ");
//int.TryParse(Console.ReadLine(), out int n);

//int max = 0, min = 0;
//int tong = 0;
//int soChan = 0;
//for (int i = 1; i <= n; i++)
//{
//    Console.Write($"Số nguyên thứ {i}: ");
//    int.TryParse(Console.ReadLine(), out int SN);
//    tong = tong + SN;
//    if(SN % 2 == 0)
//    {
//        soChan++;
//    }
//    if (max < SN)
//    {
//        max = SN;
//    }
//    if (SN < min)
//    {
//        min = SN;
//    }
//}
//Console.WriteLine("Tổng của {0} số là: {1}", n, tong);
//double trungBinh = 0;
//trungBinh = tong / n;
//Console.WriteLine("Trung bình của {0} số là: {1}",n,trungBinh);

//Console.WriteLine($"Số lớn nhất là: {max}");
//Console.WriteLine($"Số nhỏ nhất là: {min}");
//Console.WriteLine($"Số lượng số chẵn là: {soChan}");

//Câu 8: Nhập n và in các số nguyên tố không vượt quá n; tối ưu kiểm tra đến căn bậc 2
//Console.Write("Nhập số n bất kỳ: ");
//int.TryParse(Console.ReadLine(), out int n);    
//for(int i = 2; i <= n; i++)
//{
//    int j;
//    for (j = 2; j <= Math.Sqrt(i); j++)
//    {
//        if (i % j == 0)
//        {
//            break;
//        }
//    }
//    if(j > Math.Sqrt(i))
//    {
//        Console.WriteLine($"Số nguyên tố phù hợp: {i}");
//    }
//}

//Câu 9: Sử dụng switch để chuyển số nguyên từ 0 đến 99 thành cách đọc tiếng Việt.
//Console.Write("Nhập số cần đọc (0 - 99): ");
//int n = int.Parse(Console.ReadLine());

//if (n < 0 || n > 99)
//{
//    Console.WriteLine("Số nhập vào ngoài khoảng cho phép!");
//}
//else
//{
//    int chuc = n / 10;
//    int donVi = n % 10;
//    string docChuc = "";
//    string docDonVi = "";

//    switch (chuc)
//    {
//        case 0: docChuc = ""; break;
//        case 1: docChuc = "mười"; break;
//        case 2: docChuc = "hai mươi"; break;
//        case 3: docChuc = "ba mươi"; break;
//        case 4: docChuc = "bốn mươi"; break;
//        case 5: docChuc = "năm mươi"; break;
//        case 6: docChuc = "sáu mươi"; break;
//        case 7: docChuc = "bảy mươi"; break;
//        case 8: docChuc = "tám mươi"; break;
//        case 9: docChuc = "chín mươi"; break;
//    }

//    switch (donVi)
//    {
//        case 0:
//            docDonVi = (chuc == 0) ? "không" : "";
//            break;
//        case 1:
//            docDonVi = (chuc > 1) ? "mốt" : "một";
//            break;
//        case 2: docDonVi = "hai"; break;
//        case 3: docDonVi = "ba"; break;
//        case 4: docDonVi = "bốn"; break;
//        case 5:
//            docDonVi = (chuc > 0) ? "lăm" : "năm";
//            break;
//        case 6: docDonVi = "sáu"; break;
//        case 7: docDonVi = "bảy"; break;
//        case 8: docDonVi = "tám"; break;
//        case 9: docDonVi = "chín"; break;
//    }

//    Console.WriteLine($"Cách đọc: {docChuc} {docDonVi}".Trim());
//}

// Câu 10: MENU VẼ HÌNH BẰNG KÝ TỰ (*)
Console.WriteLine("1. Tam giác vuông đặc");
Console.WriteLine("2. Tam giác vuông rỗng");
Console.WriteLine("3. Hình vuông rỗng");
Console.Write("Chọn chức năng (1-3): ");
int choice = int.Parse(Console.ReadLine());

Console.Write("Nhập kích thước n: ");
int size = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        break;

    case 2:
        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= i; j++)
            {

                if (j == 1 || j == i || i == size)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
        break;

    case 3:
        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= size; j++)
            {

                if (i == 1 || i == size || j == 1 || j == size)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
        break;

    default:
        Console.WriteLine("Lựa chọn không hợp lệ!");
        break;
}