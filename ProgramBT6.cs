/*
Tình huống – “Tính tiền điện cho hộ gia đình”
Bạn đang xây dựng một chương trình hỗ trợ tính tiền điện hàng tháng cho các hộ gia đình. Khi người dùng
nhập vào số điện tiêu thụ trong tháng (tính bằng kWh), chương trình sẽ tính tiền điện phải trả theo biểu giá đơn
giản hóa sau:
Mức tiêu thụ (kWh)      Đơn giá(VND/kWh)
Dưới 100 kWh            1.500
Từ 100 đến 200 kWh      2.000
Trên 200 kWh            2.500
*/

//input
Console.WriteLine($@"Hay nhap vao muc tieu thu dien (kWh): ");
double dienTieuThu = Convert.ToDouble(Console.ReadLine());
//output
double donGia = 0;
//process
donGia = dienTieuThu switch
{
    >= 0 and < 100 => dienTieuThu * 1500,
    >= 100 and <= 200 => dienTieuThu * 2000,
    > 200 => dienTieuThu * 2500,
    _ => -1
};
//xuat
if (dienTieuThu == -1)
{
    Console.WriteLine($@"Nhap sai thong tin");
}
else
{
    Console.WriteLine($@"Voi muc tieu thu la: {dienTieuThu} kWh 
=> Tien dien la: {donGia:N0} VND");
}


