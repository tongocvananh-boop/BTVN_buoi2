/*
Tình huống – “Lọc số đặc biệt cho hệ thống bảo mật”
Bạn đang phát triển một hệ thống tạo mật khẩu bảo mật, trong đó chỉ chấp nhận những con số “đặc biệt”
– tức là số nguyên tố.
Để đảm bảo tính chính xác, bạn cần viết một chương trình giúp kiểm tra xem một số nguyên người dùng nhập
vào có phải là số nguyên tố hay không
*/

//input
Console.WriteLine($@"Hay nhap vao mot so nguyen to: ");
int nguoiDung = Convert.ToInt32(Console.ReadLine());
//output
string soNguyenTo = "Day la so nguyen to";
string khongPhai = "Day khong phai la so nguyen to";
//process
if (nguoiDung % 2 == 0)
{
    Console.WriteLine($@"{khongPhai}");
}
else
{
    Console.WriteLine($@"{soNguyenTo}");
}