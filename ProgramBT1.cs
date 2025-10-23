/*
Bài 1:
Tình huống: Bạn đang xây dựng một ứng dụng ghi lại nhiệt độ trong ngày để hỗ trợ cảnh báo thời tiết. Khi
người dùng nhập vào một con số biểu thị nhiệt độ (°C), hệ thống cần phải phản hồi:
Nếu nhiệt độ lớn hơn 0 → hiển thị “🌤️ Trời ấm”
Nếu nhiệt độ nhỏ hơn 0 → hiển thị “❄️ Trời lạnh, có thể có băng giá!”
Nếu nhiệt độ bằng 0 → hiển thị “🌫️ Trời rất lạnh, đúng 0°C!”
*/

//input: double nhietDo
Console.WriteLine($@"Hãy nhập nhiệt độ: ");
double nhietDo = double.Parse(Console.ReadLine());
//output: string thoiTiet
string thoiTiet = "";


//process:
thoiTiet = nhietDo switch
{
    < 0 => "Trời lạnh, có thể có băng giá!", //nho hon 0 "Trời lạnh, có thể có băng giá!"
    0 => "Trời rất lạnh, đúng 0°C!", // bang 0 "Trời rất lạnh, đúng 0°C!"
    > 0 => "Trời ấm", // lon hon 0 "Trời ấm"
};

Console.WriteLine($@"Nhiệt độ {nhietDo}°C - {thoiTiet}");