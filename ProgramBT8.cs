/*
🚕 Tình huống – “Tính tiền taxi cho khách hàng”
Bạn đang viết một ứng dụng cho hãng taxi giúp tự động tính tiền cước dựa vào số km mà khách đã đi. Biểu giá tính như sau:
Quãng đường                 Đơn giá (VND/km)
1 km đầu tiên               10.000 VND
Từ km thứ 2 đến km thứ 5    8.000 VND/km
Từ km thứ 6 trở đi          6.000 VND/km
*/

//input
Console.WriteLine($@"So km da di: ");
double km = Convert.ToDouble(Console.ReadLine());
//output
double donGia = 0;
//process
donGia = km switch
{
    >= 0 and <= 1 => 10_000,
    >= 2 and <= 5 => km * 8_000,
    >= 6 => km * 6_000,
    _ => -1
};

//xuat
if (donGia == -1)
{
    Console.WriteLine($@"Nhap sai thong tin");
}
else
{
    Console.WriteLine($@"Quang duong {km} km
Cuoc phi la {donGia:N0} VND");
}
