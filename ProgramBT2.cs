/*
Bài 2:  Tình huống thực tế – "Tính thuế thu nhập cho người đi làm":
Bạn được giao xây dựng một phần mềm nhỏ để hỗ trợ kế toán công ty tính toán nhanh thuế thu nhập cá nhân
cho nhân viên mỗi tháng.
Kế toán chỉ cần nhập vào số tiền thu nhập hàng tháng, hệ thống sẽ tự động tính toán số thuế phải nộp theo
quy định sau:
Nếu thu nhập ≤ 5 triệu đồng → ✅ Miễn thuế
Nếu thu nhập > 5 triệu và ≤ 10 triệu đồng → 💰 Thuế 10%
Nếu thu nhập > 10 triệu đồng → 💸 Thuế 20%
*/

//input
Console.WriteLine($@"Hãy nhập thu nhập của bạn: ");
double thuNhap = Convert.ToDouble(Console.ReadLine());

//output
double thuePhaiDong = 0;

//process
thuePhaiDong = thuNhap switch
{
    > 0 and <= 5_000_000 => 0,
    > 5_000_000 and <= 10_000_000 => thuNhap * 10 / 100, 
    > 10_000_000 => thuNhap * (20.0 / 100), //.0 để chương trình biết là phép chia số thực (khi bỏ ngoặc)
    _ => -1
};

if (thuePhaiDong == -1)
{
    Console.WriteLine($@"Không thể tính");
}
else

Console.WriteLine($@"Lương {thuNhap:N0} VND thì thuế phải đóng là: {thuePhaiDong:N0} VND");
