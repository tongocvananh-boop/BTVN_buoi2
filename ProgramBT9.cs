/*
Tình huống – “Phân loại chữ cái: nguyên âm hay phụ âm”
Bạn đang phát triển một trò chơi học chữ cái tiếng Anh cho trẻ em. Khi người dùng nhập vào một ký tự, chương
trình sẽ tự động phân loại:
Nếu ký tự là nguyên âm (a, e, i, o, u – không phân biệt hoa/thường) → in ra “Là nguyên âm”
Ngược lại → in “Là phụ âm”
*/

//input
Console.WriteLine($@"Hay nhap vao chu cai bat ky: ");
string chuCai = Console.ReadLine();
//output
string ketQua = "";
//process
if (chuCai == "u" || chuCai == "U")
{
    Console.WriteLine($@"La nguyen am");
}
else if (chuCai == "e" || chuCai == "E")
{
    Console.WriteLine($@"La nguyen am");
}
else if (chuCai == "o" || chuCai == "O")
{
    Console.WriteLine($@"La nguyen am");
}
else if (chuCai == "a" || chuCai == "A")
{
    Console.WriteLine($@"La nguyen am");
}
else if (chuCai == "i" || chuCai == "I")
{
    Console.WriteLine($@"La nguyen am");
}
else
{
    Console.WriteLine($@"La phu am");
}