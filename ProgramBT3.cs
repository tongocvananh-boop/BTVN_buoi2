/*
Bài 3: 🧭 Tình huống – “Xác định mùa trong năm từ số tháng”
Hãy xây dựng một chức năng cho ứng dụng lịch Việt Nam. Khi người dùng nhập vào số tháng (từ 1 đến 12),
chương trình cần xác định xem tháng đó thuộc mùa nào trong năm:
Xuân: Tháng 1, 2, 3
Hạ: Tháng 4, 5, 6
Thu: Tháng 7, 8, 9
Đông: Tháng 10, 11, 12
*/

//input
Console.WriteLine($@"Hãy nhập tháng muốn biết mùa:");
int soThang = int.Parse(Console.ReadLine());
//output
string mua = "";
//process
mua = soThang switch
{
    >= 1 and <= 3 => "mùa Xuân",
    >= 4 and <= 6 => "mùa Hạ",
    >= 7 and <= 9 => "mùa Thu",
    >= 10 and <= 12 => "mùa Đông",
    _ => "Nhập sai thông tin"
};
//xuat
if (soThang >= 0 && soThang <= 12)
{
    Console.WriteLine($@"Tháng {soThang} là {mua}");
}
else
{
    Console.WriteLine($@"{mua}");
}

