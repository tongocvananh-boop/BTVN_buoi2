/*
Tình huống – “Hệ thống đặt vé rạp chiếu phim”
Bạn đang phát triển một ứng dụng đặt vé xem phim online. Khi người dùng chọn hạng vé (Standard, Premium, VIP), 
hệ thống sẽ hiển thị thông tin về tiện ích mà họ nhận được kèm theo vé.
Hạng vé         Tiện ích kèm theo
Standard        Ghế ngồi thường, không có đồ uống
Premium         Ghế ngồi thoải mái, có đồ uống miễn phí
VIP             Ghế ngồi hạng sang, có đồ uống và bỏng ngô miễn phí
*/

//input
Console.WriteLine($@"Hang ve (Standard - 1, Premium - 2, VIP - 3): ");
int hangVe = Convert.ToInt32(Console.ReadLine());
//output
string tienIch = "";
//process
tienIch = hangVe switch
{
    1 => "Ban chon hang ve: Standard\nCac tien ich kem theo: Ghế ngồi thường, không có đồ uống",
    2 => "Ban chon hang ve: Premium\nCac tien ich kem theo: Ghế ngồi thoải mái, có đồ uống miễn phí",
    3 => "Ban chon hang ve: VIP\nCac tien ich kem theo: Ghế ngồi hạng sang, có đồ uống và bỏng ngô miễn phí",
    _ => "Nhap sai thong tin"
};
//xuat
Console.WriteLine($@"{tienIch}");
