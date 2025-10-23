/*
✈️ Tình huống – “Xác định tiện ích theo loại vé máy bay”
Bạn đang xây dựng một hệ thống đặt vé máy bay online. Khi hành khách chọn loại vé (Economy, Business hoặc
First Class), hệ thống cần hiển thị tiện ích tương ứng như sau:
Loại vé         Tiện ích đi kèm
Economy         Ghế thường
Business        Ghế rộng
First Class     Ghế sang trọng
*/

//input: Loai ve (int)
Console.WriteLine($@"Hay nhap loai ve (Economy - 1, Business - 2, First Class - 3): ");
int loaiVe = Convert.ToInt32(Console.ReadLine());

//output
string tienIch = "";

//process
tienIch = loaiVe switch
{
    1 => "tien ich ban nhan duoc la: Ghe thuong",
    2 => "tien ich ban nhan duoc la: Ghe rong",
    3 => "tien ich ban nhan duoc la: Ghe sang trong",
    _ => "Nhap sai thong tin"
};

string loaiVeLa = "";
loaiVeLa = loaiVe switch
{
    1 => "Loai ve: Economy, ",
    2 => "Loai ve: Business, ",
    3 => "Loai ve: First Class, ",
    _ => ""
};

//xuat
Console.WriteLine($@"{loaiVeLa}{tienIch}");

// if (loaiVe == 1)
// {
//     loaiVeLa = "Economy";
//     Console.WriteLine($@"Loai ve {loaiVeLa}
// Tien ich ban nhan duoc la {tienIch}");
// }
// else if (loaiVe == 2)
// {
//     loaiVeLa = "Business";
//     Console.WriteLine($@"Loai ve {loaiVeLa}
// Tien ich ban nhan duoc la {tienIch}");
// }
// else if (loaiVe == 3)
// {
//     loaiVeLa = "First Class";
//     Console.WriteLine($@"Loai ve {loaiVeLa}
// Tien ich ban nhan duoc la {tienIch}");
// }
// else
// {
//     Console.WriteLine($@"Nhap sai thong tin");
// }





