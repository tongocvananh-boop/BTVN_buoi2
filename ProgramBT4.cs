/*
Tình huống – “Kiểm tra độ tuổi tham gia nghĩa vụ quân sự”
Bạn được giao xây dựng một chương trình hỗ trợ cho cán bộ xã trong việc rà soát danh sách thanh niên đủ điều
kiện tham gia nghĩa vụ quân sự.
Cán bộ sẽ nhập tuổi của công dân, và hệ thống sẽ phân loại kết quả như sau:
Nếu dưới 18 tuổi → ❌ Chưa đủ tuổi tham gia NVQS
Nếu từ 18 đến 27 tuổi → ✅ Đủ tuổi tham gia NVQS
Nếu trên 27 tuổi → ⛔ Quá tuổi tham gia NVQS
*/

//input
Console.WriteLine($@"Hãy nhập độ tuổi của bạn: ");
int doTuoi = int.Parse(Console.ReadLine());

//output
string ketQua = "";

//process
ketQua = doTuoi switch
{
    >= 0 and < 18 => "Chưa đủ tuổi tham gia NVQS",
    >= 18 and <= 27 => "Đủ tuổi tham gia NVQS",
    > 27 => "Quá tuổi tham gia NVQS",
    _ => "0"
};

//xuat
if (ketQua == "0")
{
    Console.WriteLine($@"Nhập sai thông tin");
}
else
{
    Console.WriteLine($@"{doTuoi} tuổi - {ketQua}");
}
